using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Security
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Security')]";

        public Security(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}