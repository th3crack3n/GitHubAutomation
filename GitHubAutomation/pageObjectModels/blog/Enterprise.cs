using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class Enterprise
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Enterprise')]";

        public Enterprise(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}