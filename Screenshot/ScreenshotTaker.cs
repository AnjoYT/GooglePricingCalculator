using GooglePricingCalculator.Utils;
using OpenQA.Selenium;
using System.Drawing;
using System.Drawing.Imaging;

namespace GooglePricingCalculator.Screenshot
{
    public class ScreenshotTaker
    {
        public static void ScreenshotCreator(IWebDriver driver, string testName)
        {
            if (!Directory.Exists(TestSettings.ScreenshotPath))
            {
                Directory.CreateDirectory(TestSettings.ScreenshotPath);
            }

            string fileName = $"{testName}_{DateTime.Now:hh-mm-dd-MM}.{ImageFormat.Png.ToString()}";

            string ScreenshotPath = Path.Combine(TestSettings.ScreenshotPath, fileName);
            using (Image screenshot = Image.FromStream(new MemoryStream(((ITakesScreenshot)driver).GetScreenshot().AsByteArray)))
            {
                screenshot.Save(ScreenshotPath);
            }
        }
    }
}
