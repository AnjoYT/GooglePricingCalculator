﻿using OpenQA.Selenium;

namespace GooglePricingCalculator
{
    public static class HelperMethods
    {
        public static void SelectElement(this IReadOnlyCollection<IWebElement> locator, string text)
        {
            IWebElement element = locator.FirstOrDefault(x => x.Text.ToLower().Contains(text.ToLower()));
            if (element != null)
            {
                element.Click();
            }
            else
            {
                throw new ArgumentException($"There is no element named {text}", nameof(text));
            }
        }
        public static void EnterNumber(this By by, IWebDriver driver, string number)
        {
            if (!int.TryParse(number, out int result))
            {
                throw new ArgumentException($"{number} is not a number", nameof(number));
            }
            IWebElement element = driver.FindElement(by);
            element.SendKeys(Keys.Clear);
            element.SendKeys(number);
        }
    }
}