using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class EstimateSummaryValidate
    {
        private readonly IWebDriver driver;
        public EstimateSummaryValidate(IWebDriver driver)
        {
            this.driver = driver;
        }
        protected EstimateSummaryMap Map => new EstimateSummaryMap(driver);

        public void ValidateNumberOfInstances(string number)
        {
            Assert.Equal(int.Parse(this.Map.Instances.Text), int.Parse(number));
        }
        public void ValidateOperatingSystem(string text)
        {
            Assert.Contains(this.Map.OperatingSystem.Text, text);
        }
        public void ValidateProvisioningModel(string text)
        {
            Assert.Contains(this.Map.ProvisioningModel.Text, text);
        }
        public void ValidateMachineType(string text)
        {
            Assert.Equal(this.Map.MachineType.Text, text);
        }
        public void ValidateGpuType(string text)
        {
            Assert.Equal(this.Map.GpuType.Text, text);
        }
        public void ValidateNumberOfGpu(string number)
        {
            Assert.Equal(int.Parse(this.Map.NumberOfGpu.Text), int.Parse(number));
        }
        public void ValidateSsdSize(string text)
        {
            Assert.Equal(this.Map.SsdSize.Text, text);
        }
        public void ValidateDatacenter(string text)
        {
            Assert.Contains(this.Map.Datacenter.Text, text);
        }
        public void ValidateCommittedUsage(string text)
        {
            Assert.Equal(this.Map.CommittedUsage.Text, text);
        }
    }
}
