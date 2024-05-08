using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class BasePageMap
    {
        public readonly IWebDriver driver;
        public BasePageMap(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement SearchInput => this.driver.FindElement(By.ClassName("mb2a7b"));
        public IWebElement Cookies => this.driver.FindElement(By.ClassName("glue-cookie-notification-bar__accept"));
    }
}
