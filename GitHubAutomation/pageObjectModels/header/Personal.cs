using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Personal
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Personal')]";

        public Personal(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
