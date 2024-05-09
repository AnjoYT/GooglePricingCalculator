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
            calculationPage.PickProvisioningModel("Regular");
            calculationPage.PickMachineFamily("General Purpose");
            calculationPage.PickSeries("N1");
            calculationPage.PickMachineType("n1-standard-8");
            calculationPage.PickGPUModel("NVIDIA Tesla V100");
            calculationPage.PickNumberOfGPU("1");
            calculationPage.PickSsdSize("2x375 Gb");
            calculationPage.PickRegion("europe-west4");
            calculationPage.PickDiscountOption("1 Year");
            calculationPage.Validate().ValidateCost();
            calculationPage.Share();
            EstimateSummaryPage estimateSummaryPage = new EstimateSummaryPage(Driver, Wait);
            estimateSummaryPage.TabLoading();
            estimateSummaryPage.Validate().ValidateNumberOfInstances("4");
            estimateSummaryPage.Validate().ValidateOperatingSystem("Free: Debian, CentOS, CoreOS, Ubuntu or BYOL (Bring Your Own License)");
            estimateSummaryPage.Validate().ValidateProvisioningModel("Regular");
            estimateSummaryPage.Validate().ValidateMachineType("n1-standard-8, vCPUs: 8, RAM: 30 GB");
            estimateSummaryPage.Validate().ValidateGpuType("NVIDIA Tesla V100");
            estimateSummaryPage.Validate().ValidateNumberOfGpu("1");
            estimateSummaryPage.Validate().ValidateSsdSize("2x375 GB");
            estimateSummaryPage.Validate().ValidateDatacenter("Netherlands (europe-west4)");
            estimateSummaryPage.Validate().ValidateCommittedUsage("1 year");
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
            calculationPage.Share();
            EstimateSummaryPage estimateSummaryPage = new EstimateSummaryPage(Driver, Wait);
            estimateSummaryPage.TabLoading();
        }

        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}