# Bookstore Management System

This project is a **Bookstore Management System** built with **ASP.NET Core MVC**. It allows users to manage books through Create, Read, Update, and Delete (CRUD) operations. The application uses **Entity Framework Core** for data access and SQL Server for database storage. Users can manage books with details such as title, author, price, and genre, with form validation for input data.

## Features
- List all books
- Add new books
- Edit book details
- Delete books
- View book details
- Form validation for book creation and editing
- Search books by title or author (stretch goal)

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (or another IDE that supports ASP.NET Core development)

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Razor Views

## Setup Instructions

### 1. Clone the Repository
```
git clone https://github.com/your-username/bookstore-mvc.git
cd bookstore-mvc
```

### 2. Install Required Packages

Make sure to install the following NuGet packages for your project:

```
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
Install-Package Microsoft.EntityFrameworkCore.Design
```

### 3. Configure the Database
In the appsettings.json file, configure your SQL Server connection string:
```
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BookstoreDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
You may replace (localdb)\\mssqllocaldb with your SQL Server instance.

### 4. Migrate and Seed the Database
Run the following commands to apply migrations and seed data into the database:
```
# Add migration (if needed)
dotnet ef migrations add InitialCreate

# Apply migration to the database
dotnet ef database update
```
### 5. Run the Application
In Visual Studio or your preferred IDE, press F5 or run the following command to launch the application:
```
dotnet run
```
## Using the Application

### Book Management (CRUD)

- **Home Page (Index)**: Displays a list of all books in the database.
- **Create Book**: Navigate to `/Books/Create` to add a new book to the database. A form will be presented for you to input the title, author, price, and genre. Form validation is implemented.
- **Edit Book**: Navigate to `/Books/Edit/{id}` to update details of an existing book. The same validation rules apply.
- **Delete Book**: Navigate to `/Books/Delete/{id}` to remove a book. You will be prompted for confirmation before deletion.
- **View Book Details**: Navigate to `/Books/Details/{id}` to view detailed information about a specific book.
