
# Web Automation C# Project

## Description

Fully functional web automation framework written in C# using the NUnit testing framework automating Parabank from Parasoft!


## Overview

**WebAutomationNUnit** is a web automation testing framework built with [NUnit](https://docs.nunit.org/) and [Selenium](https://www.selenium.dev/).  
It follows the **Page Object Model (POM)** design pattern to keep test cases clean, reusable, and easy to maintain.  

The framework is designed to:  
- Automate end-to-end web UI tests.  
- Provide detailed, interactive test reports with [Allure](https://allurereport.org/).  
- Support scalability for adding new test cases and page components.  
- Run locally or be integrated into CI/CD pipelines (e.g., GitHub Actions, Jenkins).  

This project is ideal for:  
- Demonstrating automation skills in a portfolio project.
- QA engineers learning automation with Python.  
- Teams needing a structured, maintainable Selenium + NUnit setup.## Tech Stack

**Language & Frameworks:**  
- Language: .NET 9.0+  
- Test Framework: NUnit
- Web Driver: Selenium
- Test Reporting: Allure

**Tools & Utilities:**  
- Browser Driver: ChromeDriver
- Version Control: Git/Github
- IDE: Rider
## Table of Contents

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running Tests](#running-tests)
- [Live Tests](#live-tests)
- [Project Structure](#project-structure)
## Prerequisites

Before installing, make sure you have the following:
- .NET SDK (latest LTS version recommended)
- Allure commandline (for generating and viewing reports)
- An IDE or code editor of your choice:
    - Rider 
    - Visual Studio (with NUnit test adapter extension)
    - VS Code (with required extensions)

To verify installation:
```bash
dotnet --version
allure --version
```
> [!NOTE]
> If Allure is not recognized as a command, you may need to add it to your system PATH.

## Installation

Clone the repository:
```bash
git clone https://github.com/noah-jones-dev/WebAutomationNUnit.git
cd WebAutomationNUnit
```
### Dependencies

This project uses the following NuGet packages:
- NUnit - Test framework
- Selenium.WebDriver – Browser automation
- Selenium.Support - Additional Selenium helpers
- Allure.NUnit - Allure reporting integration

Dependencies are defined in the .csproj file. To install/restore them, run:
```bash
dotnet restore
```
To add new dependencies manually, use:
```bash
dotnet add package <PackageName>
```
Example:
```bash
dotnet add package Selenium.WebDriver
```

## Running Tests

### To run tests, run the following commands:

Run all tests
```bash
  dotnet test
```
Run all tests and save Allure results:
```bash
dotnet test --results-directory Reports/Results --logger "trx"
```
Generate and view the report:
```bash
allure serve Reports/Results
```
Export the report to share:
```bash
allure generate Reports/Results -o Reports/Report --clean
allure open Reports/Report
```



## Live Tests

![LoginExistingUser](https://github.com/user-attachments/assets/7ad0623e-3ec4-4d83-bc9d-2fa1e7a15c23)

![NewUserTransferFunds](https://github.com/user-attachments/assets/8c6f471b-7b82-45c7-89bd-0bd8e3df5ffd)

![NewUserViewAccountsSummary](https://github.com/user-attachments/assets/23fe6bab-77bc-41ae-a645-7fddbcea93d6)

![RegisterNewUserTest](https://github.com/user-attachments/assets/12bc10f8-ebe1-4829-82d9-5d49d20592f5)

## Project Structure

- [Configuration](./Configuration) – Contains setup and configuration files for environments, browsers, and driver management.  
    - [BrowserTypes.cs](./Configuration/BrowserTypes.cs) – Enum of supported browser types (e.g., Chrome, Firefox).  
    - [Environments](./Configuration/Environments) – Holds environment-specific configuration such as base URLs and driver setup.  
    - [MenuTypes.cs](./Configuration/MenuTypes.cs) – Enum for different menu navigation options.  
    - [WebDriverFactory.cs](./Configuration/WebDriverFactory.cs) – Factory class responsible for creating and configuring WebDriver instances.  
- [Framework](./Framework) – Core framework components that support reusable automation features.  
    - [Fields](./Framework/Fields) – Encapsulates different types of web elements and their interactions.  
        - [BaseField.cs](./Framework/Fields/BaseField.cs) – Base class for all field types with common functionality.  
        - [ButtonField.cs](./Framework/Fields/ButtonField.cs) – Wrapper for button elements.  
        - [CheckboxField.cs](./Framework/Fields/CheckboxField.cs) – Wrapper for checkbox elements.  
        - [LinkField.cs](./Framework/Fields/LinkField.cs) – Wrapper for clickable link elements.  
        - [SelectField.cs](./Framework/Fields/SelectField.cs) – Wrapper for dropdown and select elements.  
        - [StaticField.cs](./Framework/Fields/StaticField.cs) – Wrapper for static text elements.  
        - [TableField.cs](./Framework/Fields/TableField.cs) – Wrapper for tables and table cells.  
        - [TextField.cs](./Framework/Fields/TextField.cs) – Wrapper for input text fields.  
    - [Helpers](./Framework/Helpers) – Utility classes for handling waits and window operations.  
        - [Waits.cs](./Framework/Helpers/Waits.cs) – Provides explicit wait conditions.  
        - [WindowUtilities.cs](./Framework/Helpers/WindowUtilities.cs) – Handles multiple window or tab interactions.  
    - [Verifications](./Framework/Verifications) – Classes for verifying UI element states and properties.  
        - [VerifyBase.cs](./Framework/Verifications/VerifyBase.cs) – Base verification logic.  
        - [VerifyButton.cs](./Framework/Verifications/VerifyButton.cs) – Verifications for button elements.  
        - [VerifyCheckbox.cs](./Framework/Verifications/VerifyCheckbox.cs) – Verifications for checkbox elements.  
        - [VerifyLink.cs](./Framework/Verifications/VerifyLink.cs) – Verifications for links.  
        - [VerifySelect.cs](./Framework/Verifications/VerifySelect.cs) – Verifications for dropdown/select elements.  
        - [VerifyStatic.cs](./Framework/Verifications/VerifyStatic.cs) – Verifications for static text.  
        - [VerifyTableCell.cs](./Framework/Verifications/VerifyTableCell.cs) – Verifications for table cell values.  
        - [VerifyText.cs](./Framework/Verifications/VerifyText.cs) – Verifications for text input fields.  
- [Pages](./Pages) – Page Object Models (POM) representing the application’s UI pages.  
    - [AccountDetailsPage.cs](./Pages/AccountDetailsPage.cs) – Represents the account details page.  
    - [AccountsOverviewPage.cs](./Pages/AccountsOverviewPage.cs) – Represents the accounts overview page with account list.  
    - [BasePage.cs](./Pages/BasePage.cs) – Base class for common page functionality.  
    - [BillPayPage.cs](./Pages/BillPayPage.cs) – Represents the bill payment page.  
    - [HomePage.cs](./Pages/HomePage.cs) – Represents the home/landing page.  
    - [LoginPage.cs](./Pages/LoginPage.cs) – Represents the login page.  
    - [MenuPage.cs](./Pages/MenuPage.cs) – Represents the navigation menu.  
    - [OpenNewAccountPage.cs](./Pages/OpenNewAccountPage.cs) – Represents the new account creation page.  
    - [TransferCompletePage.cs](./Pages/TransferCompletePage.cs) – Represents the confirmation page after transfer.  
    - [TransferFundsPage.cs](./Pages/TransferFundsPage.cs) – Represents the transfer funds page.  
    - [WelcomePage.cs](./Pages/WelcomePage.cs) – Represents the welcome page after login/registration.  
- [Reports](./Reports) – Directory for storing test results and reports.  
    - [Report](./Reports/Report) – Generated Allure report files.  
    - [Results](./Reports/Results) – Raw test execution results.  
- [Tests](./Tests) – NUnit test suites organized by feature.  
    - [AccountOverviewFeature](./Tests/AccountOverviewFeature) – Tests related to viewing account overviews.  
        - [ViewAccountsOverview.cs](./Tests/AccountOverviewFeature/ViewAccountsOverview.cs) – Test for viewing the accounts overview page.  
    - [LoginFeature](./Tests/LoginFeature) – Tests related to login and registration.  
        - [LoginExistingUser.cs](./Tests/LoginFeature/LoginExistingUser.cs) – Test for logging in with an existing user.  
        - [RegisterNewUser.cs](./Tests/LoginFeature/RegisterNewUser.cs) – Test for registering a new user.  
    - [TransferFundsFeature](./Tests/TransferFundsFeature) – Tests related to transferring funds.  
        - [TransferFundsWithNewAccount.cs](./Tests/TransferFundsFeature/TransferFundsWithNewAccount.cs) – Test for transferring funds using a newly created account.  
