using Coypu;

namespace GitHubAutomation.pageObjectModels.pricing
{
    class JoinGitHubForFree
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Join GitHub for free')]";

        public JoinGitHubForFree(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
