using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestLibrary
{
    public class Test
    {
        //[Test]
        public void Verifylogin()
        {
            //IWebDriver driver = new ChromeDriver(@"C:\Users\INTECHUB\Downloads\chromedriver_win32");
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(3000);
            Console.WriteLine("JMJF welcome you");
            driver.Navigate().GoToUrl("https://www.phptravels.net/login");
            driver.FindElement(By.Name("username")).SendKeys("user@phptravels.com");
            driver.FindElement(By.Name("password")).SendKeys("demouser");
            driver.FindElement(By.XPath("// button[contains(text(),'Login')]")).Click();
            Thread.Sleep(15000);

            driver.Manage().Window.Maximize();

            string expectedurl = "https://www.phptravels.net/account/";
            string url = driver.Url;
            Assert.AreEqual(url, expectedurl);
            // to close browsers
            driver.Close();
            driver.Dispose();
            driver.Quit();
            //Assert.Pass();
        }


    }
}
