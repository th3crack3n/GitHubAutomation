using Coypu;

namespace GitHubAutomation.pageObjectModels.homepage
{
    class SignUpSubmit
    {
        BrowserSession browser;
        private readonly string xpath = "//button[@type='submit']";

        public SignUpSubmit(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
