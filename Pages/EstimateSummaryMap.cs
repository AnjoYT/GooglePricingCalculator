using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class EstimateSummaryMap
    {
        private readonly IWebDriver driver;
        public EstimateSummaryMap(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement Instances => this.driver.FindElement(By.XPath("//span[text() ='Number of Instances']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement OperatingSystem => this.driver.FindElement(By.XPath("//span[text() ='Operating System / Software']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement ProvisioningModel => this.driver.FindElement(By.XPath("//span[text() ='Provisioning Model']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement MachineType => this.driver.FindElement(By.XPath("//span[text() ='Machine type']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement GpuType => this.driver.FindElement(By.XPath("//span[text() ='GPU Model']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement NumberOfGpu => this.driver.FindElement(By.XPath("//span[text() ='Number of GPUs']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement SsdSize => this.driver.FindElement(By.XPath("//span[text() ='Local SSD']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement Datacenter => this.driver.FindElement(By.XPath("//span[text() ='Region']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement CommittedUsage => this.driver.FindElement(By.XPath("//span[text() ='Committed use discount options']//following-sibling::span[@class='Kfvdz']"));


    }
}
