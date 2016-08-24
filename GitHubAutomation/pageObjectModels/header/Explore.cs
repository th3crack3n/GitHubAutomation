using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Explore
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Explore')]";

        public Explore(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
