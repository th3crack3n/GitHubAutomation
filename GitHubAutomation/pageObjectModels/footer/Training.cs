using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Training
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Training')]";

        public Training(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
