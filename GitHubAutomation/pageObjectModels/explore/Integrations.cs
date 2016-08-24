using Coypu;

namespace GitHubAutomation.pageObjectModels.explore
{
    class Integrations
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(@href,'/integrations')]";

        public Integrations(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}