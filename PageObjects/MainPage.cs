using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace UIAutomationExecise.PageObjects.MainPage
{
    class MainPage
    {
        private readonly IWebDriver _browser;
        private readonly WebDriverWait _wait;

        public MainPage(IWebDriver driver, WebDriverWait wait)
        {
            _browser = driver;
            _wait = wait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "gh-ac")]
        public IWebElement SearchBar { get; set; }

        public string Url
        {
            get
            {
                return @"https://www.ebay.com/";
            }
        }

        public void Navigate()
        {
            _browser.Navigate().GoToUrl(Url);
        }

        public void SearchItems(string item)
        {
            _wait.Until(d => SearchBar);
            SearchBar.Clear();
            SearchBar.SendKeys(item);
        }



    }
}
