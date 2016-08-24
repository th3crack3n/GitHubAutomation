using Coypu;

namespace GitHubAutomation.pageObjectModels.support
{
    class SearchBar
    {
        BrowserSession browser;
        private readonly string xpath = "//input[@id='quicksearch-query']";

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
