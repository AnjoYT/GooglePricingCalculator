using GooglePricingCalculator.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GooglePricingCalculator.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver driver;

        public static IWebDriver getDriver(BrowserType browser)
        {
                switch (browser)
                {
                    case BrowserType.Chrome:
                        {
                            driver = new ChromeDriver();
                            break;
                        }
                    case BrowserType.Firefox:
                        {
                            driver = new FirefoxDriver();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentOutOfRangeException(nameof(browser));
                        }
            }
            return driver;
        }
    }
}
