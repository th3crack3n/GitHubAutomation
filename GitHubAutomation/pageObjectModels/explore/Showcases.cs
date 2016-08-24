using Coypu;

namespace GitHubAutomation.pageObjectModels.explore
{
    class Showcases
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(@href,'/showcases')]";

        public Showcases(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}