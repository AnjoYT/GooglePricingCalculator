using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class SearchingPageMap
    {
        private readonly IWebDriver driver;
        public SearchingPageMap(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IReadOnlyCollection<IWebElement> LinkItems => driver.FindElements(By.CssSelector(".gs-title b"));
    }
}
