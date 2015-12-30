using FacadeEbay.Data;
using FacadeEbay.Pages.CheckoutPage;
using FacadeEbay.Pages.ItemPage;
using FacadeEbay.Pages.ShippingAddressPage;
using FacadeEbay.Pages.SignInPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay
{
  public  class PurchaseFacade
    {
      private ItemPage itemPage;
      private CheckoutPage checkoutPage;
      private ShippingAddressPage shippingAddressPage;
      private SignInPage signInPage;


      public ItemPage ItemPage
      {
          get
          {
              if (itemPage == null)
              {
                  itemPage = new ItemPage();
              }
              return itemPage;
          }          
      }
      public CheckoutPage CheckoutPage
      {
          get
          {
              if (checkoutPage == null)
              {
                  checkoutPage = new CheckoutPage();
              }
              return checkoutPage;
          }
      }
      public ShippingAddressPage ShippingAddressPage
      {
          get
          {
              if (shippingAddressPage == null)
              {
                  shippingAddressPage = new ShippingAddressPage();
              }
              return shippingAddressPage;
          }
      }

      public SignInPage SignInPage
      {
          get
          {
              if (signInPage == null)

              {
                  signInPage = new SignInPage();
              }
              return signInPage;
          }
      }

      public void PurchaseItem(string item, string itemPrice, ClientInfo clientInfo)
      {
          this.ItemPage.Navigate(item);
          this.ItemPage.Validate().Price(itemPrice);
          this.ItemPage.ClickBuyNowButton();
          this.SignInPage.ClickContinueAsGuestButton();
          this.ShippingAddressPage.FillShippingInfo(clientInfo);
          this.ShippingAddressPage.Validate().Subtotal(itemPrice);
          this.ShippingAddressPage.ClickContinueButton();
          this.CheckoutPage.Validate().Subtotal(itemPrice);

      }
    } 

}
