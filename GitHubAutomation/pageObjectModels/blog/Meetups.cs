using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class Meetups
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Meetups')]";

        public Meetups(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}