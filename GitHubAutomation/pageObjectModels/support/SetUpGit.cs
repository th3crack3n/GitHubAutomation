using Coypu;

namespace GitHubAutomation.pageObjectModels.support
{
    class SetUpGit
    {
        BrowserSession browser;
        private readonly string xpath = "//img[@alt='Set up git']";

        public SetUpGit(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}