# EventEaseBookingSystem

## Overview

**EventEaseBookingSystem** is a web-based application developed using **ASP.NET Core MVC**, **Entity Framework Core**, and **Azure SQL Database**. The system enables users to view venues, create and manage events, and handle bookings efficiently through an intuitive web interface.

This project was created as part of a **Portfolio of Evidence (PoE)** to demonstrate full-stack web development skills, secure authentication with **ASP.NET Identity**, database CRUD operations, and cloud deployment on **Microsoft Azure**.

## Features

- User authentication and authorization (register, login, and role-based access)
- Venue management (add, edit, delete, list)
- Event management linked to venues
- Booking system with date and availability checks
- Data validation on forms
- Responsive user interface
- Deployment to Azure App Service with connected Azure SQL Database

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Identity
- Azure SQL Database
- Azure App Service
- C#
- HTML5, CSS3, Razor Views

## Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/yourusername/EventEaseBookingSystem.git
Open in Visual Studio

Open the .sln file in Visual Studio 2022 or newer.

Configure the database

Update the connection string in appsettings.json to point to your local or Azure SQL Database.

Apply migrations

Run the following in the Package Manager Console:

bash
Copy
Edit
Update-Database
Run the application

Press F5 or use:

bash
Copy
Edit
dotnet run
Deployment
The system is designed to be deployed to Azure App Service:

Publish directly from Visual Studio using the Publish Wizard.

Ensure your SQL Database is accessible and connection strings are updated in the Azure Portal.

Project Structure
graphql
Copy
Edit
EventEaseBookingSystem/
├── Controllers/          # MVC controllers for Events, Venues, Bookings
├── Models/               # Entity Framework models
├── Views/                # Razor views for UI
├── Data/                 # ApplicationDbContext and Migrations
├── wwwroot/              # Static files (CSS, JS)
├── appsettings.json      # Configuration
└── Program.cs            # Application entry point
References
Below are key resources and references used to guide the development of this project:

Microsoft Docs. (2024). ASP.NET Core MVC overview.

Microsoft Docs. (2024). ASP.NET Core Identity.

Microsoft Docs. (2024). Entity Framework Core.

Microsoft Azure. (2024). Host a web app with Azure App Service.

Esposito, D. (2020). Programming ASP.NET Core. Microsoft Press.

Rahman, M. A. (2017). ASP.NET Core MVC & Entity Framework Core Bootcamp. Packt Publishing.

License
This project is part of a Portfolio of Evidence submission and is for educational purposes only.

Author
Developed by Kyle Pillay
