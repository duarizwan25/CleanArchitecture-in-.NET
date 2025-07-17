# CleanArchitecture-in-.NET

This project demonstrates how to implement Clean Architecture in an ASP.NET Core Web API application. It separates concerns using a layered structure and follows best practices for scalable, maintainable, and testable code.

---

## Project Structure

CleanArchitecture/
├── Application/ # Application logic (UseCases, Interfaces)
├── Core/ # Domain entities and core business logic
├── Infrastructure/ # Infrastructure services (e.g., Data access, APIs)
├── WebAPI/ # ASP.NET Core API layer (Controllers, DTOs)
├── README.md # This file
└── CleanArchitecture.sln

---

## Key Concepts

- **Clean Architecture**: Organizes code in concentric layers with dependencies pointing inward.
- **Separation of Concerns**: UI, Business Logic, and Data Access are separated.
- **Dependency Inversion**: Higher-level modules are not dependent on lower-level modules.

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- Visual Studio or VS Code
- SQL Server (if database is used)
