# C# Basics & Algorithmic Problem Solving

A structured collection of C# console applications demonstrating core language mechanics, data structure manipulations, and defensive programming practices.

## Key Technical Highlights & Edge Case Handling

- **Safe Input Parsing & Validation:** All user inputs are guarded using `int.TryParse` within validation loops to enforce type safety and guarantee zero unhandled runtime exceptions (`FormatException` / `OverflowException`).
- **Zero-Division Avoidance in Geometric Logic:** Solved point collinearity using standard cross-multiplication:
  $$ (y_2 - y_1) \times (x_3 - x_2) == (y_3 - y_2) \times (x_2 - x_1) $$
  This bypasses floating-point precision issues and completely eliminates potential `DivideByZeroException` bugs.
- **Array & String Manipulations:**
  - Sub-array distance evaluation using position tracking algorithms.
  - Implemented string reversing and parsing techniques cleanly.
  - Memory-efficient string constructions using `StringBuilder` where appropriate.
- **Matrix & Multidimensional Processing:** Matrix operations handled with direct nested iteration to maintain $O(N \times M)$ efficiency.
- **UI & CLI Presentation:** Terminal layout, user cues, and output formatting were refined with AI assistance to ensure clean CLI presentation.

## Core Concepts Covered

- Defensive Programming & Exception Prevention
- Memory efficiency (`StringBuilder` vs String concatenation)
- Algorithm optimization & Linear algebraic operations
- Control flow & Data validation strategies
