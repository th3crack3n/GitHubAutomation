using Coypu;

namespace GitHubAutomation.pageObjectModels.support
{
    class ForkARepo
    {
        BrowserSession browser;
        private readonly string xpath = "//img[@alt='Fork a repo']";

        public ForkARepo(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}