using Coypu;

namespace GitHubAutomation.pageObjectModels.pricing
{
    class UpgradeAccount
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Upgrade your account')]";

        public UpgradeAccount(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}
