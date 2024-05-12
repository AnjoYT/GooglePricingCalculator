﻿using GooglePricingCalculator.Browser;
using GooglePricingCalculator.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooglePricingCalculator.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            BrowserFactory.Browser.GoToUrl(TestSettings.ApplicationUrl);
            BrowserFactory.Browser.Maximize();
            Waiters.WaitForPageLoad();
        }
        [SetUp]
        public void SetUp() 
        {
        
        }

        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                BrowserFactory.Browser.CreateScreeenshot(TestContext.CurrentContext.TestDirectory);
            }
            BrowserFactory.Browser.Clear();
        }
    }
}