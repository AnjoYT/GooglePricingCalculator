using OpenQA.Selenium;

namespace GooglePricingCalculator.Pages
{
    public class CalculationPageMap
    {
        private readonly IWebDriver driver;
        public CalculationPageMap(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement EstimateButton => this.driver.FindElement(By.XPath("//button[contains(@class, 'UywwFc')]"));

        public By ProductCard => By.XPath("//div[@class = 'aHij0b-aGsRMb']//ancestor::h2");

        public IWebElement NumberOfInstances => this.driver.FindElement(By.ClassName("qdOxv-fmcmS-wGMbrd"));

        public IWebElement OperatingSystem => this.driver.FindElement(By.XPath("//*[text() = 'Operating System / Software']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> OperationSystemOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Operating System / Software']//li"));

        public IWebElement MachineFamily => this.driver.FindElement(By.XPath("//*[text() = 'Machine Family']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> MachineFamilyOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Machine Family']//li"));

        public IWebElement Series => this.driver.FindElement(By.XPath("//*[text() = 'Series']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> SeriesOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Series']//li"));

        public IWebElement MachineType => this.driver.FindElement(By.XPath("//*[text() = 'Machine type']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> MachineTypeOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Machine type']//li"));

        public IWebElement AddGPUButton => this.driver.FindElement(By.XPath("//button[@aria-label='Add GPUs']"));

        public IWebElement GPUModel => this.driver.FindElement(By.XPath("//*[text()='GPU Model']//ancestor::div[@class = 'VfPpkd-TkwUic']"));
        public IReadOnlyCollection<IWebElement> GPUModelOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='GPU Model']//li"));

        public IWebElement NumberOfGPU => this.driver.FindElement(By.XPath("//*[text()='Number of GPUs']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> NumberOfGPUOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Number of GPUs']//li"));

        public IWebElement SizeOfSsd => this.driver.FindElement(By.XPath("//*[text()='Local SSD']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> SizeOfSsdOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Local SSD']//li"));

        public IWebElement Region => this.driver.FindElement(By.XPath("//*[text()='Region']//ancestor::div[contains(@class, 'VfPpkd-TkwUic')]"));
        public IReadOnlyCollection<IWebElement> RegionOptions => this.driver.FindElements(By.XPath("//ul[@aria-label='Region']//span[@jsname ='K4r5Ff']"));
        public By RegionOptionLi => By.XPath("./ancestor::li");


        public IWebElement DiscountElement => this.driver.FindElement(By.XPath("//*[text()='Committed use discount options']//ancestor::div[@class='kqQzpb YgByBe']//div[@class='c0GfYc']"));
        public IReadOnlyCollection<IWebElement> DiscountOptionsLabel => this.driver.FindElements(By.XPath("//*[text()='Committed use discount options']//ancestor::div[@class='kqQzpb YgByBe']//label"));
        public By DiscountOptions => By.XPath("//ancestor::div[@class=' e2WL2b MYT3K pV2hx oLWDHd']");
    }
}
