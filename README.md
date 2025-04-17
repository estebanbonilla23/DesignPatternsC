# Design Patterns in C# (.NET)
This project is a collection of examples demonstrating key software design patterns implemented in C# using .NET.  
Each pattern is isolated and explained through simple, testable code.

---

## ✅ Implemented Patterns

### 1. Repository Pattern (Mocked DB)
**Location**: `Repositories/UserRepositoryMock.cs`  
**Purpose**: Abstracts data access, simulating a data source using an in-memory list with random values.

**Key Components:**
- `IRepository<T>`: Generic repository interface
- `User`: Simple model/entity
- `UserRepositoryMock`: Mock implementation simulating database access
- `PrintList<T>()`: Generic method to display entity data in the console