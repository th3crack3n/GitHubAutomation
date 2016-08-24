using Coypu;

namespace GitHubAutomation.pageObjectModels.homepage
{
    class SignUpEmail
    {
        BrowserSession browser;
        private readonly string xpath = "//input[@id='user[email]']";

        public SignUpEmail(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void enterEmail(string text)
        {
            browser.FindXPath(xpath).FillInWith(text);
        }
    }
}
