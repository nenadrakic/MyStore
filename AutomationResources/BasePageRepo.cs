using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationResources
{
    public class BasePageRepo<TOjectRepository> where TOjectRepository : BasePageObjectRepository
    {
        protected IWebDriver Driver { get; set; }

        internal TOjectRepository ObjectRepository { get; set; }

        public BasePageRepo(IWebDriver driver, TOjectRepository repository)
        {
            Driver = driver;
            ObjectRepository = repository;
        }

        public void SwitchTabs(int tabIndex)
        {
            var windows = Driver.WindowHandles;
            Driver.SwitchTo().Window(windows[tabIndex]);
        }
    }
}
