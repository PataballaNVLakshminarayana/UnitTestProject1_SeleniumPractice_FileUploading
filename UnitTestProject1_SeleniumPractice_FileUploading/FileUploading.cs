using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1_SeleniumPractice_FileUploading
{
    [TestClass]
    public class FileUploading
    {
        public static IWebDriver _Driver;
        [TestMethod]
        public void FileUploadingTestCase()
        {
            _Driver = new ChromeDriver();
            _Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            _Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            var filepath = _Driver.FindElement(By.XPath("//input[@id='file-upload']"));
            filepath.SendKeys(@"C:\Users\lakshminarayana.B2BSOFTECH\Desktop\PathVia\Test Process.JPG");
            _Driver.FindElement(By.XPath("//input[@id='file-submit']")).Click();
            if(filepath !=null)
            {
                Console.WriteLine("File Uploaded Successfully..!");
            }
            else
            {
                Console.WriteLine("File Not Uploaded");
            }
            Thread.Sleep(10000);
            _Driver.Quit();
        }
    }
}
