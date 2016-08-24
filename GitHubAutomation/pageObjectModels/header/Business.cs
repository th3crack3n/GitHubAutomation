using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Business
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Business')]";

        public Business(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
