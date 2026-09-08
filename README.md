# C# Basics & Task Solutions

This repository contains the implementation of the basic C# concepts task. The project is organized as a reusable class library with a console entry point to keep the code modular and clean.

## Project Structure

All source code is located inside the `src/` directory to maintain a standard repository layout:

- `src/TaskMethodsLibrary.cs`: Contains the implementation of all required methods and algorithm tasks.
- `src/Program.cs`: Acts as the execution layer to run and test the functions. It also contains the answers and explanations for the theoretical and MCQ questions written directly as code comments.

## Design Decisions

- **Class Library Architecture**: Organised all task solutions into a dedicated `TaskMethodsLibrary` class containing static methods, rather than dumping all logic inside `Program.cs`. Even though it wasn't explicitly requested, this architecture was chosen to promote code reusability, maintainability, and clean separation of concerns between business logic and the execution layer.
- **Error Handling**: Implemented `int.TryParse` across methods that require user input instead of `try-catch` blocks to prevent exception overhead and improve performance.
- **Reference vs Value Types**: Demonstrated memory allocation differences using `StringBuilder` for mutable reference types and standard primitives for value types.

## How to Run

1. Open the solution in Visual Studio or your preferred IDE.
2. Build the project using `dotnet build`.
3. Run the application using `dotnet run`.
