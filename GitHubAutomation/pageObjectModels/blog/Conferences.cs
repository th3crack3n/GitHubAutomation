using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class Conferences
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Conferences')]";

        public Conferences(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
