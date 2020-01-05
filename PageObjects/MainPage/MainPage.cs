using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationExecise.PageObjects.MainPage
{
    class MainPage
    {
        private readonly IWebDriver _browser;
        private WebDriverWait _wait;
        private readonly string _url = @"https://www.ebay.com/";

        public MainPage(IWebDriver driver, WebDriverWait wait)
        {
            _browser = driver;
            _wait = wait;
        }

        protected MainPageElementMap Map
        {
            get
            {
                return new MainPageElementMap(_browser, _wait);
            }
        }

        public MainPageValidator Validate()
        {
            return new MainPageValidator(_browser, _wait);
        }

        public void Navigate()
        {
            _browser.Navigate().GoToUrl(_url);
        }

        public void SearchItems(string item)
        {
            Map.SearchBar.Clear();
            Map.SearchBar.SendKeys(item);
        }



    }
}
