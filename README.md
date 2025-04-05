# 🎓 University Management System - OOPs Concepts Practical (C# .NET)

This project is a simple console-based **University Management System** that demonstrates all major **Object-Oriented Programming (OOP)** concepts in **C#** using a `.NET` Console Application.

---

## ✅ OOP Concepts Covered

| Concept              | Description |
|----------------------|-------------|
| **Inheritance**       | `Student` and `Professor` classes inherit from the abstract base class `Person`. |
| **Encapsulation**     | Properties like `Name`, `Age`, and `Address` use getters/setters with validation logic. |
| **Abstraction**       | `Person` is an abstract class that provides a blueprint and enforces implementation of `DisplayInfo()`. |
| **Interface**         | `IUniversityMember` interface ensures all university members implement `DisplayInfo()`. |
| **Method Overloading**| `Student.EnrollCourse()` is overloaded to accept both single and multiple courses. |
| **Method Overriding** | `Student` and `Professor` override the abstract `DisplayInfo()` method. |
| **Exception Handling**| Uses `try-catch` blocks and custom exception `CourseEnrollmentException`. |
| **Sealed Class**      | `UniversityRules` is a sealed class to prevent inheritance of university-wide rules. |

---

## 🏗 Project Structure

```
UniversityManagementSystem/
├── Program.cs                          // Main program logic and demonstration
├── Interfaces/
│   └── IUniversityMember.cs
├── Abstracts/
│   └── Person.cs
├── Models/
│   ├── Student.cs
│   └── Professor.cs
├── Exceptions/
│   └── CourseEnrollmentException.cs
├── Utilities/
│   └── UniversityRules.cs
```

---

## ▶ How to Run

1. Clone or download this repository.
2. Open the solution in **Visual Studio** or any C# IDE.
3. Set `Program.cs` as the startup file.
4. Press `Ctrl + F5` to run without debugging.
5. View output in the console.

---

## 🧪 Example Output

![image](https://github.com/user-attachments/assets/13ae1b4c-7b12-4998-ac65-9e6d9a24cde8)

---

## 💡 Purpose

This project is created as part of an OOP practical to understand and demonstrate the real-world implementation of all major object-oriented principles in C#.

---
