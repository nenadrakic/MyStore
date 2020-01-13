using OpenQA.Selenium;

namespace AutomationResources.Pages
{
    public class HomePage : BasePageRepo<HomePageObjectRepository>
    {
        public HomePage(IWebDriver driver) : base(driver, new HomePageObjectRepository(driver))
        {
        }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public SearchPage Search(string itemToSearchFor)
        {
            ObjectRepository.SearchOnTop.SendKeys(itemToSearchFor);
            ObjectRepository.SearchSubmit.Click();
            return new SearchPage(Driver);
        }

        public SignInPage SignIn()
        {
            ObjectRepository.SignInLink.Click();
            return new SignInPage(Driver);
        }
    }
}