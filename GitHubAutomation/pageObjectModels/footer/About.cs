using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class About
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'About')]";

        public About(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
