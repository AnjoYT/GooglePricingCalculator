using GooglePricingCalculator.Browser;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

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
        public static void WaitToBeClickable(this By locator) => BrowserFactory.Browser.Wait().Until(ExpectedConditions.ElementToBeClickable(locator));

        public static void WaitForPageLoad() => BrowserFactory.Browser.Wait().Until(condition => ((IJavaScriptExecutor)condition).ExecuteScript("return document.readyState").Equals("complete"));
    }
}
