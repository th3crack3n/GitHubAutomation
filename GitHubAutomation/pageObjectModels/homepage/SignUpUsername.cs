using Coypu;

namespace GitHubAutomation.pageObjectModels.homepage
{
    class SignUpUsername
    {
        BrowserSession browser;
        private readonly string xpath = "//input[@id='user[login]']";

        public SignUpUsername(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void enterUsername(string text)
        {
            browser.FindXPath(xpath).FillInWith(text);
        }
    }
}
