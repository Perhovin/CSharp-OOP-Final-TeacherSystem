# Teacher Management System

A comprehensive C# console application built as a final challenge to consolidate core Object-Oriented Programming (OOP) concepts. It acts as an interactive system to manage a list of teachers, demonstrating the integration of classes, lists, methods, and user input.

## Features
* **Interactive UI (Menu):** Implements a `while` loop and a `switch` statement to create a continuous, interactive console menu for the user.
* **Encapsulation & Validation:** The `Teacher` class utilizes private fields and public properties with logic to prevent invalid data (e.g., preventing empty subjects or negative years of experience).
* **Collections (`List<T>`):** Uses `List<Teacher>` to dynamically store and manage multiple objects in memory.
* **Modular Methods:** The logic is separated from the `Main` method into distinct, focused functions (`AddTeacher`, `ShowTeachers`, `CountTeachers`, `AVGyears`) for cleaner, more maintainable code.
* **Data Processing:** Iterates through object collections using `foreach` loops to calculate business logic, such as finding the total number of teachers and computing the average years of experience.

## What I learned in this project
* How to combine multiple OOP concepts (classes, constructors, encapsulation) into a single, fully functional application.
* How to build an interactive console loop that keeps the program running until the user explicitly chooses to exit.
* The importance of organizing code into separate static methods rather than writing everything inside the `Main` block.
* How to calculate aggregate data (like averages) from properties of objects stored in a generic List.
