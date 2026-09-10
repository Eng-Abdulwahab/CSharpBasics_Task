# C# Basics & Algorithmic Problem Solving

A structured collection of C# console applications demonstrating core language mechanics, data structure manipulations, and defensive programming practices.

## Project Structure

```text
├── src/
│   ├── CSharpBasics_Task.csproj     # Project setup and .NET properties
│   ├── Program.cs                   # Entry point & execution flow dispatcher
│   └── TaskMethodsLibrary.cs        # Core algorithms & problem solutions
├── CSharpBasics_Task.sln           # Visual Studio solution file
├── .gitignore                       # Ignored build files (bin/obj)
└── README.md                        # Project documentation
```

## Key Technical Highlights & Edge Case Handling

- **Safe Input Parsing & Validation:** All user inputs are guarded using `int.TryParse` within validation loops to enforce type safety and guarantee zero unhandled runtime exceptions (`FormatException` / `OverflowException`).
- **Zero-Division Avoidance in Geometric Logic:** Solved point collinearity using standard cross-multiplication:
  (y_2 - y_1) / (x_3 - x_2) == (y_3 - y_2) / (x_2 - x_1)
  This bypasses floating-point precision issues and completely eliminates potential `DivideByZeroException` bugs.
- **Array & String Manipulations:**
  - Sub-array distance evaluation using position tracking algorithms.
  - Implemented string reversing and parsing techniques cleanly.
  - Memory-efficient string constructions using `StringBuilder` where appropriate.
- **Matrix & Multidimensional Processing:** Matrix operations handled with direct nested iteration to maintain $O(N \times M)$ efficiency.
- **UI & CLI Presentation:** Terminal layout, user cues, and output formatting were refined with AI assistance to ensure clean CLI presentation.

## Core Concepts Covered

- Defensive Programming & Exception Prevention
- Algorithm optimization & Linear algebraic operations
- Control flow & Data validation strategies
