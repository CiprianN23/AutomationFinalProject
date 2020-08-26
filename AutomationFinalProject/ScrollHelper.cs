using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace AutomationFinalProject
{
    public static class ScrollHelper
    {
        private static void ScrollTo(IWebDriver driver, int xPosition = 0, int yPosition = 0)
        {
            driver.ExecuteJavaScript($"window.scrollTo({xPosition}, {yPosition})");
        }

        public static void ScrollToView(IWebDriver driver, IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo(driver, 0, element.Location.Y - 100);
            }
        }
    }
}
