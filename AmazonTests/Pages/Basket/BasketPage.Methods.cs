using AmazonTests.Pages.Base;
using OpenQA.Selenium;


namespace AmazonTests.Pages.Basket
{
    public partial class BasketPage : BasePage
    {
        public BasketPage(IWebDriver driver) : base(driver)
        {
        }

        public void MarkAddedProductAsGift()
        {
            ClickOn(ADDED_TO_BASKET_GIFT_CHECKBOX);
        }
    }
}
