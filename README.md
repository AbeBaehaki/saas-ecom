SAAS Ecommerce
==============

Robust subscription support for ASP.NET MVC 5 apps using [Stripe](https://stripe.com), including out-of-the-box pricing pages, payment pages, and  subscription management for your customers. Also makes it easy to manage logic related to new subscriptions, cancellations, payment failures, and streamlines hooking up notifications, etc.

You can see [more information about the project in this blog post](http://www.pedroalonso.net/blog/2014/04/28/saas-ecom-open-source-for-net-mvc-5-stripe/)

![Web](http://www.pedroalonso.net/images/posts/2014/04/01-SAAS-Ecom.png)

See an example of [SAAS Ecom Demo](http://saas-ecom.azurewebsites.net/). It's connected to Stripe test gateway, so you can add one of their [test credit cards](https://stripe.com/docs/testing).

* **Test Card Number:** 4242 4242 4242 4242 
* **Expiry date:** Any future date.
* **CVC:** 3 digits

## Features

*  **Integrated with Stripe:** Use stripe as your gateway. This billing application is nicely integrated.
*  **Trials supported:** You have the option to let your customers to try your application first. Don't even ask them for a credit card to register.
*  **Invoicing:** The invoices are created automatically, and Stripe will try to get them paid.
*  **Customers dashboard:** Dashboard area for your customers, where they can manage their subscription / password / credit card.
*  **Only SSL needed:** Your customers' credit card number don't hit your server (stripe.js). You only need SSL to deploy this app.

## Installation

1. Register in Stripe.com, and get your API Keys.
2. Add your API Keys to Web.config.
3. Add your email server details to Web.config. Recommended to use [Mandrill](http://www.mandrill.com) / [Sendgrid](http://www.sendgrid.com).
4. Configure [Stripe Webhooks](https://manage.stripe.com/account/webhooks), the URL will be something like: http://yourdomain.com/StripeWebhooks
5. Create your database, and add the connection string to Web.config. By default is using SQL Compact.

**Contributions and feedback is very welcome.**

## Libraries used

* Entity Framework
* Json.NET
* jQuery
* jQuery Validation
* jQuery Unobtrusive Validation
* ASP.NET MVC 5.1
* ASP.NET Razor
* ASP.NET Identity Owin
* ASP.NET Identity Entity Framework
* Owin
* Twitter Bootstrap Less
* Font Awesome
* Postal
* Stripe.net

