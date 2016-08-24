using Coypu;

namespace GitHubAutomation.pageObjectModels.explore
{
    class Trending
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(@href,'/trending')]";

        public Trending(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}