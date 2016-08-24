using Coypu;

namespace GitHubAutomation.pageObjectModels.blog
{
    class SearchBar
    {
        BrowserSession browser;
        private readonly string xpath = "//input[@id='blog-search']";

        public SearchBar(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void search(string text)
        {
            browser.FindXPath(xpath).FillInWith(text + "\n");
        }
    }
}
