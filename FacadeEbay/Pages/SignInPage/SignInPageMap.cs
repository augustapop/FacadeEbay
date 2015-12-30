using FacadeEbay.Pages.ShippingAddressPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.SignInPage
{
   public class SignInPageMap:BasePageElementMap
    {
       public IWebElement ContinueAsGuestButton
       {
           get
           {
               return this.browser.FindElement(By.Id("gtChk"));
           }
       }
    }
}
