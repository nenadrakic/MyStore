using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationResources.Pages
{
    public class HomePageObjectRepository : BasePageObjectRepository
    {

        public IWebElement SearchOnTop => Driver.FindElement(By.Id("search_query_top"));
        public IWebElement SearchSubmit => Driver.FindElement(By.Name("submit_search"));
        public IWebElement SignInLink => wait.Until(ExpectedConditions.ElementExists(By.LinkText("Sign in")));

        public HomePageObjectRepository(IWebDriver driver) : base(driver)
        {
        }
    }
}
