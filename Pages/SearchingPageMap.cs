using GooglePricingCalculator.Browser;
using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class SearchingPageMap
    {
        public IReadOnlyCollection<IWebElement> LinkItems => BrowserFactory.Browser.FindElements(By.CssSelector(".gs-title b"));
    }
}
