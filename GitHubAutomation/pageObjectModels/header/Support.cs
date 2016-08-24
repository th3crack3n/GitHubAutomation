using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Support
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Support')]";

        public Support(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
