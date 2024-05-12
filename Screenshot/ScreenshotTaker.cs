using OpenQA.Selenium;
using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GooglePricingCalculator.Utils;

namespace GooglePricingCalculator.Screenshot
{
    public class ScreenshotTaker
    {
        public static void CreateSceenshot(IWebDriver driver, string testName)
        {
            if(!Directory.Exists(TestSettings.ScreenshotPath))
            {
                Directory.CreateDirectory(TestSettings.ScreenshotPath);
            }

            string fileName = $"{testName} {DateTime.Now:hh,mm,dd,MM}.{ImageFormat.Png.ToString()}";

            string ScreenshotPath = Path.Combine(TestSettings.ScreenshotPath, fileName);
            using (Image screenshot = Image.FromStream(new MemoryStream(((ITakesScreenshot)driver).GetScreenshot().AsByteArray)))
            {
                screenshot.Save(ScreenshotPath);
            }
        }
    }
}
