using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class Logo
    {
        BrowserSession browser;
        private readonly string xpath = "//html/body/header/div/a";

        public Logo(BrowserSession browser){
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath).Click();
        }
    }
}
