using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GooglePricingCalculator.Browser;
using SeleniumExtras.WaitHelpers;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace GooglePricingCalculator.Utils
{
    public static class Waiters
    {
        public static string WaitForUrlToChange(this string url)
        {
            try
            {
                BrowserFactory.Browser.Wait().Until(driver => !driver.Url.Equals(url));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Timeout exceeded. URL did not change.");
            }
            return BrowserFactory.Browser.GetUrl();
        }
        //public static void WaitToBeVisable(this IReadOnlyCollection<IWebElement> locator) => BrowserFactory.Browser.Wait().Until(ExpectedConditions.ElementIsVisible(locator));
        public static void WaitToBeClickable(this By locator) => BrowserFactory.Browser.Wait().Until(ExpectedConditions.ElementToBeClickable(locator));

        public static void WaitForPageLoad() => BrowserFactory.Browser.Wait().Until(condition => ((IJavaScriptExecutor)condition).ExecuteScript("return document.readyState").Equals("complete"));
    }
}
