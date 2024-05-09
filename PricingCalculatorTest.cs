using GooglePricingCalculator.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

namespace GooglePricingCalculator
{
    public class PricingCalculatorTest : IDisposable
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PricingCalculatorTest()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
        }
        [Fact]
        public void CreatingComputingMachine()
        {
            BasePage basePage = new BasePage(Driver, Wait);
            basePage.Navigate();
            basePage.HandleCookies();
            basePage.Search("Google Cloud Pricing Calculator");
            SearchingPage searchingPage = new SearchingPage(Driver, Wait);
            searchingPage.ClickSearch("Google Cloud Pricing Calculator");
            CalculationPage calculationPage = new CalculationPage(Driver, Wait);
            calculationPage.AddToEstimate("Compute Engine");
            calculationPage.AddNumberOfInstances("4");
            calculationPage.PickOS("Debian");
            calculationPage.PickMachineFamily("General Purpose");
            calculationPage.PickSeries("N1");
            calculationPage.PickMachineType("n1-standard-8");
            calculationPage.PickGPUModel("NVIDIA Tesla V100");
            calculationPage.PickNumberOfGPU("1");
            calculationPage.PickSsdSize("2x375 Gb");
            calculationPage.PickRegion("europe-west4");
            calculationPage.PickDiscountOption("1 Year");
        }

        [Fact]
        public void ButtonTesting()
        {
            BasePage basePage = new BasePage(Driver, Wait);
            basePage.Navigate();
            basePage.HandleCookies();
            basePage.Search("Google Cloud Pricing Calculator");
            SearchingPage searchingPage = new SearchingPage(Driver, Wait);
            searchingPage.ClickSearch("Google Cloud Pricing Calculator");
            CalculationPage calculationPage = new CalculationPage(Driver, Wait);
            calculationPage.AddToEstimate("Compute Engine");
            calculationPage.PickDiscountOption("1 Year");
        }

        public void Dispose()
        {
            //Driver.Dispose();
        }
    }
}