using FacadeEbay.Pages.ShippingAddressPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.CheckoutPage
{
  public  class CheckoutPageValidator:BasePageValidator<CheckoutPageMap>
    {
      public void Subtotal(string expectedSubtotal)
      {
          Assert.AreEqual<string>(expectedSubtotal,this.Map.TotalPrice.Text);
      }
    }
}
