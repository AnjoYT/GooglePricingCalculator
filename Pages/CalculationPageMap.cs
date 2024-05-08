using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPageMap
    {
        private readonly IWebDriver driver;
        public CalculationPageMap(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement EstimateButton => this.driver.FindElement(By.XPath("//button[contains(@class, 'UywwFc')]"));
        public By ProductCard => By.XPath("//div[@class = 'aHij0b-aGsRMb']//ancestor::h2");
        public IWebElement NumberOfInstances => this.driver.FindElement(By.ClassName("qdOxv-fmcmS-wGMbrd"));


    }
}
