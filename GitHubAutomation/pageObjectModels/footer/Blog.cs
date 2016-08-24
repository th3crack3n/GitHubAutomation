using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Blog
    {
        BrowserSession browser;
        private readonly string xpath = "//html/body/div[5]/div/ul[1]/li[5]/a";

        public Blog(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, new Options { TextPrecision = TextPrecision.Exact}).Click();
        }
    }
}
