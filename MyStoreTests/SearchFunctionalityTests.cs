using AutomationResources;
using AutomationResources.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyStoreTests
{
    [TestClass]
    [TestCategory("SearchingFeature")]
    public class SearchFunctionalityTests : BaseTest
    {
        [TestMethod]
        [Description("Checks to make sure that if we search for browser that browser comes back")]
        [TestProperty("Author","NenadRakic")]
        public void TCID1()
        {
            string stringToSearch = "blouse";

            HomePage homepage = new HomePage(Driver);
            homepage.GoTo();
            SearchPage searchPage = homepage.Search(stringToSearch);
            Assert.IsTrue(searchPage.Contains(Item.Blouse),
                $"When searching for the string =>{stringToSearch}, " +
                $"" + $"we did not find it in the search results.");
        }
    }
}
