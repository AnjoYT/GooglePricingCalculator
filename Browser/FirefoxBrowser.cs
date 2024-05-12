using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooglePricingCalculator.Browser
{
    public class FirefoxBrowser : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");
            var service = FirefoxDriverService.CreateDefaultService();
            FirefoxDriver firefoxDriver = new FirefoxDriver(service, firefoxOptions);
            return firefoxDriver;
        }
    }
}
