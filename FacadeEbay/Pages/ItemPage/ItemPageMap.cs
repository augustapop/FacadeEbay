using FacadeEbay.Pages.ShippingAddressPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.ItemPage
{
   public class ItemPageMap:BasePageElementMap
    {

       public IWebElement BuyNowButton
       {
           get
           {
               return this.browser.FindElement(By.Id("binBtn_btn"));
           }
       }
       public IWebElement Price
       {
           get
           {
               return this.browser.FindElement(By.Id("prcIsum"));
           }
       }
    }
}
