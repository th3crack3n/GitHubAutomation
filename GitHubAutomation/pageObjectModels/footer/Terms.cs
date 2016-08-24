using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Terms
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Terms')]";

        public Terms(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
