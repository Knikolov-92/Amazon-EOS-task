using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.Home
{
    public partial class HomePage : BasePage
    {
        public const string HOME_PAGE_URL = "https://www.amazon.co.uk/";

        //-------------------------locators----------------------------------------------------------------
        public static readonly By ACCEPT_COOKIES_BUTTON = By.Id("sp-cc-accept");
        public static readonly By SEARCH_CATEGORY_DROPDOWN = By.Id("searchDropdownBox");
        public static readonly By SEARCH_FIELD = By.Id("twotabsearchtextbox");
        public static readonly By SEARCH_GO_BUTTON = By.XPath("//*[@id='nav-search-submit-text']/*[@class='nav-input']");
        public static readonly By NAV_BASKET_BUTTON = By.XPath("//a[@id='nav-cart']");        
    }
}
