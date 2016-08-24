using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Logo
    {
        BrowserSession browser;
        private readonly string xpath = "//html/body/div[5]/div/a";

        public Logo(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath).Click();
        }
    }
}