using GooglePricingCalculator.Browser;
using GooglePricingCalculator.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Pages
{
    public class BasePage
    {
        public BasePageMap Map => new BasePageMap();

        public void Search(string text)
        { 
            this.Map.SearchInput.SendKeys(text);
            this.Map.SearchInput.SendKeys(Keys.Enter);
            Waiters.WaitForPageLoad();
        }
        public void HandleCookies()
        {
            this.Map.Cookies.Click();
        }
    }
}
