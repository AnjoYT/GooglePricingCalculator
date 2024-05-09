using GooglePricingCalculator.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Test
{
    public class CommonCondition
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        public CommonCondition()
        {
            this.driver = DriverSingleton.getDriver();
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void StopBrowser()
        {
            DriverSingleton.Dispose();
        }
    }
}
