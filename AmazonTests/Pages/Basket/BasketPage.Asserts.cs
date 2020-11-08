using AmazonTests.Pages.Base;
using NUnit.Framework;
using System;

namespace AmazonTests.Pages.Basket
{
    public partial class BasketPage : BasePage
    {

        public void VerifyProductIsAddedToBasketCorrectly(string expectedTitle, string expectedPrice)
        {
            string actualSubTotal = Driver.FindElement(ADDED_TO_BASKET_SUBTOTAL).Text;
            //string actualPrice = Driver.FindElement(ADDED_TO_BASKET_PRICE).Text;
            Boolean productAddedAsGift = Driver.FindElement(ADDED_TO_BASKET_GIFT_CHECKBOX).Selected;

            Assert.Multiple(() =>
            {
                Assert.That(actualSubTotal, Is.EqualTo(expectedTitle + expectedPrice));
                //Assert.That(actualPrice, Is.EqualTo(expectedPrice));
                Assert.That(productAddedAsGift, Is.EqualTo(true));
            });           
        }

        public void VerifySubTotalInformation(string expectedBookTitle, string expectedBookVersion,string expectedTotalPrice)
        {
            string expectedSubTotalText = "Subtotal (1 item):";
            string actualSubTotalText = Driver.FindElement(SUBTOTAL_TEXT).Text;
            string actualBookTitle = Driver.FindElement(FIRST_PRODUCT_TITLE).Text;
            string actualBookVersion = Driver.FindElement(FIRST_PRODUCT_VERSION).Text;
            string actualTotalPrice = Driver.FindElement(SUBTOTAL_AMOUNT).Text;

            Assert.Multiple(() =>
            {
                Assert.That(actualSubTotalText, Is.EqualTo(expectedSubTotalText) );
                Assert.That(actualBookTitle, Is.EqualTo(expectedBookTitle) );
                Assert.That(actualBookVersion, Is.EqualTo(expectedBookVersion) );
                Assert.That(actualTotalPrice, Is.EqualTo(expectedTotalPrice));
            });
        }
    }
}
