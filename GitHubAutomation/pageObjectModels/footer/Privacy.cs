using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Privacy
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Privacy')]";

        public Privacy(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}