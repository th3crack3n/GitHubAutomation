using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Status
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Status')]";

        public Status(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}