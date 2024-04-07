
# Asset Tracking

This project is an Asset Tracking database. It allows users to input data and prints out the user data. Asset Tracking is a way to keep track of company assets, like Laptops, 
Stationary computers, Phones, etc. All assets have an end of life which for simplicity reasons is 3 years.

## Level 1

The console app has classes and objects for different types of assets such as laptops and mobile phones. Each asset has properties like purchase date, price, model name, etc.

## Level 2

The program creates a list of assets based on user input. The final result is a sorted list of assets displayed on the console. The list is sorted primarily by class (computers first, then phones), 
and then by purchase date. Any item that is less than 3 months away from its end of life (3 years) is marked in red.

## Level 3

Offices have been added to the model. Assets can be placed in 3 different offices around the world, each using the appropriate currency for that country. 
The program allows for input values in dollars and converts them to each currency based on today's currency charts. When the list is displayed on the console, 
it is sorted first by office, then by purchase date. Items are marked in red if they are less than 3 months away from their end of life, and in yellow if they are less than 6 months away. 
Each item is displayed with the currency according to its country.

## File Explanations

### [Office](MiniProjects/Week14/Office.cs)

This file contains the `Office` class, which represents an office where assets are located. Each office has a location and a currency.

### [Asset](MiniProjects/Week14/Asset.cs)

This file contains the `Asset` class, which represents a company asset. Each asset has properties like brand, model name, purchase date, price, and office. 
The `Asset` class also contains methods to check if the asset is at its end of life and to convert the price to local currency.

### [Laptop](MiniPorjects/Week14/Laptop.cs)

This file contains the `Laptop` class, which represents a laptop. The `Laptop` class inherits from the `Asset` class and uses its properties and methods.

### [MobilePhone](MiniProjects/Week14/MobilePhone.cs)

This file contains the `MobilePhone` class, which represents a mobile phone. The `MobilePhone` class also inherits from the `Asset` class and uses its properties and methods.

### [Main](MiniProjects/Week14/Main.cs)

This file contains the `AssetManager` class, which is responsible for managing the assets. It contains methods to collect asset details from the user and to display the sorted list of assets. 
The `Main` method is the entry point of the application.
