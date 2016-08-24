using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class Featured
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Featured')]";

        public Featured(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
