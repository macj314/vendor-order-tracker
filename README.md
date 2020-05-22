# _Vendor Order Tracker_

#### _Epicodus Project May 22, 2020_

#### By _**Jason Macie**_

## Description

_A project to introduce the C# language and the .NET Core framework with MVC and RESTful routing. A user is able to create and view vendors and their orders. Users will fill out forms to create vendors and then orders._

## Setup/Installation Requirements

### Install .NET Core

For Mac

1. Download .Net Core 2.2 SDK [v2.2.106](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer).
2. Run the installer and use the default settings it suggests.
3. Confirm the installation is successful by running: $ dotnet --version in your terminal.

For Windows

1. Download .Net Core 2.2 SDK [v2.2.203](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer).
2. Run the installer and use the default settings it suggests.
3. Verify installation by running: dotnet --version in your terminal.

Finally install the read only evaluation tool: dotnet script.
Run this command in your terminal: dotnet tool install -g dotnet-script

### Clone Repository

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
3. Run the program with the commands dotnet restore, dotnet build, and dotnet run.

## Known Bugs

There are no known bugs at the time of this update.
 
## Technologies Used

* C#
* .NET Core
* MSBuild
* ASP.Net Core
* MVC
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Users are presented with a homepage to navigate to a vendors page** | User Input:"Enter site" | Output: "Welcome to Vendor Order Tracker" |
| **Users can create a new vendor with a name and a description** | User Input:"Bakery", "Quaint and small" | Output: "Name: Bakery Description: Quaint and small" |
| **Users can create an order for a specific vendor. Each order should hold a title, description, price and date.** | User Input:"12 Croissants", "Fresh", 12, 5222020 | Output: "Title: 12 Criussants Description: Fresh Price: $12 Date: 5/22/2020" |


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jason Macie_**