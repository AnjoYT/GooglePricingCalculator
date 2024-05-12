using GooglePricingCalculator.Browser;
using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class EstimateSummaryMap
    {
        public IWebElement Instances => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Number of Instances']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement OperatingSystem => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Operating System / Software']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement ProvisioningModel => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Provisioning Model']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement MachineType => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Machine type']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement GpuType => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='GPU Model']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement NumberOfGpu => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Number of GPUs']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement SsdSize => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Local SSD']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement Datacenter => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Region']//following-sibling::span[@class='Kfvdz']"));
        public IWebElement CommittedUsage => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Committed use discount options']//following-sibling::span[@class='Kfvdz']"));


    }
}
