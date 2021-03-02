using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void TestMethodForSelenium()
        {
            Console.WriteLine("TestMethod 3 Started");

            var Driver = new ChromeDriver();
            try
            {
                //var Driver = new ChromeDriver();
                Driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 30);
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl("https://www.google.com");
                //Driver.Manage().Cookies();

                Assert.IsTrue(0 == 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Driver.Close();
            }
            Console.WriteLine("TestMethod 3 done");


        }
    }
}