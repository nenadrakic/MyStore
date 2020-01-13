using System;
using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationResources.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        By BlouseElement = By.XPath("//*[@title='Blouse']");

        public bool Contains(Item itemToCheckFor)
        {
            switch (itemToCheckFor)
            {
                case Item.Blouse:
                    return wait.Until(ExpectedConditions.ElementExists(BlouseElement)).Displayed;
                default:
                    throw new ArgumentOutOfRangeException("No souch item exists in this collection");
            }

        }
    }
}