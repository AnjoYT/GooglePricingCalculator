using GooglePricingCalculator.Browser;
using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPageMap
    {
        public IWebElement EstimateButton => BrowserFactory.Browser.FindElement(By.XPath("//span[text() ='Add to estimate']//ancestor::button[contains(@class,'UywwFc-LgbsSe')]"));

        public By ProductCard => By.XPath("//div[@class = 'aHij0b-aGsRMb']//ancestor::h2");

        public IWebElement NumberOfInstances => BrowserFactory.Browser.FindElement(By.ClassName("qdOxv-fmcmS-wGMbrd"));

        public IWebElement OperatingSystem => BrowserFactory.Browser.FindElement(By.XPath("//*[text() = 'Operating System / Software']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> OperationSystemOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Operating System / Software']//li"));

        public IWebElement MachineFamily => BrowserFactory.Browser.FindElement(By.XPath("//*[text() = 'Machine Family']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> MachineFamilyOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Machine Family']//li"));

        public IWebElement Series => BrowserFactory.Browser.FindElement(By.XPath("//*[text() = 'Series']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> SeriesOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Series']//li"));

        public IWebElement MachineType => BrowserFactory.Browser.FindElement(By.XPath("//*[text() = 'Machine type']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> MachineTypeOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Machine type']//li"));

        public IWebElement AddGPUButton => BrowserFactory.Browser.FindElement(By.XPath("//button[@aria-label='Add GPUs']"));

        public IWebElement GPUModel => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='GPU Model']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> GPUModelOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='GPU Model']//li"));

        public IWebElement NumberOfGPU => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='Number of GPUs']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> NumberOfGPUOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Number of GPUs']//li"));

        public IWebElement SizeOfSsd => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='Local SSD']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> SizeOfSsdOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Local SSD']//li"));

        public IWebElement Region => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='Region']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> RegionOptions => BrowserFactory.Browser.FindElements(By.XPath("//ul[@aria-label='Region']//span[@jsname ='K4r5Ff']"));
        public By RegionOptionLi => By.XPath("./ancestor::li");

        public IWebElement DiscountElement => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='Committed use discount options']//ancestor::div[@class='kqQzpb YgByBe']//div[@class='c0GfYc']"));
        public string DiscountAncestor => "//ancestor::div[@class=' e2WL2b MYT3K pV2hx oLWDHd']";

        public IWebElement ProvisioningElement => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='Provisioning Model']//ancestor::div[@class='kqQzpb YgByBe']//div[@class='c0GfYc']"));
        public string ProvisioningAncestor => "//ancestor::div[@class=' e2WL2b MYT3K pV2hx oLWDHd']";

        public IWebElement Cost => BrowserFactory.Browser.FindElement(By.XPath("//div[@class='xJ0wqe']//span[@class='MyvX5d D0aEmf']"));

        public IWebElement ShareButton => BrowserFactory.Browser.FindElement(By.XPath("//*[text()='Share']//ancestor::button"));

        public IWebElement EstimateLink => BrowserFactory.Browser.FindElement(By.XPath("//a[text()='Open estimate summary']"));
    }
}
