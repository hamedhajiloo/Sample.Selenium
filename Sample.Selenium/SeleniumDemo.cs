using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Sample.Selenium
{
    public static class SeleniumDemo
    {
        public static async Task DoAsync()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

            var title = driver.Title;
            Console.WriteLine(title);

            driver.Quit();
        }
    }
}
