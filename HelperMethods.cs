using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator
{
    public static class HelperMethods
    {
        public static void SelectElement(this IReadOnlyCollection<IWebElement> locator, string text)
        {
            IWebElement element = locator.FirstOrDefault(x => x.Text.ToLower().Contains(text.ToLower()));
            if (element != null)
            {
                element.Click();
            }
            else
            {
                throw new ArgumentException($"There is no element named {text}", nameof(text));
            }
        }
        public static void SelectElement(this IReadOnlyCollection<IWebElement> locator, By by, string text)
        {
            IWebElement element = locator.FirstOrDefault(x => x.Text.ToLower().Contains(text.ToLower()));
            if (element != null)
            {
                element.FindElement(by).Click();
            }
            else
            {
                throw new ArgumentException($"There is no element named {text}", nameof(text));
            }
        }
        public static void EnterNumber(this IWebElement locator, string number)
        {
            if (!int.TryParse(number, out int result))
            {
                throw new ArgumentException($"{number} is not a number", nameof(number));
            }
            IWebElement element = locator;
            element.Clear();
            element.SendKeys(number);
        }
        public static void ScrollIntoView(this IWebDriver driver, IWebElement locator)
        {
            Actions actions = new Actions(driver);
            actions.ScrollToElement(locator).Perform();
        }
        public static string WaitForUrlToChange(this string url, IWebDriver driver, WebDriverWait wait)
        {
            try
            {
                wait.Until(driver => !driver.Url.Equals(url));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Timeout exceeded. URL did not change.");
            }
            return driver.Url;
        }
    }
}
