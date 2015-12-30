using FacadeEbay.Pages.ShippingAddressPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.CheckoutPage
{
    public class CheckoutPageMap : BasePageElementMap
    {
        public IWebElement TotalPrice
        {
            get
      {
          return this.browser.FindElement(By.Id("xo_tot_amt"));
  }
        }
    }
}
