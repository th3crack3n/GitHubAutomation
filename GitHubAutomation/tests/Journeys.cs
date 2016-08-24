using Coypu;
using NUnit.Framework;
using GitHubAutomation.pageObjectModels.footer;
using GitHubAutomation.pageObjectModels.header;
using GitHubAutomation.pageObjectModels.homepage;
using GitHubAutomation.pageObjectModels.pricing;
using GitHubAutomation.pageObjectModels.blog;

namespace GitHubAutomation.tests.homepage
{
    [TestFixture]
    class Journeys
    {
        BrowserSession browser;

        // footer objects
        Terms terms;
        Privacy privacy;
        Security security;
        Status status;
        Help help;
        pageObjectModels.footer.Logo footerLogo;
        ContactGitHub contactGitHub;
        API api;
        Training training;
        Shop shop;
        pageObjectModels.footer.Blog footerBlog;
        About about;

        // header objects
        pageObjectModels.header.Logo headerLogo;
        Personal personal;
        OpenSource openSource;
        Business business;
        Explore explore;
        Pricing pricing;
        pageObjectModels.header.Blog headerBlog;
        Support support;
        pageObjectModels.header.SearchBar searchBar;
        SignIn signIn;
        SignUp signUp;

        // main objects
        SignUpUsername signUpUsername;
        SignUpEmail signUpEmail;
        SignUpPassword signUpPassword;
        SignUpSubmit signUpSubmit;
        SignUpForGitHubButton signUpForGitHub;

        // pricing objects
        JoinGitHubForFree joinGitHubForFree;
        UpgradeAccount upgradeAccount;
        CreateOrganization createOrganization;
        StartEnterpriseTrial startEnterpriseTrial;

        // blog objects
        Featured featured;
        AllPosts allPosts;
        NewFeatures newFeatures;
        Engineering engineering;
        Enterprise enterprise;
        Conferences conferences;
        Meetups meetups;
        NewHires newHires;
        Watercooler watercooler;
        pageObjectModels.blog.SearchBar blogSearchBar;

        [TestFixtureSetUp]
        public void init()
        {
            browser = new BrowserSession(new SessionConfiguration
            {
                AppHost = "https://www.github.com"
            });
            browser.MaximiseWindow();

            initObjectModels();
        }

        private void initObjectModels()
        {
            // initializing footer objects
            terms = new Terms(browser);
            privacy = new Privacy(browser);
            security = new Security(browser);
            status = new Status(browser);
            help = new Help(browser);
            footerLogo = new pageObjectModels.footer.Logo(browser);
            contactGitHub = new ContactGitHub(browser);
            api = new API(browser);
            training = new Training(browser);
            shop = new Shop(browser);
            footerBlog = new pageObjectModels.footer.Blog(browser);
            about = new About(browser);

            // initializing header objects
            headerLogo = new pageObjectModels.header.Logo(browser);
            personal = new Personal(browser);
            openSource = new OpenSource(browser);
            business = new Business(browser);
            explore = new Explore(browser);
            pricing = new Pricing(browser);
            headerBlog = new pageObjectModels.header.Blog(browser);
            support = new Support(browser);
            searchBar = new pageObjectModels.header.SearchBar(browser);
            signIn = new SignIn(browser);
            signUp = new SignUp(browser);

            // initializing main objects
            signUpUsername = new SignUpUsername(browser);
            signUpEmail = new SignUpEmail(browser);
            signUpPassword = new SignUpPassword(browser);
            signUpSubmit = new SignUpSubmit(browser);
            signUpForGitHub = new SignUpForGitHubButton(browser);

            // initializing pricing objects
            joinGitHubForFree = new JoinGitHubForFree(browser);
            upgradeAccount = new UpgradeAccount(browser);
            createOrganization = new CreateOrganization(browser);
            startEnterpriseTrial = new StartEnterpriseTrial(browser);

            // initializing blog objects
            featured = new Featured(browser);
            allPosts = new AllPosts(browser);
            newFeatures = new NewFeatures(browser);
            engineering = new Engineering(browser);
            enterprise = new Enterprise(browser);
            conferences = new Conferences(browser);
            meetups = new Meetups(browser);
            newHires = new NewHires(browser);
            watercooler = new Watercooler(browser);
            blogSearchBar = new pageObjectModels.blog.SearchBar(browser);
        }

        [SetUp]
        public void reset()
        {
            browser.Visit("/");
        }
        
        /// <summary>
        /// Attempts to create an account, but fails because password is too short
        /// </summary>
        [Test]
        public void createAccount()
        {
            signUpUsername.enterUsername("SeanMcCracken");
            signUpEmail.enterEmail("smccracken@xpanxion.com");
            signUpPassword.enterPassword("fake");
            signUpSubmit.click();
        }

        [TestFixtureTearDown]
        public void destroy()
        {
            browser.Dispose();
        }
    }
}
