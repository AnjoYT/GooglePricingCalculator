using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Pages
{
    public class EstimateSummaryPage
    {
        public EstimateSummaryMap Map => new EstimateSummaryMap();
        public EstimateSummaryValidate Validate() => new EstimateSummaryValidate();
    }
}
