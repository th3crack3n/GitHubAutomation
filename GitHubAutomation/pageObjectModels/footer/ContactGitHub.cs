using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class ContactGitHub
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Contact GitHub')]";

        public ContactGitHub(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
