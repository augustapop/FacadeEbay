using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeEbay.Pages.ShippingAddressPage
{
    public class BasePageValidator<M>
        where M : BasePageElementMap, new()
    {
        protected M Map
        {
            get
            {
                return new M();
            }
        }
    }
}
