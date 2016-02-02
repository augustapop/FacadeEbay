# FacadeEbay

The primary goal of the below tests is going to be to purchase different items from Ebay


The classes and objects participating in this pattern are:

Facade – Holds methods that combine actions executed on multiple pages.
Page Objects (ItemPage)- Holds the actions that can be performed on the 
page like Search and Navigate. Exposes an easy access to the Page Validator
though the Validate() method. The best implementations of the pattern hide 
the usage of the Element Map, wrapping it through all action methods.
UI Tests (EbayPurchaseTests) – This class contains a group of tests related
to the above facade; it can hold only a single instance of the facade.
