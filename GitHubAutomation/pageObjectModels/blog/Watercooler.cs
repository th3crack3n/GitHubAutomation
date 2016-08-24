using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class Watercooler
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Watercooler')]";

        public Watercooler(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}