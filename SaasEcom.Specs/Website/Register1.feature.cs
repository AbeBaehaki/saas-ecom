﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SaasEcom.Specs.Website
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register")]
    public partial class RegisterFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Register.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Register", "I can visit the website\r\nAs a user\r\nI want to register", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open homepage")]
        [NUnit.Framework.CategoryAttribute("UI")]
        public virtual void OpenHomepage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open homepage", new string[] {
                        "UI"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have the homepage open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Then("I should see \"This is a template that can be used as a startup point to build you" +
                    "r SAAS subscription website using ASP.NET MVC 5.\" on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to register")]
        [NUnit.Framework.CategoryAttribute("UI")]
        public virtual void NavigateToRegister()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to register", new string[] {
                        "UI"});
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("I have the homepage open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.When("I click on \"hero-btn\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("I see the registration form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register valid data")]
        [NUnit.Framework.CategoryAttribute("UI")]
        public virtual void RegisterValidData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register valid data", new string[] {
                        "UI"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
    testRunner.Given("I am at the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1.AddRow(new string[] {
                        "Email",
                        "test@test.com"});
            table1.AddRow(new string[] {
                        "Password",
                        "pass01"});
            table1.AddRow(new string[] {
                        "ConfirmPassword",
                        "pass01"});
            table1.AddRow(new string[] {
                        "SubscriptionPlan",
                        "Premium"});
#line 20
    testRunner.When("I fill the registration form", ((string)(null)), table1, "When ");
#line 26
    testRunner.And("I click on \"Register\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.Then("I should see \"This is a template that can be used as a startup point to build you" +
                    "r SAAS subscription website using ASP.NET MVC 5.\" on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register with invalid data")]
        [NUnit.Framework.CategoryAttribute("UI")]
        public virtual void RegisterWithInvalidData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with invalid data", new string[] {
                        "UI"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
    testRunner.Given("I am at the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
    testRunner.When("I fill the registration form with invalid data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
    testRunner.And("I click on \"Register\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
    testRunner.Then("I see validation errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion