using Coypu;

namespace GitHubAutomation.pageObjectModels.homepage
{
    class SignUpForGitHubButton
    {
        BrowserSession browser;
        private readonly string xpath = "//html/body/div[4]/div[5]/div/div/div[1]/a";

        public SignUpForGitHubButton(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath).Click();
        }
    }
}
