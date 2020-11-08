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
    }
}
