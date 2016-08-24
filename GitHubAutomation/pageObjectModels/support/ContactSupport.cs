using Coypu;

namespace GitHubAutomation.pageObjectModels.support
{
    class ContactSupport
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Contact Support')]";

        public ContactSupport(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}