using OpenQA.Selenium;

namespace AmazonTests.Pages.Base
{
    public partial class BasePage
    {
        protected IWebDriver Driver { get; }       

        public BasePage(IWebDriver driver)
        {
            Driver = driver;            
        }

        public void NavigateTo(string targetURL)
        {
            Driver.Navigate().GoToUrl(targetURL);
        }

        public void ClickOn(By elementLocator)
        {
            WaitUntilElementIsDisplayed(elementLocator);
            Driver.FindElement(elementLocator).Click();
        }

        public void FillFieldWithText(By textFieldLocator, string text)
        {
            Driver.FindElement(textFieldLocator).SendKeys(text);
        }
 
    }
}
