using Coypu;

namespace GitHubAutomation.pageObjectModels.homepage
{
    class SignUpPassword
    {
        BrowserSession browser;
        private readonly string xpath = "//input[@id='user[password]']";

        public SignUpPassword(BrowserSession browser)
        {
            this.browser = browser;
        }
        
        public void enterPassword(string text)
        {
            browser.FindXPath(xpath).FillInWith(text);
        }
    }
}
