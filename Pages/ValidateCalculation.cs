using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class ValidateCalculation
    {
        protected CalculationPageMap Map => new CalculationPageMap();

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
