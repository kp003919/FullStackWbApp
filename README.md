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

MyFirstApi/
├── Controllers/
│ └── GreetingsController.cs # API endpoints — GET/POST/PUT/DELETE
├── Models/
│ └── GreetingItem.cs # Data model — Id, Name, Age, Address, Message, CreatedAt
├── Data/
│ └── AppDbContext.cs # Database context & EF configuration
├── Program.cs # App startup, DI, CORS, routing config
├── appsettings.json # Connection strings & environment settings
└── README.md

## 🔌 API Endpoints

Base URL: `http://localhost:5078/api/Greetings`

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/Greetings` | Get all records |
| `GET` | `/api/Greetings?search={term}` | Search by name, message, or address |
| `POST` | `/api/Greetings` | Create new record — send JSON body |
| `PUT` | `/api/Greetings/{id}` | Update existing record by ID |
| `DELETE` | `/api/Greetings/{id}` | Remove record by ID |

### Example — POST Request Body
```json
{
  "name": "Muhsin",
  "age": 42,
  "address": "Sheffield, UK",
  "message": "Building full-stack systems"
}
Example — Success Response
json
{
  "id": 1,
  "name": "Muhsin",
  "age": 42,
  "address": "Sheffield, UK",
  "message": "Building full-stack systems",
  "createdAt": "2026-10-07T09:30:00Z"
}
⚙️ Setup & Run — Step by Step
1. Prerequisites
.NET 8.0 SDK or later
MySQL Server (local or remote)
Visual Studio 2022 / VS Code
2. Configure Database Connection
Update appsettings.json:
json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyFirstDb;User=root;Password=YourPassword;"
  }
}
3. Restore Dependencies
bash
dotnet restore
4. Build & Run
bash
dotnet build
dotnet run
5. Access Swagger UI
Once running, open in browser:
plaintext
http://localhost:5078/swagger
→ Interactive page to test every endpoint directly ✅
6. Frontend Integration
CORS is pre-configured — React at http://localhost:3000 can connect without errors.
🧠 Key Design Decisions
Table
Choice	Reasoning
Separate Model Class	Single source of truth — shared across API, DB, and frontend contract
EF Core + MySQL	Clean, strongly-typed data access — LINQ replaces raw SQL where possible
CORS Policy	AllowAnyOrigin in development — enables seamless frontend ↔ backend communication
Search via Query String	Lightweight, REST-standard filtering — no request body needed for GET
Dual-Backend Compatible	Identical routes and JSON format to Node.js version → frontend can switch without code changes
🤝 Related Projects
Table
Project	Repository
Node.js Backend	github.com/kp003919/nodejs-api
React Frontend	github.com/kp003919/react-frontend
Portfolio	github.com/kp003919/muhsin-portfolio
👤 About
Built as part of a full-stack learning project — demonstrating end-to-end system design, REST API principles, and database integration. Focused on clean code, standard conventions, and interoperability between different backend technologies.
Muhsin Atto
📧 darenhaji@gmail.com
🔗 linkedin.com/in/muhsin-atto
💻 github.com/kp003919
