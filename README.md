# FacadeEbay using Selenium and VisualStudio c#

Requirements:
The primary goal of the below tests is going to be to purchase different items from Ebay

Ready Scenarios:

1)Purchase_Casio_GShock

2)Purchase_WhiteOpticalKeyboard


Steps:

1)Navigate to Item’s Page

2)Validate the price

3)Click Buy It Now button

4)On the SignIn page, click Continue as a guest

5)Fill Shipping Info

6)Validate Subtotal price

7) Click Continue button

8) Validate Total price



Running the Tests:

1)Tests without Facade Design Pattern

Download Zip and run EbayPurchase_without_PurchaseFaceade_Tests.cs

2)Tests with Facade Design Pattern

Download Zip and run EbayPurchase_Facade_Tests.cs

The classes and objects participating in this pattern are:

Facade – Holds methods that combine actions executed on multiple pages.

Page Objects (ItemPage)- Holds the actions that can be performed on the 
page like Search and Navigate. Exposes an easy access to the Page Validator
though the Validate() method. The best implementations of the pattern hide 
the usage of the Element Map, wrapping it through all action methods.

UI Tests (EbayPurchaseTests) – This class contains a group of tests related
to the above facade; it can hold only a single instance of the facade.



