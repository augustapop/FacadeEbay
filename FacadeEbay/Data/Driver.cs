﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Data
{
   public static class Driver
    {
       private static WebDriverWait browserWait;
       private static IWebDriver browser;

       public static IWebDriver Browser
       {
           get 
           {
               if (browser == null)
               {
                   throw new NullReferenceException("The web driver was not initialize");
               }
               return browser;
           }
           private set 
           {
               browser = value;
           }
       }

       public static WebDriverWait BrowserWait
       {
           get 
           {
               if (browserWait == null || browser == null)
               {
                   throw new NullReferenceException("The browser it wasnt start");
               }
               return browserWait;
           }
           private set
           {
               browserWait = value;
           }
       }

       public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Firefox, int defaultTimeout = 30)
       {
           switch (browserType)
           { 
               case BrowserTypes.Firefox:
                   Driver.Browser = new FirefoxDriver();
                   break;
               case BrowserTypes.InternetExplorer:
                   break;
               case BrowserTypes.Chrome:
                   break;
               default:
                   break;
           }
           BrowserWait = new WebDriverWait(Driver.Browser,TimeSpan.FromSeconds(defaultTimeout));
       }
       public static void StopBrowser()
       {
           Browser.Quit();
           Browser = null;
           BrowserWait = null;
       }
    }
}
