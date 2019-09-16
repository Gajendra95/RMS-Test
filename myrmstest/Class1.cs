using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace myrmstest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void test1()
        {
            string Url = "http://172.16.51.51/RMSPublish/Login.aspx";
            IWebDriver driver = new ChromeDriver();

            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            //driver.Url = "http://172.16.51.47/RMSPublish/Login.aspx";
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxUid")).SendKeys("fassu3");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_TextBoxPassword")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderhead_Button1")).Click();
            Task.Delay(2000);
            /*driver.FindElement(By.XPath("//a[contains(text(),'Search')]")).Click();
            Task.Delay(2000);
            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBox1']")).SendKeys("Information");
            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_BtnSearch']")).Click();
            Task.Delay(2000);
            string expt = driver.FindElement(By.XPath("//span[@id='ctl00_ContentPlaceHolder1_GridView1_ctl02_EmailId']")).GetAttribute("innerHTML");
            Console.Write(expt);
            Assert.AreEqual("ravindra.prabhu@manipal.edu", expt);
            Task.Delay(2000);
            */


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement link_patent = driver.FindElement(By.LinkText("Search"));
            Actions actions = new Actions(driver);
            IAction mouseOverHome = actions.MoveToElement(link_patent).Build();
            mouseOverHome.Perform();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement link_patent_entry = driver.FindElement(By.LinkText("Keyword Based"));
            Actions action = new Actions(driver);
            IAction mouseOverList = actions.MoveToElement(link_patent_entry).Click().Build();
            mouseOverList.Perform();
            Task.Delay(2000);
            //driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBox1']")).SendKeys("Information");
            // Task.Delay(2000);
            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_BtnSearch']")).Click();
            Task.Delay(2000);
            string expt = driver.FindElement(By.XPath("//span[@id='ctl00_ContentPlaceHolder1_GridView1_ctl02_EmailId']")).GetAttribute("innerHTML");
            Console.Write(expt);
            Assert.AreEqual("brayal.dsouza@manipal.edu", expt);
            //driver.FindElement(By.XPath("//span[@id='ctl00_Label3']")).Click();

            //driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[3]/div[2]/nav[1]/ul[1]/li[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/a[1]")).Click();
            /*IWebElement drp = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpSelect"));
            SelectElement oSelect = new SelectElement(drp);
            oSelect.SelectByText("Nationality");
            Task.Delay(2000);
            IWebElement drpnat = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpNational"));
            SelectElement oSelectnat = new SelectElement(drpnat);
            oSelectnat.SelectByText("INDIA");
            Task.Delay(2000);
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_searchbtn")).Submit();*/

            driver.Close();



            //driver.FindElement(By.Id("ctl08_UserName")).SendKeys("chaitanya.cvs");
            //driver.FindElement(By.Id("ctl08_UserPass")).SendKeys("Chaitucvs_6");
            //driver.FindElement(By.Id("ctl08_cmdLogin")).Click();
            //Task.Delay(2000);
            //IWebElement drp = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpSelect"));
            //SelectElement oSelect = new SelectElement(drp);

            //oSelect.SelectByText("Nationality");
            //Task.Delay(2000);
            //IWebElement drpnat = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DrpNational"));
            //SelectElement oSelectnat = new SelectElement(drpnat);

            //oSelectnat.SelectByText("INDIA");
            //Task.Delay(2000);
            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_searchbtn")).Submit();

            //driver.Close();
        }
    }
}
