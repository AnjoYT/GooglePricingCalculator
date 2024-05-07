using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Pages
{
    public class SearchingPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public SearchingPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        private SearchingPageMap Map => new SearchingPageMap(driver);
        public void ClickSearch(string text)
        {
            this.Map.LinkItems.SelectElement(text);
        }
    }
}
