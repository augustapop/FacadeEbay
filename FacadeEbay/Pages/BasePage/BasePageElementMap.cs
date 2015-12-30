using FacadeEbay.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeEbay.Pages.ShippingAddressPage
{
  public  class BasePageElementMap
    {
      protected IWebDriver browser;
      protected WebDriverWait browserWait;
      
      public BasePageElementMap()
      {
          this.browser = Driver.Browser;
          this.browserWait = Driver.BrowserWait;
      }

      public void SwitchToDefault()
      {
          this.browser.SwitchTo().DefaultContent();
      }      
    }
}
