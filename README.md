# 🛍️ .NET 8 CRUD API - Product Management System

A complete **RESTful CRUD API** built with **.NET 8**, **Entity Framework Core**, **SQL Server**, and **Swagger UI** for managing products.

![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)
![Entity Framework](https://img.shields.io/badge/EF%20Core-8.0-green.svg)
![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-red.svg)
![Swagger](https://img.shields.io/badge/Swagger-UI-orange.svg)

## 🚀 Features

- ✅ **CREATE** - Add new products
- ✅ **READ** - Get all products or single product
- ✅ **UPDATE** - Modify existing products  
- ✅ **DELETE** - Remove products
- ✅ **Swagger UI** - Interactive API documentation
- ✅ **Error Handling** - Comprehensive error responses
- ✅ **Structured Responses** - Consistent JSON format
- ✅ **Entity Framework Core** - Code-first approach
- ✅ **SQL Server** - Database integration

## 🛠️ Tech Stack

- **Framework:** .NET 8 Web API
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **Documentation:** Swagger/OpenAPI
- **Language:** C#

## 📁 Project Structure

```
CrudDemo/
├── Controllers/
│ └── ProductsController.cs # API endpoints
├── Data/
│ └── AppDbContext.cs # Database context
├── Models/
│ └── Product.cs # Product entity
├── Migrations/ # EF Core migrations
├── Program.cs # App configuration
├── screenshots/ # API testing screenshots
└── README.md
```

## 🚀 Getting Started

### Prerequisites
- **.NET 8 SDK**
- **SQL Server** (LocalDB or full version)
-  **SSMS** (SQL SERVER MANAGEMENT STUDIO)
- **Visual Studio** or **VS Code**

### Installation

1. **Clone the repository:**
```bash
git clone https://github.com/YOUR_USERNAME/dotnet-crud-api.git
cd dotnet-crud-api
```

2. **Restore dependencies:**
```
dotnet restore
```
3. **Update database connection string in appsettings.json:**

```
   {
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CrudDemoDB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```




