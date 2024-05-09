﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private string url;
        public CalculationPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            this.url = this.driver.Url;
        }
        protected CalculationPageMap Map => new CalculationPageMap(this.driver);
        public ValidateCalculation Validate() => new ValidateCalculation(this.driver);

        public void AddToEstimate(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.Map.EstimateButton.Click();
            this.wait.Until(ExpectedConditions.ElementToBeClickable(this.Map.ProductCard));
            this.driver.FindElements(this.Map.ProductCard).SelectElement(text);
        }
        public void AddNumberOfInstances(string number)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.Map.NumberOfInstances.EnterNumber(number);
        }
        public void PickOS(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.Map.OperatingSystem.Click();
            this.Map.OperationSystemOptions.SelectElement(text);
        }
        public void PickMachineFamily(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.MachineFamily);
            this.Map.MachineFamily.Click();
            this.Map.MachineFamilyOptions.SelectElement(text);
        }
        public void PickSeries(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.Series);
            this.Map.Series.Click();
            this.Map.SeriesOptions.SelectElement(text);
        }
        public void PickMachineType(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.MachineType);
            this.Map.MachineType.Click();
            this.Map.MachineTypeOptions.SelectElement(text);
        }

        public void PickGPUModel(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.Map.AddGPUButton.Click();
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.GPUModel);
            this.Map.GPUModel.Click();
            this.Map.GPUModelOptions.SelectElement(text);
        }

        public void PickNumberOfGPU(string number)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.NumberOfGPU);
            this.Map.NumberOfGPU.Click();
            this.Map.NumberOfGPUOptions.SelectElement(number);

        }
        public void PickSsdSize(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.SizeOfSsd);
            this.Map.SizeOfSsd.Click();
            this.Map.SizeOfSsdOptions.SelectElement(text);
        }

        public void PickRegion(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.Region);
            this.Map.Region.Click();
            this.Map.RegionOptions.SelectElement(this.Map.RegionOptionLi, text);
        }

        public void PickDiscountOption(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.DiscountElement);
            this.driver.SelectElementByInputId(this.Map.DiscountAncestor, text);
        }
        public void PickProvisioningModel(string text)
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.driver.ScrollIntoView(this.Map.ProvisioningElement);
            this.driver.SelectElementByInputId(this.Map.ProvisioningAncestor, text);
        }

        public void Share()
        {
            url = this.url.WaitForUrlToChange(this.driver, this.wait);
            this.Map.ShareButton.Click();
            this.Map.EstimateLink.Click();
        }
    }
}
