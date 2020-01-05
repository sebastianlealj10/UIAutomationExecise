using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationExecise.PageObjects.MainPage
{
    internal class MainPageValidator
    {
        private readonly IWebDriver _browser;
        private WebDriverWait _wait;
        public MainPageValidator(IWebDriver browser, WebDriverWait wait)
        {
            _browser = browser;
            _wait = wait;
        }

        public MainPageElementMap Map
        {
            get
            {
                return new MainPageElementMap(_browser, _wait);
            }
        }
    }
}