# MyFirstApi — ASP.NET Core REST API

A clean, fully functional **RESTful API** built with **ASP.NET Core** and **MySQL** using Entity Framework Core. Designed as the backend service for a full-stack data management application — featuring complete CRUD operations, search functionality, and cross-origin support for React frontend integration.

---

## 🚀 Features

| Feature | Description |
|---|---|
| **RESTful API** | Standard HTTP methods — GET, POST, PUT, DELETE |
| **Full CRUD** | Create, Read, Update, Delete records in MySQL |
| **Search** | Filter results by name, message, or address |
| **Swagger UI** | Built-in interactive API documentation & testing tool |
| **Dual-Backend Ready** | Identical endpoint contract matches Node.js version — interchangeable service layers |
| **CORS Enabled** | Configured to accept requests from React frontend |
| **Auto-Create Database** | EF Core can initialise schema on first run |

---

## 🛠️ Tech Stack

| Technology | Details |
|---|---|
| **Framework** | ASP.NET Core 8.0 |
| **Language** | C# |
| **ORM** | Entity Framework Core 8 |
| **Database** | MySQL / MariaDB |
| **API Documentation** | Swagger / OpenAI |
| **Pattern** | RESTful API — JSON responses, standard HTTP status codes |

---

## 📂 Project Structure
| File / Folder | Purpose |
|---|---|
| **`MyFirstApi/`** | Root project directory |
| ├── `Controllers/GreetingsController.cs` | API endpoints — GET / POST / PUT / DELETE |
| ├── `Models/GreetingItem.cs` | Data model — Id, Name, Age, Address, Message, CreatedAt |
| ├── `Data/AppDbContext.cs` | Database context & Entity Framework configuration |
| ├── `Program.cs` | Application startup — DI, CORS, routing, middleware setup |
| ├── `appsettings.json` | Connection strings & environment configuration |
| └── `README.md` | Project documentation & setup guide |

## 🔌 API Endpoints

Base URL: `http://localhost:5078/api/Greetings`

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/Greetings` | Get all records |
| `GET` | `/api/Greetings?search={term}` | Search by name, message, or address |
| `POST` | `/api/Greetings` | Create new record — send JSON body |
| `PUT` | `/api/Greetings/{id}` | Update existing record by ID |
| `DELETE` | `/api/Greetings/{id}` | Remove record by ID |



## ⚙️ Setup & Run — Step by Step
# Prerequisites
   - .NET 8.0 SDK or later
   - MySQL Server (local or remote)
   - Visual Studio 2022 / VS Code
# Configure Database Connection
  - Update appsettings.json:
    json
     {
        "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=MyFirstDb;User=root;Password=YourPassword;"
      }
    }
# Restore Dependencies
   - dotnet restore
# Build & Run
   - bash
   - dotnet build
   - dotnet run
#  Access Swagger UI
   Once running, open in browser:

- http://localhost:5078/swagger
→ Interactive page to test every endpoint directly
##  Frontend Integration
CORS is pre-configured — React at http://localhost:3000 can connect without errors.

## 🧠 Key Design Decisions
Separate Model Class	Single source of truth — shared across API, DB, and frontend contract
EF Core + MySQL	Clean, strongly-typed data access — LINQ replaces raw SQL where possible
CORS Policy	AllowAnyOrigin in development — enables seamless frontend ↔ backend communication
Search via Query String	Lightweight, REST-standard filtering — no request body needed for GET
Dual-Backend Compatible	Identical routes and JSON format to Node.js version → frontend can switch without code changes

## 🤝 Related Projects

- Node.js Backend	github.com/kp003919/nodejs-api
- React Frontend	github.com/kp003919/react-frontend
- Portfolio	github.com/kp003919/muhsin-portfolio

## 👤 About
Built as part of a full-stack learning project — demonstrating end-to-end system design, REST API principles, and database integration. Focused on clean code, standard conventions, and interoperability between different backend technologies.
Muhsin Atto
- 📧 darenhaji@gmail.com
- 🔗 linkedin.com/in/muhsin-atto
- 💻 github.com/kp003919
