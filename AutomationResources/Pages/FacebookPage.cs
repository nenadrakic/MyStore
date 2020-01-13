using OpenQA.Selenium;

namespace AutomationResources.Pages
{
    public class FacebookPage : BasePage
    {
        public FacebookPage(IWebDriver driver) : base(driver)
        {               
        }
        public bool IsVisible
        {
            get
            {
                return Driver.Title.Contains(PageTitle);
            }
            internal set { }
        }

        public string PageTitle => "Selenium Framework";
    }
}
