# items-dotnet-api

Welcome to the MyProject API! This project follows the Clean Architecture principles and is built with .NET Core.

> **NOTE: THIS PROJECT IS STILL IN PROGRESS**
> ~

## Prerequisites

Before getting started, ensure that you have the following installed on your machine:

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version X.X.X)
- [Docker](https://www.docker.com/) (optional, for containerization)

## Getting Started

To run the API locally, follow these steps:

1. Clone the repository:
```
   git clone git@github.com:mitsram/items-dotnet-api.git
```
2. Navigate to the project directory:
```
cd items-dotnet-api
```
4. Set up the database:
* Ensure you have a running instance of a compatible database (e.g., SQL Server, PostgreSQL).
* Open `src/Items.Infrastructure/appsettings.json` and update the DefaultConnection value with your database connection string.
5. Build the solution:
```
dotnet build
```
6. Run database migrations:
```
dotnet ef database update --project src/Items.Infrastructure
```
8. Launch the API:
```
dotnet run --project src/Items.API
```
9. (Optional) Containerization with Docker:
* Build the Docker image:
* Run the Docker container:
The API will be accessible at http://localhost:8080.

## Project Structure
The project follows the Clean Architecture pattern, organized into the following main folders:

* src/Items.API: The API layer responsible for handling HTTP requests and responses.
* src/Items.Application: The application layer containing business logic and use cases.
* src/Items.Domain: The domain layer containing entities, value objects, and domain services.
* src/Items.Infrastructure: The infrastructure layer providing data access, external service integrations, and cross-cutting concerns.

## Technologies Used
* ASP.NET Core X.X: Web framework for building APIs.
Entity Framework Core X.X: Object-relational mapper (ORM) for database access.
* Swagger UI: API documentation and testing tool.
* Docker: Containerization tool for creating lightweight, reproducible environments.
* Xunit: Testing framework for unit and integration tests.

## Contributing
Contributions are welcome! Please follow the contribution guidelines to contribute to this project.
