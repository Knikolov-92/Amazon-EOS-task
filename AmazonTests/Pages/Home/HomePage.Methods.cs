using AmazonTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonTests.Pages.Home
{
    public partial class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void Open()
        {
            NavigateTo(HOME_PAGE_URL);
            WaitUntilPageIsLoaded();
        }
        
        public void AcceptCookies()
        {
            ClickOn(ACCEPT_COOKIES_BUTTON);
        }

        public void SearchForBook(string bookName)
        {
            SelectSearchCategory("Books");
            FillFieldWithText(SEARCH_FIELD, bookName);
            ClickOn(SEARCH_GO_BUTTON);            
        }

        public void SelectSearchCategory(string categoryName)
        {
            SelectElement categoryDropDown = new SelectElement(Driver.FindElement(SEARCH_CATEGORY_DROPDOWN));

            categoryDropDown.SelectByText(categoryName);
        }
    }
}
