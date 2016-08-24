using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class NewFeatures
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'New Features')]";

        public NewFeatures(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}