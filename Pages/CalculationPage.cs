using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public CalculationPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public CalculationPageMap Map => new CalculationPageMap(driver);
        public void AddToEstimate(string text)
        {
            this.Map.EstimateButton.Click();
            this.wait.Until(ExpectedConditions.ElementToBeClickable(this.Map.ProductCard));
            this.driver.FindElements(this.Map.ProductCard).SelectElement(text);
        }
        public void AddNumberOfInstances(string number)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(this.Map.NumberOfInstances));
            Thread.Sleep(300);
            //this.Map.NumberOfInstances.EnterNumber(driver, number);
            IWebElement element = this.driver.FindElement(this.Map.NumberOfInstances);
            element.Clear();
            element.SendKeys(number);
        }
    }
}
