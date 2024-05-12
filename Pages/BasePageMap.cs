using GooglePricingCalculator.Browser;
using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class BasePageMap
    {
        public IWebElement SearchInput => BrowserFactory.Browser.FindElement(By.ClassName("mb2a7b"));
        public IWebElement Cookies => BrowserFactory.Browser.FindElement(By.ClassName("glue-cookie-notification-bar__accept"));
    }
}
