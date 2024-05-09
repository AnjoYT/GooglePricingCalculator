using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class ValidateCalculation
    {
        private readonly IWebDriver driver;
        public ValidateCalculation(IWebDriver driver)
        {
            this.driver = driver;
        }
        protected CalculationPageMap Map => new CalculationPageMap(driver);

        public void ValidateCost()
        {
            Assert.True(CheckValue(), "Cost is not calculated");
        }
        private bool CheckValue()
        {
            int.TryParse(this.Map.Cost.Text.Replace("$", "").Replace(",", "").Replace(".", ""), out int value);
            if (value > 0)
            {
                return true;
            }
            return false;

        }
    }
}
