using Coypu;

namespace GitHubAutomation.pageObjectModels.support
{
    class CreateARepo
    {
        BrowserSession browser;
        private readonly string xpath = "//img[@alt='Create a repo']";

        public CreateARepo(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}