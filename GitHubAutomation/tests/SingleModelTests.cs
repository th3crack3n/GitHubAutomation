using Coypu;
using NUnit.Framework;
using GitHubAutomation.pageObjectModels.blog;
using GitHubAutomation.pageObjectModels.explore;
using GitHubAutomation.pageObjectModels.footer;
using GitHubAutomation.pageObjectModels.header;
using GitHubAutomation.pageObjectModels.homepage;
using GitHubAutomation.pageObjectModels.pricing;
using GitHubAutomation.pageObjectModels.support;

namespace GitHubAutomation.tests
{
    [TestFixture]
    class SingleModelTests
    {
        BrowserSession browser;

        // blog objects
        AllPosts allPosts;
        Conferences conferences;
        Engineering engineering;
        Enterprise enterprise;
        Featured featured;
        Meetups meetups;
        NewFeatures newFeatures;
        NewHires newHires;
        pageObjectModels.blog.SearchBar blogSearchBar;
        Watercooler watercooler;

        // explore objects
        Integrations integrations;
        Showcases showcases;
        Trending trending;

        // footer objects
        About about;
        API api;
        pageObjectModels.footer.Blog footerBlog;
        ContactGitHub contactGitHub;
        Help help;
        pageObjectModels.footer.Logo footerLogo;
        Privacy privacy;
        Security security;
        Shop shop;
        Status status;
        Terms terms;
        Training training;

        // header objects
        pageObjectModels.header.Blog headerBlog;
        Business business;
        Explore explore;
        pageObjectModels.header.Logo headerLogo;
        OpenSource openSource;
        Personal personal;
        Pricing pricing;
        pageObjectModels.header.SearchBar headerSearchBar;
        SignIn signIn;
        SignUp signUp;
        Support support;

        // main objects
        SignUpEmail signUpEmail;
        SignUpForGitHubButton signUpForGitHub;
        SignUpPassword signUpPassword;
        SignUpSubmit signUpSubmit;
        SignUpUsername signUpUsername;

        // pricing objects
        CreateOrganization createOrganization;
        JoinGitHubForFree joinGitHubForFree;
        StartEnterpriseTrial startEnterpriseTrial;
        UpgradeAccount upgradeAccount;

        // support objects
        BeSocial beSocial;
        ContactSupport contactSupport;
        CreateARepo createARepo;
        ForkARepo forkARepo;
        pageObjectModels.support.SearchBar supportSearchBar;
        SetUpGit setUpGit;

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
            // initializing blog objects
            allPosts = new AllPosts(browser);
            conferences = new Conferences(browser);
            engineering = new Engineering(browser);
            enterprise = new Enterprise(browser);
            featured = new Featured(browser);
            meetups = new Meetups(browser);
            newFeatures = new NewFeatures(browser);
            newHires = new NewHires(browser);
            blogSearchBar = new pageObjectModels.blog.SearchBar(browser);
            watercooler = new Watercooler(browser);

            // initializing explore objects
            integrations = new Integrations(browser);
            showcases = new Showcases(browser);
            trending = new Trending(browser);

            // initializing footer objects
            about = new About(browser);
            api = new API(browser);
            footerBlog = new pageObjectModels.footer.Blog(browser);
            contactGitHub = new ContactGitHub(browser);
            help = new Help(browser);
            footerLogo = new pageObjectModels.footer.Logo(browser);
            privacy = new Privacy(browser);
            security = new Security(browser);
            shop = new Shop(browser);
            status = new Status(browser);
            terms = new Terms(browser);
            training = new Training(browser);

            // initializing header objects
            headerBlog = new pageObjectModels.header.Blog(browser);
            business = new Business(browser);
            explore = new Explore(browser);
            headerLogo = new pageObjectModels.header.Logo(browser);
            openSource = new OpenSource(browser);
            personal = new Personal(browser);
            pricing = new Pricing(browser);
            headerSearchBar = new pageObjectModels.header.SearchBar(browser);
            signIn = new SignIn(browser);
            signUp = new SignUp(browser);
            support = new Support(browser);

            // initializing main objects
            signUpEmail = new SignUpEmail(browser);
            signUpForGitHub = new SignUpForGitHubButton(browser);
            signUpPassword = new SignUpPassword(browser);
            signUpSubmit = new SignUpSubmit(browser);
            signUpUsername = new SignUpUsername(browser);

            // initializing pricing objects
            createOrganization = new CreateOrganization(browser);
            joinGitHubForFree = new JoinGitHubForFree(browser);
            startEnterpriseTrial = new StartEnterpriseTrial(browser);
            upgradeAccount = new UpgradeAccount(browser);

            // initializing support objects
            beSocial = new BeSocial(browser);
            contactSupport = new ContactSupport(browser);
            createARepo = new CreateARepo(browser);
            forkARepo = new ForkARepo(browser);
            setUpGit = new SetUpGit(browser);
            supportSearchBar = new pageObjectModels.support.SearchBar(browser);
        }

        // setup

        [SetUp]
        public void reset()
        {
            browser.Visit("/");
        }

        // blog tests

        [Test]
        public void testAllPosts()
        {
            headerBlog.click();
            allPosts.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/all"));
        }

        [Test]
        public void testConferences()
        {
            headerBlog.click();
            conferences.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/conferences"));
        }

        [Test]
        public void testEngineering()
        {
            headerBlog.click();
            engineering.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/engineering"));
        }

        [Test]
        public void testEnterprise()
        {
            headerBlog.click();
            enterprise.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/enterprise"));
        }

        [Test]
        public void testFeatured()
        {
            headerBlog.click();
            featured.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog"));
        }

        [Test]
        public void testMeetups()
        {
            headerBlog.click();
            meetups.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/meetup"));
        }

        [Test]
        public void testNewFeatures()
        {
            headerBlog.click();
            newFeatures.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/ship"));
        }

        [Test]
        public void testNewHires()
        {
            headerBlog.click();
            newHires.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/hire"));
        }

        [Test]
        public void testBlogSearchBar()
        {
            headerBlog.click();
            blogSearchBar.search("Sean");

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/search?utf8=✓&q=Sean"));
        }

        [Test]
        public void testWatercooler()
        {
            headerBlog.click();
            watercooler.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog/category/watercooler"));
        }

        // explore tests

        [Test]
        public void testIntegrations()
        {
            explore.click();
            integrations.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/integrations"));
        }

        [Test]
        public void testShowcases()
        {
            explore.click();
            showcases.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/showcases"));
        }

        [Test]
        public void testTrending()
        {
            explore.click();
            trending.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/trending"));
        }

        // footer tests

        [Test]
        public void testAbout()
        {
            about.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/about"));
        }

        [Test]
        public void testAPI()
        {
            api.click();

            Assert.True(browser.Location.ToString().Equals("https://developer.github.com/"));
        }

        [Test]
        public void testFooterBlog()
        {
            footerBlog.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog"));
        }

        [Test]
        public void testContactGitHub()
        {
            contactGitHub.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/contact"));
        }

        [Test]
        public void testHelp()
        {
            help.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/"));
        }

        [Test]
        public void testFooterLogo()
        {
            footerLogo.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/"));
        }

        [Test]
        public void testPrivacy()
        {
            privacy.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/github-privacy-policy/"));
        }

        [Test]
        public void testSecurity()
        {
            security.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/github-security/"));
        }

        [Test]
        public void testShop()
        {
            shop.click();

            Assert.True(browser.Location.ToString().Equals("https://github.myshopify.com/"));
        }

        [Test]
        public void testStatus()
        {
            status.click();

            Assert.True(browser.Location.ToString().Equals("https://status.github.com/"));
        }

        [Test]
        public void testTerms()
        {
            terms.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/github-terms-of-service/"));
        }

        [Test]
        public void testTraining()
        {
            training.click();

            Assert.True(browser.Location.ToString().Equals("https://services.github.com/"));
        }

        // header tests

        [Test]
        public void testHeaderBlog()
        {
            headerBlog.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/blog"));
        }

        [Test]
        public void testBusiness()
        {
            business.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/business"));
        }

        [Test]
        public void testExplore()
        {
            explore.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/explore"));
        }

        [Test]
        public void testHeaderLogo()
        {
            headerLogo.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/"));
        }

        [Test]
        public void testOpenSource()
        {
            openSource.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/open-source"));
        }

        [Test]
        public void testPersonal()
        {
            personal.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/personal"));
        }

        [Test]
        public void testPricing()
        {
            pricing.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/pricing"));
        }

        [Test]
        public void testHeaderSearchBar()
        {
            headerSearchBar.search("Sean");

            Assert.True(browser.Location.ToString().Equals("https://github.com/search?utf8=✓&q=Sean"), browser.Location.ToString());
        }

        [Test]
        public void testSignIn()
        {
            signIn.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/login"));
        }

        [Test]
        public void testSignUp()
        {
            signUp.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/join?source=header-home"));
        }

        [Test]
        public void testSupport()
        {
            support.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/"));
        }

        // homepage tests

        [Test]
        public void testSignUpEmail()
        {
            signUpEmail.enterEmail("smccracken@xpanxion.com");

            Assert.True(browser.FindId("user[email]").Value == "smccracken@xpanxion.com");
        }

        [Test]
        public void testSignUpForGitHub()
        {
            signUpForGitHub.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/join?source=button-home"));
        }

        [Test]
        public void testSignUpPassword()
        {
            signUpPassword.enterPassword("fakepass");

            Assert.True(browser.FindId("user[password]").Value == "fakepass");
        }

        [Test]
        public void testSignUpSubmit()
        {
            signUpSubmit.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/join"));
        }

        [Test]
        public void testSignUpUsername()
        {
            signUpUsername.enterUsername("Sean");

            Assert.True(browser.FindId("user[login]").Value == "Sean");
        }

        // pricing tests

        [Test]
        public void testCreateOrganization()
        {
            pricing.click();
            createOrganization.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/join?source=button-pricing"));
        }

        [Test]
        public void testJoinGitHubForFree()
        {
            pricing.click();
            joinGitHubForFree.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/join?source=button-pricing"));
        }

        [Test]
        public void testStartEnterpriseTrial()
        {
            pricing.click();
            startEnterpriseTrial.click();

            Assert.True(browser.Location.ToString().Equals("https://enterprise.github.com/sn-trial"));
        }

        [Test]
        public void testUpgradeAccount()
        {
            pricing.click();
            upgradeAccount.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/join?source=button-pricing"));
        }

        // support tests

        [Test]
        public void testBeSocial()
        {
            support.click();
            beSocial.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/be-social/"));
        }

        [Test]
        public void testContactSupport()
        {
            support.click();
            contactSupport.click();

            Assert.True(browser.Location.ToString().Equals("https://github.com/contact"));
        }

        [Test]
        public void testCreateARepo()
        {
            support.click();
            createARepo.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/create-a-repo/"));
        }

        [Test]
        public void testForkARepo()
        {
            support.click();
            forkARepo.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/fork-a-repo/"));
        }

        [Test]
        public void testSupportSearchBar()
        {
            support.click();
            supportSearchBar.search("issue");

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/search/?utf8=✓&q=issue"));
        }

        [Test]
        public void testSetUpGit()
        {
            support.click();
            setUpGit.click();

            Assert.True(browser.Location.ToString().Equals("https://help.github.com/articles/set-up-git/"));
        }

        // teardown

        [TestFixtureTearDown]
        public void destroy()
        {
            browser.Dispose();
        }

    }
}
