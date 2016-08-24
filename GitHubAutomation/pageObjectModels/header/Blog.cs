using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Blog
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Blog')]";

        public Blog(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
