using AmazonTests.Pages.Base;
using NUnit.Framework;


namespace AmazonTests.Pages.Home
{
    public partial class HomePage : BasePage
    {
        public void AssertHomePageisLoaded()
        {
            string expectedUrl = HOME_PAGE_URL;
            string expectedTitle = "Amazon.co.uk";
            string actualUrl = Driver.Url;
            string actualTitle = Driver.Title;

            Assert.Multiple( () =>
            {
                Assert.That(actualUrl, Is.EqualTo(expectedUrl) );
                Assert.That(actualTitle.StartsWith(expectedTitle) );
            });
        }
    }
}
