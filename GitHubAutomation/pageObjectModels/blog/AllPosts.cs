using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class AllPosts
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'All Posts')]";

        public AllPosts(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}