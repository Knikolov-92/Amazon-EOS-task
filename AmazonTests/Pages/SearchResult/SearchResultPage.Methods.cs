using AmazonTests.Pages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AmazonTests.Pages.SearchResult
{
    public partial class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public void VerifyFirstResultTitle(string expectedTitle)
        {
            WaitUntilElementIsDisplayed(FIRST_RESULT_TITLE);
            string actualTitle = Driver.FindElement(FIRST_RESULT_TITLE).Text;
            Console.WriteLine("actual title:" + actualTitle);
            Assert.That(actualTitle, Is.EqualTo(expectedTitle) );
        }

        public string VerifyFirstResultHasPaperbackVersion(string expectedVersion)
        {           
            string actualVersion = Driver.FindElement(FIRST_RESULT_VERSION_PAPERBACK).Text;
            string paperbackPrice = Driver.FindElement(FIRST_RESULT_PAPERBACK_PRICE).Text;

            Assert.That(actualVersion, Is.EqualTo(expectedVersion));

            return paperbackPrice;
        }

    }
}
