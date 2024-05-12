using GooglePricingCalculator.Browser;
using GooglePricingCalculator.Utils;
using NUnit.Framework;

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
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                BrowserFactory.Browser.CreateScreeenshot(TestContext.CurrentContext.Test.Name);
            }
            BrowserFactory.Browser.Clear();
        }
    }
}
