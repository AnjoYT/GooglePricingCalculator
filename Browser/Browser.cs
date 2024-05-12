using GooglePricingCalculator.Screenshot;
using GooglePricingCalculator.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace GooglePricingCalculator.Browser
{
    public class Browser
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public Browser(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Timeouts().ImplicitWait = TestSettings.WebDriverImplicitTimeOut;
        }
        public void Clear()
        {
            try
            {
                this.driver.Close();
                this.driver.Quit();
            }
            catch (Exception ex)
            {
                //logger
            }
        }
        public string GetUrl() 
        {
            return this.driver.Url;
        }
        public void GoToUrl(string url)
        {
            try
            {
                this.driver.Navigate().GoToUrl(url);
            }
            catch (Exception ex)
            {
                //logger
            }
        }
        public void Maximize()
        {
            this.driver.Manage().Window.Maximize();
        }
        public void CreateScreeenshot(string testName)
        {
            try
            {
                ScreenshotTaker.CreateSceenshot(this.driver, testName);
            }
            catch (Exception ex)
            {
                //logger
            }
        }
        public WebDriverWait Wait() => new WebDriverWait(this.driver, TestSettings.WebDriverExplicitTimeOut); 
        public IWebElement FindElement(By locator)
        {
            return this.driver.FindElement(locator);
        }

        public void SelectElementByInputId( string ancestor, string text)
        {
            text = text.Replace(" ", "-");
            text = text.ToLower();

            By locator = By.XPath($"//input[@id='{text}']{ancestor}");
            IWebElement RadioButton = driver.FindElement(locator);
            RadioButton.Click();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return this.driver.FindElements(by);
        }
        public void ScrollIntoView(IWebElement locator)
        {
            Actions actions = new Actions(driver);
            actions.ScrollToElement(locator).Perform();
        }
        public void TabLoading()
        {
            List<string> windowHandles = new List<string>(driver.WindowHandles);
            Wait().Until(wd => wd.WindowHandles.Count == 2);
            driver.SwitchTo().Window(windowHandles[1]);
        }
    }
}
