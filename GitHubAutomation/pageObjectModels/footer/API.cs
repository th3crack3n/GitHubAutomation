using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class API
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'API')]";

        public API(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
