using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class SignIn
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Sign in')]";

        public SignIn(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
