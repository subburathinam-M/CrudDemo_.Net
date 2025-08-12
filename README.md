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
4. **Apply database migrations:**

```
dotnet ef database update
```
5. **Run the application:**

```
dotnet run
```

6. **Access the application:**
``` API Base URL: http://localhost:5004 ```
``` Swagger UI: http://localhost:5004/swagger ```
``` Swagger JSON: http://localhost:5004/swagger/v1/swagger.json1 ```














```markdown
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
│   └── ProductsController.cs      # API endpoints
├── Data/
│   └── AppDbContext.cs           # Database context
├── Models/
│   └── Product.cs                # Product entity
├── Migrations/                   # EF Core migrations
├── Program.cs                    # App configuration
├── screenshots/                  # API testing screenshots
└── README.md
```

## 🚀 Getting Started

### Prerequisites
- **.NET 8 SDK**
- **SQL Server** (LocalDB or full version)
- **Visual Studio** or **VS Code**

### Installation

1. **Clone the repository:**
```bash
git clone https://github.com/YOUR_USERNAME/dotnet-crud-api.git
cd dotnet-crud-api
```

2. **Restore dependencies:**
```bash
dotnet restore
```

3. **Update database connection string in `appsettings.json`:**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CrudDemoDB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

4. **Apply database migrations:**
```bash
dotnet ef database update
```

5. **Run the application:**
```bash
dotnet run
```

6. **Access the application:**
   - **API Base URL:** `http://localhost:5004`
   - **Swagger UI:** `http://localhost:5004/swagger`
   - **Swagger JSON:** `http://localhost:5004/swagger/v1/swagger.json`

## 📖 Swagger Documentation

This API includes **Swagger UI** for interactive documentation and testing:

- **Development Environment:** Swagger UI is available at `/swagger`
- **Interactive Testing:** Test all endpoints directly from the browser
- **API Schema:** Complete request/response documentation
- **Try It Out:** Execute API calls with real data

## 📋 API Endpoints

| Method | Endpoint | Description | Status Code |
|--------|----------|-------------|-------------|
| GET | `/api/products` | Get all products | 200 OK |
| GET | `/api/products/{id}` | Get product by ID | 200 OK / 404 Not Found |
| POST | `/api/products` | Create new product | 201 Created |
| PUT | `/api/products/{id}` | Update product | 200 OK / 404 Not Found |
| DELETE | `/api/products/{id}` | Delete product | 200 OK / 404 Not Found |

## 📝 API Usage Examples

### 1️⃣ Get All Products
```http
GET http://localhost:5004/api/products
```

**Response:**
```json
{
  "message": "Products retrieved successfully",
  "count": 2,
  "data": [
    {
      "id": 1,
      "name": "Laptop",
      "price": 50000.00
    },
    {
      "id": 2,
      "name": "Gaming Mouse",
      "price": 2500.00
    }
  ]
}
```

### 2️⃣ Get Single Product
```http
GET http://localhost:5004/api/products/1
```

**Response:**
```json
{
  "message": "Product retrieved successfully",
  "data": {
    "id": 1,
    "name": "Laptop",
    "price": 50000.00
  }
}
```

### 3️⃣ Create Product
```http
POST http://localhost:5004/api/products
Content-Type: application/json

{
  "name": "Gaming Mouse",
  "price": 2500.00
}
```

**Response:**
```json
{
  "message": "Product created successfully",
  "product": {
    "id": 3,
    "name": "Gaming Mouse",
    "price": 2500.00
  }
}
```

### 4️⃣ Update Product
```http
PUT http://localhost:5004/api/products/1
Content-Type: application/json

{
  "name": "Gaming Laptop",
  "price": 75000.00
}
```

**Response:**
```json
{
  "message": "Product updated successfully",
  "updatedProduct": {
    "id": 1,
    "name": "Gaming Laptop",
    "price": 75000.00
  }
}
```

### 5️⃣ Delete Product
```http
DELETE http://localhost:5004/api/products/1
```

**Response:**
```json
{
  "message": "Product deleted successfully",
  "deletedProduct": {
    "id": 1,
    "name": "Gaming Laptop",
    "price": 75000.00
  }
}
```

## 🗃️ Database Schema

```sql
Products Table:
┌─────┬──────────────┬─────────────────┬──────────┐
│ Col │ Name         │ Type            │ Nullable │
├─────┼──────────────┼─────────────────┼──────────┤
│ PK  │ Id           │ int             │ No       │
│     │ Name         │ nvarchar(max)   │ Yes      │
│     │ Price        │ decimal(18,2)   │ No       │
└─────┴──────────────┴─────────────────┴──────────┘
```

## 📸 Screenshots

### Swagger UI - API Documentation
![Swagger UI](screenshots/swagger-ui.png)

### API Testing with Postman

#### GET All Products
![GET All Products](screenshots/get-all-products.png)

#### POST Create Product
![Create Product](screenshots/create-product.png)

#### PUT Update Product
![Update Product](screenshots/update-product.png)

#### DELETE Product
![Delete Product](screenshots/delete-product.png)

## 🧪 Testing the API

### Option 1: Using Swagger UI (Recommended)
1. Run the application: `dotnet run`
2. Navigate to: `http://localhost:5004/swagger`
3. Click on any endpoint to expand
4. Click **"Try it out"**
5. Fill in the parameters/request body
6. Click **"Execute"**

### Option 2: Using Postman
1. Import the API collection
2. Set base URL: `http://localhost:5004`
3. Test each endpoint with sample data

### Option 3: Using cURL
```bash
# Get all products
curl -X GET "http://localhost:5004/api/products"

# Create a product
curl -X POST "http://localhost:5004/api/products" \
  -H "Content-Type: application/json" \
  -d '{"name":"Test Product","price":1000.00}'
```

## ⚙️ Configuration

### Adding Swagger to Your Project

```xml
<PackageReference Include="Swashbuckle.AspNetCore" Version="6.5.0" />
```

Configure in `Program.cs`:

```csharp
// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
```

## 🚀 Deployment

### Local Development
```bash
dotnet run
```

### Production Build
```bash
dotnet build --configuration Release
dotnet publish --configuration Release
```

## 🔧 Environment Variables

| Variable | Description | Default |
|----------|-------------|---------|
| `ASPNETCORE_ENVIRONMENT` | Environment (Development/Production) | Development |
| `ASPNETCORE_URLS` | Application URLs | http://localhost:5004 |
| `ConnectionStrings__DefaultConnection` | Database connection string | LocalDB |

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License.

## 👨‍💻 Author

**Your Name**
- GitHub: [@yourusername](https://github.com/yourusername)
- LinkedIn: [Your LinkedIn](https://linkedin.com/in/yourprofile)
- Email: your.email@example.com

## 🙏 Acknowledgments

- Built with .NET 8 and Entity Framework Core
- API documentation powered by Swagger/OpenAPI
- Inspired by modern REST API best practices
- Thanks to the .NET community

---

**⭐ If you found this project helpful, please give it a star!**
```

This README is formatted specifically for GitHub and includes:
- ✅ GitHub-specific markdown syntax
- ✅ Proper badges and shields
- ✅ Clear sections with emojis
- ✅ Code blocks with syntax highlighting
- ✅ Tables for better organization
- ✅ Screenshot placeholders
- ✅ Professional structure
- ✅ Complete API documentation
- ✅ Swagger integration details

Just copy and paste this into your `README.md` file in your GitHub repository!















