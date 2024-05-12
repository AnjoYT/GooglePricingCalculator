using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooglePricingCalculator.Browser
{
    public class ChromeBrowser : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            ChromeDriver chromeDriver = new ChromeDriver(service,chromeOptions);
            return chromeDriver;
        }
    }
}
