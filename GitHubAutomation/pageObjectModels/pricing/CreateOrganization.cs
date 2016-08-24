using Coypu;

namespace GitHubAutomation.pageObjectModels.pricing
{
    class CreateOrganization
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Create an organization')]";

        public CreateOrganization(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
