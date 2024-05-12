using GooglePricingCalculator.Enums;
using GooglePricingCalculator.Util;
using NUnit.Framework;

namespace GooglePricingCalculator.Utils
{
    public class TestSettings
    {
        public static BrowserType Browser => EnumUtil.ParseEnum<BrowserType>(TestContext.Parameters.Get("Browser").ToString());
        public static string ScreenshotPath => TestContext.Parameters.Get("ScreenShotPath").ToString();
        public static TimeSpan WebDriverExplicitTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("ExplicitTimeOut").ToString()));
        public static TimeSpan WebDriverImplicitTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("ImplicitTimeOut").ToString()));
        public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();
    }
}
