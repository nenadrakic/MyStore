using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MyStoreTests
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        public static TestContext BingTestContext { get; set; }

        public TestContext TestContext { get; set; }

 
        [TestInitialize]
        public void SetupForEverySingleTestMethod()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);

            BingTestContext = TestContext;
        }

        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            var testName = TestContext.TestName;

            if (BingTestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile("ScreenShots\\"+testName+".jpg", ScreenshotImageFormat.Jpeg);
            }

            Driver.Close();
            Driver.Quit();
        }
    }
}