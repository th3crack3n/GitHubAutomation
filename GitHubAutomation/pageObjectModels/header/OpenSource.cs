using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class OpenSource
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Open source')]";

        public OpenSource(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
