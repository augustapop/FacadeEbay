﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FacadeEbay.Data;
using FacadeEbay.Pages.ItemPage;
using FacadeEbay.Pages.CheckoutPage;
using FacadeEbay.Pages.ShippingAddressPage;
using FacadeEbay.Pages.SignInPage;

namespace FacadeEbay
{
    [TestClass]
    public class EbayPurchase_without_PurchaseFaceade_Tests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }
        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void Purchase_Casio_GShock()
        {
            string itemUrl = "Casio-G-Shock-Standard-GA-100-1A2-Mens-Watch-Brand-New-/161209550414?pt=LH_DefaultDomain_15&hash=item2588d6864e";
            string itemPrice = "AU $147.00";
            ClientInfo currentClientInfo = new ClientInfo()
            {
                FirstName = "Anton",
                LastName = "Angelov",
                Country = "Bulgaria",
                Address1 = "33 Alexander Malinov Blvd.",
                City = "Sofia",
                Zip = "1729",
                Phone = "0035964644885",
                Email = "aangelov@yahoo.com"
            };

            ItemPage itemPage = new ItemPage();
            CheckoutPage checkouPage = new CheckoutPage();
            ShippingAddressPage shippingAddressPage = new ShippingAddressPage();
            SignInPage signInPage= new SignInPage();

            itemPage.Navigate(itemUrl);
            itemPage.Validate().Price(itemPrice);
            itemPage.ClickBuyNowButton();
            signInPage.ClickContinueAsGuestButton();
            shippingAddressPage.FillShippingInfo(currentClientInfo);
            shippingAddressPage.Validate().Subtotal(itemPrice);
            shippingAddressPage.ClickContinueButton();
            checkouPage.Validate().Subtotal(itemPrice);
        }

        [TestMethod]
        public void Purchase_WhiteOpticalKeyboard()
        {
            string itemUrl = "Wireless-White-2-4G-Optical-Keyboard-and-Mouse-USB-Receiver-Kit-For-PC-/360649772948?pt=LH_DefaultDomain_2&hash=item53f866cf94";
            string itemPrice = "C $20.86";
            ClientInfo currentClientInfo = new ClientInfo()
            {
                FirstName = "Anton",
                LastName = "Angelov",
                Country = "Bulgaria",
                Address1 = "33 Alexander Malinov Blvd.",
                City = "Stara Zagora",
                Zip = "6000",
                Phone = "0035964644885",
                Email = "aangelov@yahoo.com"
            };
            ItemPage itemPage = new ItemPage();
            CheckoutPage checkoutPage = new CheckoutPage();
            ShippingAddressPage shippingAddressPage = new ShippingAddressPage();
            SignInPage signInPage = new SignInPage();

            itemPage.Navigate(itemUrl);
            itemPage.Validate().Price(itemPrice);
            itemPage.ClickBuyNowButton();
            signInPage.ClickContinueAsGuestButton();
            shippingAddressPage.FillShippingInfo(currentClientInfo);
            shippingAddressPage.Validate().Subtotal(itemPrice);
            shippingAddressPage.ClickContinueButton();
            checkoutPage.Validate().Subtotal(itemPrice);
        }
    }
}
