using AmazonTests.Pages.Base;
using NUnit.Framework;

namespace AmazonTests.Pages.Product
{
    public partial class ProductPage : BasePage
    {

        public void VerifyPaperbackVersionIsSelected(string expectedBookTitle, string expectedBookVersion, string expectedBookPrice)
        {
            string actualBookTitle = Driver.FindElement(BOOK_TITLE).Text;
            string actualBookVersion = Driver.FindElement(BOOK_SUBTITLE).Text;
            string actualBookPrice = Driver.FindElement(BOOK_PRICE).Text;

            Assert.Multiple(() =>
            {
                Assert.That(actualBookTitle, Is.EqualTo(expectedBookTitle) );
                Assert.That(actualBookVersion.StartsWith(expectedBookVersion) );
                Assert.That(actualBookPrice, Is.EqualTo(expectedBookPrice) );
            });
        }
    }
}
