using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.Product
{
    public partial class ProductPage : BasePage
    {
        public static readonly By BOOK_VERSION_PAPERBACK = By.XPath
            ("//*[@class='a-unordered-list a-nostyle a-button-list a-horizontal']//span [@class='a-button-inner']//span[normalize-space(text())='Paperback']");

        public static readonly By BOOK_TITLE = By.XPath("//*[@id='title']//span [@id='productTitle']");
        public static readonly By BOOK_SUBTITLE = By.XPath("//*[@id='title']//span [@id='productSubtitle']");
        public static readonly By BOOK_PRICE = By.XPath
            ("//*[@id='buyNewSection']//span [@class='a-size-medium a-color-price offer-price a-text-normal']");

        public static readonly By ADD_TO_CART_BUTTON = By.XPath("//input [@id='add-to-cart-button']");
        
    }
}
