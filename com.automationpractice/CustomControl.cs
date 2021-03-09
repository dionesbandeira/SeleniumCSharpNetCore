﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace com.automationpractice
{
    class CustomControl
    {

        public static void EnterText(IWebElement webElement, string value) 
        {
            webElement.SendKeys(value);
        }

        public static void Click(IWebElement webElement) 
        { 
            webElement.Click(); 
        }

        public static void SelectByValue(IWebElement webElement, string value) 
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }


        public static void SelectByText(IWebElement webElement, string text) 
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }


        //public static void ComboBox(string controlName, string value)
        //{
        //    IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
        //    comboControl.Clear();
        //    comboControl.SendKeys(value);
        //    Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        //}



    }
}