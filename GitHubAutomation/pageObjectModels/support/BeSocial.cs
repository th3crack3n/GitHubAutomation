using Coypu;

namespace GitHubAutomation.pageObjectModels.support
{
    class BeSocial
    {
        BrowserSession browser;
        private readonly string xpath = "//img[@alt='Be social']";

        public BeSocial(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}