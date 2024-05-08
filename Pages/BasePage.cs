using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Pages
{
    public class BasePage
    {
        private readonly string url = "https://cloud.google.com/?hl=en";
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public BasePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public BasePageMap Map => new BasePageMap(driver);

        public void Navigate()
        {
            driver.Navigate().GoToUrl(this.url);
        }
        public void Search(string text)
        {
            this.Map.SearchInput.SendKeys(text);
            this.Map.SearchInput.SendKeys(Keys.Enter);
        }
        public void HandleCookies()
        {
            this.Map.Cookies.Click();
        }
    }
}
