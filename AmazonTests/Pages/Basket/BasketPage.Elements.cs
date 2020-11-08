using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.Basket
{
    public partial class BasketPage : BasePage
    {
        public static readonly By ADDED_TO_BASKET_SUBTOTAL = By.XPath
                                ("//div [@id='hlb-subcart']//span [@class='a-size-medium a-align-center huc-subtotal']");

        //public static readonly By ADDED_TO_BASKET_PRICE = By.XPath
        //                        ("//div [@id='hlb-subcart']//span [@class='a-color-price hlb-price a-inline-block a-text-bold']");

        public static readonly By ADDED_TO_BASKET_GIFT_CHECKBOX = By.XPath
                                ("//div[@id='huc-v2-order-row-mark-gift']//input [@type='checkbox']");

        public static readonly By FIRST_PRODUCT_TITLE = By.XPath
                                ("//span [@class='a-list-item']//span [@class='a-size-medium sc-product-title a-text-bold']");

        public static readonly By FIRST_PRODUCT_VERSION = By.XPath
                                ("//span [@class='a-list-item']//span [@class='a-size-small a-color-secondary sc-product-binding']");

        public static readonly By SUBTOTAL_TEXT = By.XPath("//span [@id='sc-subtotal-label-activecart']");
        public static readonly By SUBTOTAL_AMOUNT = By.XPath("//span [@id='sc-subtotal-amount-activecart']");
    }
}
