using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator.Pages
{
    public class EstimateSummaryPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public EstimateSummaryPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public EstimateSummaryMap Map => new EstimateSummaryMap(driver);
        public EstimateSummaryValidate Validate() => new EstimateSummaryValidate(this.driver);

        public void TabLoading()
        {
            List<string> windowHandles = new List<string>(driver.WindowHandles);
            wait.Until(wd => wd.WindowHandles.Count == 2);
            driver.SwitchTo().Window(windowHandles[1]);
        }

    }
}
