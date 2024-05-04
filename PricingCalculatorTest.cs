using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator
{
    public class PricingCalculatorTest
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PricingCalculatorTest()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }
        [Fact]
        public void CreatingComputingMachine()
        {
        }
    }
}