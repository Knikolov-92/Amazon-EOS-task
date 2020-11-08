using AmazonTests.Pages.Base;
using OpenQA.Selenium;


namespace AmazonTests.Pages.Product
{
    public partial class ProductPage : BasePage
    {
        public ProductPage(IWebDriver driver) : base(driver)
        {
        }

        public void SelectPaperbackVersion()
        {
            ClickOn(BOOK_VERSION_PAPERBACK);
            WaitUntilPageIsLoaded();
        }

        public void AddProductToBasket()
        {
            ClickOn(ADD_TO_CART_BUTTON);
            WaitUntilPageIsLoaded();
        }
    }
}
