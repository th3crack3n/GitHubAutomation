using Coypu;

namespace GitHubAutomation.pageObjectModels.header
{
    class SearchBar
    {
        BrowserSession browser;
        private readonly string xpath = "//input[@name='q']";

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
