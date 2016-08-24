using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class SignUp
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Sign up')]";

        public SignUp(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
