using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly string url = "https://cloud.google.com/products/calculator?hl=en";
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
            wait.Until(driver => !driver.Url.Equals(url));
            this.Map.NumberOfInstances.EnterNumber(number);
        }
    }
}
