using Coypu;

namespace GitHubAutomation.pageObjectModels.footer
{
    class Shop
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Shop')]";

        public Shop(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
