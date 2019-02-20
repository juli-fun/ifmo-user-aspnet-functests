using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ifmo_user_aspnet_functests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAuthorize()
        {
            var driver = new ChromeDriver(@"/usr/local/bin");
            driver.Navigate().GoToUrl("http://127.0.0.1:8080/");
            var element1 = driver.FindElement(By.Name("_login_auth"));
            element1.SendKeys("berezhkov");
            var element2 = driver.FindElement(By.Name("_password_auth"));
            element2.SendKeys("P@ssw0rd#123");
            var element3 = driver.FindElement(By.Name("_reg_auth"));
            element3.Click();

            Assert.True(driver.FindElement(By.Id("_is_authorized")).Text == "Авторизован!");
        }
    }
}
