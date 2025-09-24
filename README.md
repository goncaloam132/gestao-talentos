# IT Talent Management System

# Description

Complete talent management system for technology companies, developed in .NET 9 with 3-layer architecture. The system allows management of talents, job proposals, skills and average price reports.

# Architecture

The project is organized in 3 main layers:

- **DbLayer**: Data layer with Entity Framework Core and PostgreSQL
- **WebAPI**: REST API with .NET 9, JWT Authentication and Swagger
- **Frontend**: Web interface with Blazor Server and Bootstrap

# Technologies Used

# Backend
- .NET 9.0
- Entity Framework Core 9.0.3
- PostgreSQL (Npgsql)
- JWT Authentication
- Swagger/OpenAPI
- AutoMapper

# Frontend
- Blazor Server
- Bootstrap 5
- Blazored.LocalStorage
- HTTP Client

# Database
- PostgreSQL
- Entity Framework Core Migrations

# Project Structure

```
GestãoTalentos/
├── DbLayer/                    # Data Layer
│   ├── Context/               # DbContext and configurations
│   └── Models/                # Database entities
├── WebAPI/                    # REST API
│   ├── Controllers/           # API Controllers
│   ├── Services/              # Business services
│   ├── Repositories/          # Data repositories
│   ├── Interfaces/            # Contracts/Interfaces
│   └── DTOClasses/            # Data Transfer Objects
├── Frontend/                  # Web Interface
│   ├── Components/            # Blazor components
│   ├── Services/              # Frontend services
│   └── DtoClasses/            # Frontend DTOs
└── README.md
```

# Installation and Configuration

# Prerequisites

- .NET 9.0 SDK
- PostgreSQL 12+
- Visual Studio 2022 or VS Code

# 1. Clone the repository

```bash
git clone https://github.com/goncaloam132/gestao-talentos.git
cd gestao-talentos
```

# 2. Configure the database

1. Install and configure PostgreSQL
2. Create a database named `yourdatabase`
3. Configure the connection string in `WebAPI/appsettings.json`

# 3. Configure environment variables

1. Copy `WebAPI/appsettings.Example.json` to `WebAPI/appsettings.json`
2. Copy `environment.example` to `.env` (optional, for environment variables)
3. Configure the following variables:

**WebAPI/appsettings.json:**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=yourdatabase;Username=postgres;Password=YOUR_PASSWORD"
  },
  "Jwt": {
    "SecretKey": "YOUR_JWT_SECRET_KEY",
    "Issuer": "GestaoTalentosIT",
    "Audience": "gestao-talentos-api"
  }
}
```

**Frontend/appsettings.json:**
```json
{
  "ApiSettings": {
    "BaseUrl": "https://localhost:7070/"
  }
}
```

# 4. Run migrations

```bash
cd WebAPI
dotnet ef database update
```

# 5. Run the project

```bash
# Terminal 1 - API
cd WebAPI
dotnet run

# Terminal 2 - Frontend
cd Frontend
dotnet run
```

# Authentication

The system uses JWT (JSON Web Tokens) for authentication:

- **Login Endpoint**: `POST /api/auth/login`
- **User Registration**: `POST /api/auth/register`
- **User Types**: Admin, Client, Talent

# Main Features

# Talent Management
- Talent registration and profiles
- Skills and experience management
- Hourly rate definition
- Visibility control

# Proposal Management
- Job proposal creation
- Required skills association
- State management (Open, Closed, etc.)
- Average price reports

# Skills Management
- Skills categorization
- Experience levels
- Talent-skill association

# Reports
- Average prices by category
- Eligible talents for proposals
- Usage statistics

# Data Model

# Main Entities

- **Users**: Authentication and authorization system
- **Talents**: Professional profiles
- **Clients**: Hiring companies
- **Skills**: Technical competencies
- **JobProposals**: Work opportunities
- **Experiences**: Professional history

# API Endpoints

# Authentication
- `POST /api/auth/login` - Login
- `POST /api/auth/register` - Register

# Talents
- `GET /api/talento` - List talents
- `POST /api/talento` - Create talent
- `PUT /api/talento/{id}` - Update talent
- `DELETE /api/talento/{id}` - Delete talent

# Proposals
- `GET /api/propostatrabalho` - List proposals
- `POST /api/propostatrabalho` - Create proposal
- `PUT /api/propostatrabalho/{id}` - Update proposal

# Skills
- `GET /api/habilidade` - List skills
- `POST /api/habilidade` - Create skill

# Reports
- `GET /api/relatorio/preco-medio` - Average prices

# Testing

To run tests:

```bash
dotnet test
```

## API Documentation

Interactive API documentation is available through Swagger:

- **Development**: `https://localhost:7070/swagger`
- **Production**: `https://your-domain.com/swagger`

# Deploy

# Development
```bash
dotnet run --project WebAPI
dotnet run --project Frontend
```

# Production
```bash
dotnet publish -c Release
```

# Security

- Passwords hashed with SHA-512
- JWT with configurable secret key
- Input validation on all endpoints
- CORS properly configured

## Contributing

1. Fork the project
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is under the MIT license. See the `LICENSE` file for more details.

## Authors

- **Gonçalo Amorim** - [GitHub](https://github.com/goncaloam132)

