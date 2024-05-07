using GooglePricingCalculator.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace GooglePricingCalculator
{
    public class PricingCalculatorTest : IDisposable
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PricingCalculatorTest()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
        }
        [Fact]
        public void CreatingComputingMachine()
        {
            BasePage basePage = new BasePage(Driver, Wait);
            basePage.Navigate();
            basePage.Search("Google Cloud Pricing Calculator");
            SearchingPage searchingPage = new SearchingPage(Driver, Wait);
            searchingPage.ClickSearch("Google Cloud Pricing Calculator");
            CalculationPage calculationPage = new CalculationPage(Driver, Wait);
            calculationPage.AddToEstimate("Compute Engine");
            calculationPage.AddNumberOfInstances("4");
        }

        public void Dispose()
        {
            //Driver.Dispose();
        }
    }
}