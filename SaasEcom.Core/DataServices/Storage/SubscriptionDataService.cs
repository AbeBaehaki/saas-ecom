﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using SaasEcom.Core.DataServices.Interfaces;
using SaasEcom.Core.Models;

namespace SaasEcom.Core.DataServices.Storage
{
    public class SubscriptionDataService<TContext, TUser> : ISubscriptionDataService
        where TContext : IDbContext<TUser>
        where TUser : class
    {
        private readonly TContext _dbContext;

        public SubscriptionDataService(TContext context)
        {
            this._dbContext = context;
        }

        public async Task<Subscription> SubscribeUserAsync(SaasEcomUser user, string planId, int? trialPeriodInDays = null)
        {
            var plan = await _dbContext.SubscriptionPlans.FirstAsync(x => x.Id == planId);

            var s = new Subscription
            {
                Start = DateTime.UtcNow,
                End = null,
                TrialEnd = DateTime.UtcNow.AddDays(trialPeriodInDays ?? plan.TrialPeriodInDays),
                TrialStart = DateTime.UtcNow,
                UserId = user.Id,
                SubscriptionPlan = plan
            };

            _dbContext.Subscriptions.Add(s);
            await _dbContext.SaveChangesAsync();

            return s;
        }

        public async Task<Subscription> UserActiveSubscriptionAsync(string userId)
        {
            return await
                _dbContext.Subscriptions
                    .Include(s => s.SubscriptionPlan)
                    .Where(s => s.User.Id == userId && s.End == null)
                    .FirstOrDefaultAsync();
        }

        public async Task<List<Subscription>> UserSubscriptionsAsync(string userId)
        {
            return await _dbContext.Subscriptions.Where(s => s.User.Id == userId).Select(s => s).ToListAsync();
        }

        public async Task<List<Subscription>> UserActiveSubscriptionsAsync(string userId)
        {
            return await _dbContext.Subscriptions.Where(s => s.User.Id == userId && s.End == null).Select(s => s).ToListAsync();
        }

        public async Task EndSubscriptionAsync(int subscriptionId)
        {
            var dbSub = await _dbContext.Subscriptions.FindAsync(subscriptionId);
            dbSub.End = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSubscriptionAsync(Subscription subscription)
        {
            _dbContext.Entry(subscription).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
