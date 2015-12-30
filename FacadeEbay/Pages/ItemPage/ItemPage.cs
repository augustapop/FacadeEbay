using FacadeEbay.Pages.ShippingAddressPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.ItemPage
{
   public class ItemPage:BasePage<ItemPageMap,ItemPageValidator>
    {
       public ItemPage()
           : base("http://www.ebay.com/itm/")
       {

       }

       public void ClickBuyNowButton()
       {
           this.Map.BuyNowButton.Click();
       }
       public override void Navigate(string part)
       {
           base.Navigate(part);
       }
    }
}
