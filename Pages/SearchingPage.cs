using GooglePricingCalculator.Util;
using GooglePricingCalculator.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Pages
{
    public class SearchingPage
    {
        private SearchingPageMap Map => new SearchingPageMap();
        public void ClickSearch(string text)
        {
            
            this.Map.LinkItems.SelectElement(text);
            Waiters.WaitForPageLoad();
        }
    }
}
