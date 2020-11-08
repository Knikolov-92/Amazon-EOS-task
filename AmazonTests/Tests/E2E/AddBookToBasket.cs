using AmazonTests.Pages.Basket;
using AmazonTests.Pages.Home;
using AmazonTests.Pages.Product;
using AmazonTests.Pages.SearchResult;
using NUnit.Framework;


namespace AmazonTests.Tests.E2E
{
    [TestFixture]
    public class AddBookToBasket : BaseTest
    {
        private HomePage _homePage;
        private SearchResultPage _searchResultPage;
        private ProductPage _productPage;
        private BasketPage _basketPage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToHomePage()
        {
            InitializeBrowser();
            _homePage = new HomePage(Driver);
            _searchResultPage = new SearchResultPage(Driver);
            _productPage = new ProductPage(Driver);
            _basketPage = new BasketPage(Driver);

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

            //TC design:
            //1. search for a book(name)
            //2. verify first result is a book with expectedTitle
            //3. verify first result is a book that has "paperback" version available and return given price
            //4. click on first result(title)
            //5. select 'paperback' version of book
            //6. verify info of current open product is correct
            //7. add product to basket
            //8. mark product as a gift
            //9. verify product is added to basket correctly
            //10. go to basket page using the navigation bar
            //11. verify product(book) info is updated correctly in the basket


            _homePage.SearchForBook(bookTitleSearch);    
            
            _searchResultPage.VerifyFirstResultTitle(expectedBookTitle);            
            expectedBookPrice = _searchResultPage.VerifyFirstResultHasPaperbackVersion(expectedBookVersion).Trim();   
            
            _searchResultPage.OpenFirstResultProduct();            
            _productPage.SelectPaperbackVersion();

            _productPage.VerifyPaperbackVersionIsSelected(expectedBookTitle, expectedBookVersion, expectedBookPrice);
            
            _productPage.AddProductToBasket();
            _basketPage.MarkAddedProductAsGift();

            _basketPage.VerifyProductIsAddedToBasketCorrectly("Basket subtotal (1 item): ", expectedBookPrice); 
            
            _homePage.NavigateToBasketPage();
            
            _basketPage.VerifySubTotalInformation(expectedBookTitle, expectedBookVersion, expectedBookPrice);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            CloseBrowser();
        }
    }
}
