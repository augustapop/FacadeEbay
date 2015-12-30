using FacadeEbay.Pages.ShippingAddressPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.SignInPage
{
  public  class SignInPage:BasePage<SignInPageMap,SignInPageValidator>
    {
      public SignInPage():base(@"http://www.ebay.com/")
      {

      }
      public void ClickContinueAsGuestButton()
      {
          this.Map.ContinueAsGuestButton.Click();
      }
    }
}
