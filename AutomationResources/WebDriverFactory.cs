using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationResources
{
    public class WebDriverFactory
    {
        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();

                default:
                    throw new ArgumentOutOfRangeException("No souch Browser exists in this collection");
            }
        }

        private IWebDriver GetChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            //To disable pop up "Disable developer mode extensions" and automation info-bar message .
            chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            chromeOptions.AddExcludedArgument("enable-automation");

            return new ChromeDriver("Drivers/", chromeOptions);
        }
    }
}
