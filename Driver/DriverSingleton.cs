using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GooglePricingCalculator.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver driver;
        public DriverSingleton() { }

        public static IWebDriver getDriver()
        {
            if (driver == null)
            {
                switch (Environment.GetEnvironmentVariable("browser"))
                {
                    case "firefox":
                        {
                            driver = new FirefoxDriver();
                            break;
                        }
                    default:
                        {
                            driver = new ChromeDriver();
                            break;
                        }
                }
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void Dispose()
        {
            driver.Close();
            driver.Quit();
            driver = null;
        }
    }
}
