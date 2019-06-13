using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Drawing.Imaging;

namespace AnilaDemo
{
    [TestClass]
    public class UnitTest1 : Repo
    {
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver(*.xlsx)};dbq=|DataDirectory|\\DataManger\\TestData.xlsx;defaultdir=.;driverid=1046;maxbuffersize=2048;pagetimeout=5", "RR$", DataAccessMethod.Sequential), TestMethod]
        public void TestingMutipleRuns()
        {

            string strTestName = TestContext.TestName;
            string strD = DateTime.Now.ToString("HHmmss");
            Console.WriteLine(strD);
            IWebDriver driver = new ChromeDriver(@"D:\DevOps Testing\Development\AnilaDemo\AnilaDemo\Driver");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Url = "https://www.google.com/";
            driver.FindElement(GoogleSearchField).Click();
            driver.FindElement(GoogleSearchField).SendKeys(TestContext.DataRow["GoogleSearch"].ToString());
            driver.FindElement(GoogleSearchField).SendKeys(Keys.Tab);
            driver.FindElement(GoogleSearchBtn).Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"D:\Drop Folder\" + strTestName + " " + strD + ".jpeg", ScreenshotImageFormat.Jpeg);
            driver.Close();

        }

        [TestMethod]
        public void test()
        {
            string strD = DateTime.Now.ToString("HHmmss");
            Console.WriteLine(strD);
            string strdr = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            Console.WriteLine(strdr);
        }

        public TestContext TestContext
        {
            get { return m_testcontext; }
            set { m_testcontext = value; }
        }
        private TestContext m_testcontext;
    }
}
