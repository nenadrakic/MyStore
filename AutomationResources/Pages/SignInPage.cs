using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationResources.Pages
{
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FacebookLink => wait.Until(ExpectedConditions.ElementExists(By.ClassName("facebook")));

        public bool IsVisible
        {
            get
            {
                return Driver.Title.Contains(PageTitle);
            }
            internal set { }
        }

        public string PageTitle => "Login - My Store";

        public FacebookPage goToFacebookPage()
        {
            FacebookLink.Click();
            return new FacebookPage(Driver);
        }
    }
}
