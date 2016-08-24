using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Help
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Help')]";

        public Help(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}