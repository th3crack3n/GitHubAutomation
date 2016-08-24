using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class Engineering
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Engineering')]";

        public Engineering(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}