# Unexpected Behavior with Mutable Variables in F#

This repository demonstrates a common pitfall in F# programming involving mutable variables.  The issue arises when attempting to modify mutable variables within a context where mutability is not explicitly allowed or expected.

The `bug.fs` file contains code that showcases this issue. The `bugSolution.fs` file provides the corrected version.  The problem is subtle and can lead to difficult-to-debug issues, especially in larger codebases.

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` in an F# environment (e.g., Visual Studio, Ionide).
3. Observe the unexpected output or compile-time error.
4. Compare the code in `bug.fs` with `bugSolution.fs` to understand the correction.