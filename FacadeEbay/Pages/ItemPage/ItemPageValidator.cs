using FacadeEbay.Pages.ShippingAddressPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.ItemPage
{
   public class ItemPageValidator:BasePageValidator<ItemPageMap>
    {
       public void Price(string expectedPrice)
       {
           Assert.AreEqual<string>(expectedPrice,this.Map.Price.Text);
       }
    }
}
