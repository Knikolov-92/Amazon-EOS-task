using AmazonTests.Pages.Home;
using NUnit.Framework;
using System.Threading;

namespace AmazonTests.Tests.E2E
{
    [TestFixture]
    public class AddBookToBasket : BaseTest
    {
        private HomePage _homePage;


        [SetUp]
        public void OpenBrowserWindowAndNavigateToHomePage()
        {
            InitializeBrowser();
            _homePage = new HomePage(Driver);

            _homePage.Open();
            _homePage.AssertHomePageisLoaded();
            Thread.Sleep(5000);
        }

        //[TestCase("Harry Potter and the Cursed Child")]
        [Test]
        public void BasketIsUpdatedCorrectly_When_aBookisAdded()
        {

        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            CloseBrowser();
        }
    }
}
