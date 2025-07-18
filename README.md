# CleanArchitecture-in-.NET

This project demonstrates how to implement Clean Architecture in an ASP.NET Core Web API application. It separates concerns using a layered structure and follows best practices for scalable, maintainable, and testable code.

---

## Folders & Files

| Path                  | Description                                                                 |
|------------------------|-----------------------------------------------------------------------------|
| `Application/`         | Contains application logic, use cases, and service interfaces               |
| `Core/`                | Domain layer – includes core business models and domain rules               |
| `Infrastructure/`      | Infrastructure concerns – data access, external service integrations        |
| `WebAPI/`              | ASP.NET Core API layer – controllers, DTOs, middleware, and startup config  |
| `README.md`            | Project documentation                                                       |
| `CleanArchitecture.sln`| Solution file to manage all projects                                        |

This layout helps enforce a **decoupled, testable, and maintainable architecture** across the entire application lifecycle.

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
