using GooglePricingCalculator.Driver;
using GooglePricingCalculator.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GooglePricingCalculator.Browser
{
    public static class BrowserFactory
    {
        private static ThreadLocal<Browser> browser;

        static BrowserFactory()
        {
            browser = new ThreadLocal<Browser>(() => new Browser(DriverSingleton.getDriver(TestSettings.Browser)));
        }
        public static Browser Browser
        {
            get
            {
               if(browser.Value == null)
                {
                    new Browser(DriverSingleton.getDriver(TestSettings.Browser));
                }
                return browser.Value;
            }
        }
    }
}
