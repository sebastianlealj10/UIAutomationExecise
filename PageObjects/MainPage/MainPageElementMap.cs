using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationExecise.PageObjects.MainPage
{
    internal class MainPageElementMap
    {
        private readonly IWebDriver _browser;
        private readonly WebDriverWait _wait;

        public MainPageElementMap(IWebDriver driver, WebDriverWait wait)
        {
            _browser = driver;
            _wait = wait;
        }

        public IWebElement SearchBar
        {
            get
            {
                _wait.Until(d => d.FindElement(By.Id("gh-ac")));
                return _browser.FindElement(By.Id("gh-ac"));
            }
        }

    }
}