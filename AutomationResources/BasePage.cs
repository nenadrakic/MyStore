using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationResources
{
    public  class BasePage
    {
        protected IWebDriver Driver { get; set; }

        public WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        public void SwitchTabs(int tabIndex)
        {
            var windows = Driver.WindowHandles;
            Driver.SwitchTo().Window(windows[tabIndex]);
        }
    }
}
