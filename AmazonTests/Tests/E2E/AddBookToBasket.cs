using AmazonTests.Pages.Home;
using AmazonTests.Pages.Product;
using AmazonTests.Pages.SearchResult;
using NUnit.Framework;
using System;
using System.Threading;

namespace AmazonTests.Tests.E2E
{
    [TestFixture]
    public class AddBookToBasket : BaseTest
    {
        private HomePage _homePage;
        private SearchResultPage _searchResultPage;
        private ProductPage _productPage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToHomePage()
        {
            InitializeBrowser();
            _homePage = new HomePage(Driver);
            _searchResultPage = new SearchResultPage(Driver);
            _productPage = new ProductPage(Driver);

            _homePage.Open();
            _homePage.AssertHomePageisLoaded();
            _homePage.AcceptCookies();                        
        }

        [TestCase("Harry Potter and the Cursed Child 1 & 2",
                  "Harry Potter and the Cursed Child - Parts One and Two: The Official Playscript of the Original West End Production",
                  "Paperback" )]
        public void BasketIsUpdatedCorrectly_When_aBookIsAdded(string bookTitleSearch, string expectedBookTitle, string expectedBookVersion)
        {
            string expectedBookPrice;

            _homePage.SearchForBook(bookTitleSearch);
            _searchResultPage.VerifyFirstResultTitle(expectedBookTitle);
            expectedBookPrice = _searchResultPage.VerifyFirstResultHasPaperbackVersion(expectedBookVersion).Trim();
            Console.WriteLine("price of search result is:" + expectedBookPrice);
            _searchResultPage.OpenFirstResultProduct();
            _productPage.SelectPaperbackVersion();
            _productPage.VerifyPaperBackVersionIsSelected(expectedBookTitle, expectedBookVersion, expectedBookPrice);


            Thread.Sleep(5000);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            CloseBrowser();
        }
    }
}
