using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationResources
{
    public class BasePageObjectRepository
    {
        protected IWebDriver Driver { get; set; }

        public WebDriverWait wait;

        public BasePageObjectRepository(IWebDriver driver)
        {
            Driver = driver;

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
    }
}
