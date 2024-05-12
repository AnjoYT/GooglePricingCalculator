using GooglePricingCalculator.Browser;
using GooglePricingCalculator.Util;
using GooglePricingCalculator.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPage
    {
        protected CalculationPageMap Map => new CalculationPageMap();
        public ValidateCalculation Validate() => new ValidateCalculation();

        public void AddToEstimate(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            this.Map.EstimateButton.Click();
            Waiters.WaitToBeClickable(this.Map.ProductCard);
            BrowserFactory.Browser.FindElements(this.Map.ProductCard).SelectElement(text);
        }
        public void AddNumberOfInstances(string number)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            this.Map.NumberOfInstances.EnterNumber(number);
        }
        public void PickOS(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            this.Map.OperatingSystem.Click();
            this.Map.OperationSystemOptions.SelectElement(text);
        }
        public void PickMachineFamily(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.MachineFamily);
            this.Map.MachineFamily.Click();
            this.Map.MachineFamilyOptions.SelectElement(text);
        }
        public void PickSeries(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.Series);
            this.Map.Series.Click();
            this.Map.SeriesOptions.SelectElement(text);
        }
        public void PickMachineType(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.MachineType);
            this.Map.MachineType.Click();
            this.Map.MachineTypeOptions.SelectElement(text);
        }

        public void PickGPUModel(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            this.Map.AddGPUButton.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.GPUModel);
            this.Map.GPUModel.Click();
            this.Map.GPUModelOptions.SelectElement(text);
        }

        public void PickNumberOfGPU(string number)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.NumberOfGPU);
            this.Map.NumberOfGPU.Click();
            this.Map.NumberOfGPUOptions.SelectElement(number);

        }
        public void PickSsdSize(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.SizeOfSsd);
            this.Map.SizeOfSsd.Click();
            this.Map.SizeOfSsdOptions.SelectElement(text);
        }

        public void PickRegion(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.Region);
            this.Map.Region.Click();
            this.Map.RegionOptions.SelectElement(this.Map.RegionOptionLi, text);
        }

        public void PickDiscountOption(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.DiscountElement);
            BrowserFactory.Browser.SelectElementByInputId(this.Map.DiscountAncestor, text);
        }
        public void PickProvisioningModel(string text)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            BrowserFactory.Browser.ScrollIntoView(this.Map.ProvisioningElement);
            BrowserFactory.Browser.SelectElementByInputId(this.Map.ProvisioningAncestor, text);
        }

        public void Share()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            this.Map.ShareButton.Click();
            this.Map.EstimateLink.Click();
        }
    }
}
