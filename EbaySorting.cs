using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using UIAutomationExecise.PageObjects.MainPage;
using UIAutomationExecise.Utils;

namespace UIAutomationExecise
{
    [TestClass]
    public class EbaySorting
    {
       
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestMethod]
        public void Orderbyprice()
        {
            var mainpage = new MainPage(Driver, Wait);
            mainpage.Navigate();
        }

        [TestInitialize]
        public void Setup()
        {
            var driverpath = CommonMethods.GetFolderPath("Drivers");
            Driver = new ChromeDriver(driverpath);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void Teardown()
        {
            Driver.Quit();
        }
    }
}
