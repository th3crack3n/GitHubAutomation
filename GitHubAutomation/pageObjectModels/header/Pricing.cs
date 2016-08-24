using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Pricing
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Pricing')]";

        public Pricing(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
