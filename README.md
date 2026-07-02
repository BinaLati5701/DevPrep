# DevPrep

DevPrep is an ASP.NET Core Web API project created to practice and demonstrate backend development skills commonly required in software engineering interviews.

The project follows clean architecture principles and is being built incrementally, with each feature added, tested, and documented.

## Technologies

- C#
- ASP.NET Core Web API
- .NET 6
- Swagger / OpenAPI
- xUnit
- Git
- GitHub
- Visual Studio 2022

## Current Features

- REST API endpoint for Accounts
- Swagger documentation
- Unit tests for the Accounts endpoint
- Strongly typed models
- Clean project structure

## Running the Application

1. Open the solution in Visual Studio 2022.
2. Set **DevPrep.Api** as the startup project.
3. Press **F5** or click **Start**.

Swagger opens automatically.

## Swagger

After the application starts, open:

```
https://localhost:7037/swagger
```

### Test the Accounts endpoint

1. Expand **GET /api/Accounts**
2. Click **Try it out**
3. Click **Execute**

Expected response:

```json
[
  {
    "id": 1,
    "accountNumber": "100001",
    "accountType": "Checking",
    "balance": 1250.75,
    "isActive": true
  }
]
```

## Running Unit Tests

1. Open **Test Explorer**.
2. Select **Run All Tests**.

Current test coverage:

- AccountsController.GetAccounts()

## Planned Features

- SQL Server database
- Entity Framework Core
- Repository pattern
- Service layer
- Dependency Injection
- CRUD operations
- Validation
- Global exception handling
- Logging
- Authentication & Authorization (JWT)
- Integration tests
- CI/CD pipeline
- Docker support

## Project Status

 This project is actively being developed as part of my backend engineering interview preparation. New features will be added incrementally following professional development practices.