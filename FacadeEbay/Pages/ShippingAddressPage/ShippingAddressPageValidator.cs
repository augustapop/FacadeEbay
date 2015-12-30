using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.ShippingAddressPage
{
    public class ShippingAddressPageValidator : BasePageValidator<ShippingAddressPageMap>
    {
        public void Subtotal(string expectedSubtotal)
        {
            //AU $168.00
            Assert.AreEqual<string>(expectedSubtotal, this.Map.Subtotal.Text);
        }
    }
}
