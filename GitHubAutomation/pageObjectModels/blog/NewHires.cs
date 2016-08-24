using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class NewHires
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'New Hires')]";

        public NewHires(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}