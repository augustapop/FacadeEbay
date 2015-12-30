using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEbay.Pages.ShippingAddressPage
{
    public class ShippingAddressPage : BasePage<ShippingAddressPageMap, ShippingAddressPageValidator>
    {
        public void ClickContinueButton()
        {
            this.Map.ContinueButton.Click();
        }

        public void FillShippingInfo(Data.ClientInfo clientInfo)
        {
            this.Map.SwitchToShippingFrame();
            this.Map.CountryDropDown.SelectByText(clientInfo.Country);
            this.Map.FirstName.SendKeys(clientInfo.FirstName);
            this.Map.LastName.SendKeys(clientInfo.LastName);
            this.Map.Address1.SendKeys(clientInfo.Address1);
            this.Map.City.SendKeys(clientInfo.City);
            this.Map.Zip.SendKeys(clientInfo.Zip);
            this.Map.Phone.SendKeys(clientInfo.Phone);
            this.Map.Email.SendKeys(clientInfo.Email);
            this.Map.SwitchToDefault();
        }
    }
}
