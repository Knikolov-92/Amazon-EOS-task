using AmazonTests.Pages.Base;
using OpenQA.Selenium;

namespace AmazonTests.Pages.SearchResult
{
    public partial class SearchResultPage : BasePage
    {
        public static readonly By FIRST_RESULT_TITLE = By.XPath
                    ("//*[@cel_widget_id='MAIN-SEARCH_RESULTS-1']//h2//span [@class='a-size-medium a-color-base a-text-normal']");

        public static readonly By FIRST_RESULT_VERSION_PAPERBACK = By.XPath
                    ("//*[@cel_widget_id='MAIN-SEARCH_RESULTS-1']//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']");

        public static readonly By FIRST_RESULT_PAPERBACK_PRICE = By.XPath
                    ("//*[@cel_widget_id='MAIN-SEARCH_RESULTS-1']//a [@class='a-size-base a-link-normal a-text-bold'][normalize-space(text())='Paperback']//following::span[@class='a-price'][1]");
    }
}
