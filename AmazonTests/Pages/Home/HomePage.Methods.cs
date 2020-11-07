using AmazonTests.Pages.Base;
using OpenQA.Selenium;


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
    }
}
