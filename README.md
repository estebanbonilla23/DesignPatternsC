# Design Patterns in C# (.NET)
This project is a collection of examples demonstrating key software design patterns implemented in C# using .NET.  
Each pattern is isolated and explained through simple, testable code.

---

## ✅ Implemented Patterns

### 1. Repository Pattern (Mocked DB)
Abstracts data access, simulating a data source using an in-memory list with random values.

**Key Components:**
- `IRepository<T>`: Generic repository interface
- `User`: Simple model/entity
- `UserRepositoryMock`: Mock implementation simulating database access
- `PrintList<T>()`: Generic method to display entity data in the console


### 2. Fluent Builder Pattern
Variation of the Builder Pattern that allows the construction of complex objects using a chained method syntax (fluent interface). It is particularly useful when a class has many optional properties or configurations, as it improves readability and avoids the need for multiple constructors or overloads.

**Key Components:**
- Cleaner and more readable code.
- Enhances understanding of the object construction process.
- Supports step-by-step configuration of complex or immutable objects.

