using Coypu;

namespace GitHubAutomation.pageObjectModels.pricing
{
    class StartEnterpriseTrial
    {
        BrowserSession browser;
        private readonly string xpath = "//a[contains(text(),'Start a free Enterprise trial')]";

        public StartEnterpriseTrial(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void click()
        {
            browser.FindXPath(xpath, Options.First).Click();
        }
    }
}                                                                                                                                                                                                                                                                                               