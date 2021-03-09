using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using com.automationpractice.Pages;
using System.IO;
using System.Reflection;


namespace com.automationpractice
{
    public class LoginTest : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }


        [Test]
        public void EnterUserAndPasswordValid()
        {

            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.IsLogOffExist(), Is.True, "O botão de Log off não foi exibido");

            //Assert.Pass();

        }


        [Test]
        public void EnterUserAndPasswordInvalid()
        {
            Assert.Pass();
        }


        [Test]
        public void EnterUserdInvalid()
        {
            Assert.Pass();
        }


        [Test]
        public void EnterPasswordInvalid()
        {
            Assert.Pass();
        }


        [Test]
        public void EnterWithoutUser()
        {
            Assert.Pass();
        }


        [Test]
        public void EnterWithoutPassword()
        {
            Assert.Pass();
        }





    }
}