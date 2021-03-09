using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using com.automationpractice.Pages;
using System.IO;
using System.Reflection;

namespace com.automationpractice
{
    public class HomeTest : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeDriver driver = new ChromeDriver();
        }


        [Test]
        public void EnterUserAndPasswordValid()
        {
            Assert.Pass();
        }

     
    }
}