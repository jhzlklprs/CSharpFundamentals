# 🛣️ C# Console Project Roadmap

> **Goal:** C# Fundamentals → OOP → SQL Server → ASP.NET Core → Real Business Systems → 🤖 JARVIS

This roadmap is designed to let you practice **without following tutorials**. Build each project yourself, then send your code for review.

---

## 📍 Current Position

You are currently studying **C# Fundamentals** and are at:

> **Generics ← YOU ARE HERE**

Continue your fundamentals study. Don't rush into the large projects yet.

---

## 🧭 How to Use This Roadmap

- **Try to build each project yourself** before asking for a solution.
- When stuck, ask about the **concept or problem**, rather than immediately requesting complete code.
- Keep projects small at first. Rebuild or improve them later as you learn more.
- When you finish a project, send the code for review.
- The review should focus on:
  - ✅ What's correct
  - ⚠️ What works but could be improved
  - ❌ What's incorrect
  - 💡 What C# concept you're missing
  - 🧠 Why your approach works or doesn't work
  - 🔧 How to improve it without simply replacing everything with a finished solution

---

# 🟢 Stage 0 — C# Fundamentals

### Concepts

```text
Variables
Data Types
Operators
if / else
switch
Loops
Methods
Arrays
Strings
Collections
Generics ← CURRENT
Exception Handling
File I/O
LINQ
OOP
```

### Tiny Practice Projects

Use these whenever you have free time:

- 🧮 Calculator
- 🌡️ Temperature Converter
- 🎯 Number Guessing Game
- 🎲 Dice Game
- 🔐 Simple Login
- 📊 Grade Calculator

These should be small exercises, not huge projects.

---

# 🟢 Stage 1 — Number Guessing Game

### Goal

Create a game like:

```text
===== NUMBER GUESSING GAME =====

I'm thinking of a number between 1 and 100.

Your guess: 50

Too high!

Your guess: 25

Too low!

Your guess: 37

Correct!

Attempts: 3
```

### Practice

- Variables
- `Random`
- `if / else`
- Loops
- Methods
- Input validation

### Rule

**Don't look up a tutorial.**

Try to solve the problem yourself.

---

# 🟢 Stage 2 — Simple Calculator

Create:

```text
===== CALCULATOR =====

1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Exit

Choose: 1

Enter first number: 25
Enter second number: 10

Result: 35
```

### Practice

- Methods
- Input/output
- Conditions
- Loops
- Validation

### Challenge

Don't put everything inside `Main()`.

Aim for something like:

```text
Main()
 ├── ShowMenu()
 ├── GetChoice()
 ├── Add()
 ├── Subtract()
 ├── Multiply()
 └── Divide()
```

---

# 🟡 Stage 3 — Student Management System

This is your first **real project**.

```text
================================
       STUDENT MANAGEMENT
================================

1. Add Student
2. View Students
3. Search Student
4. Calculate Average
5. Delete Student
6. Exit

Choose:
```

Example student:

```text
ID: 1001
Name: John
Age: 21
Grade: 89
```

### Practice

- Classes
- Objects
- `List<T>`
- Generics
- Methods
- Loops
- Searching
- Validation

### Suggested Class

```text
Student
 ├── ID
 ├── Name
 ├── Age
 └── Grade
```

**This is where your current Generics knowledge starts becoming useful.**

---

# 🟡 Stage 4 — Expense Tracker

Build something practical:

```text
================================
         EXPENSE TRACKER
================================

1. Add Expense
2. View Expenses
3. Search Expenses
4. Total Expenses
5. Monthly Summary
6. Delete Expense
7. Exit
```

Example:

```text
Date        Category    Amount
--------------------------------
09/01/26    Food        ₱150
09/01/26    Gas         ₱300
09/02/26    Food        ₱200
09/02/26    Internet    ₱1,000

Total: ₱1,650
```

### Practice

- `DateTime`
- `decimal`
- `List<T>`
- Classes
- Methods
- LINQ
- Basic data processing

---

# 🟠 Stage 5 — Inventory System

> ⭐ **One of the most important projects for your future .NET work.**

Build:

```text
================================
       INVENTORY SYSTEM
================================

1. Add Product
2. View Products
3. Search Product
4. Update Stock
5. Remove Product
6. Low Stock
7. Exit
```

Example:

```text
ID      Product          Stock
--------------------------------
1001    Keyboard         15
1002    Mouse            23
1003    Monitor           4
```

### Suggested Classes

```text
Product
 ├── ID
 ├── Name
 ├── Price
 ├── Quantity
 └── Category
```

Then:

```text
Inventory
 ├── AddProduct()
 ├── RemoveProduct()
 ├── SearchProduct()
 ├── UpdateStock()
 └── GetLowStockProducts()
```

### Practice

- OOP
- Collections
- Generics
- LINQ
- Validation
- System organization

This project can later evolve from:

```text
List<Product>
      ↓
SQL Server
      ↓
ASP.NET Core MVC
```

---

# 🟠 Stage 6 — Bank Account System

Now concentrate heavily on **OOP**.

```text
================================
          BANK SYSTEM
================================

1. Create Account
2. Deposit
3. Withdraw
4. Check Balance
5. Account Information
6. Transaction History
7. Exit
```

### Possible Classes

```text
Bank
Customer
BankAccount
Transaction
```

### Practice

- Encapsulation
- Properties
- Constructors
- Access modifiers
- Methods
- Composition
- Inheritance
- Interfaces

---

# 🔵 Stage 7 — Hotel Reservation System

Now combine everything you've learned.

```text
================================
       HOTEL MANAGEMENT
================================

1. Room Management
2. Guest Management
3. Reservation
4. Check-In
5. Check-Out
6. Billing
7. Reports
8. Exit
```

### Possible Classes

```text
Hotel
Room
Guest
Reservation
Payment
```

Example relationship:

```text
Hotel
 ├── Rooms
 ├── Guests
 └── Reservations

Reservation
 ├── Guest
 ├── Room
 ├── CheckInDate
 └── CheckOutDate
```

### Practice

- OOP design
- Object relationships
- Collections
- Date/time
- Validation
- Reports
- Combining previous concepts

At this point, you're starting to think about **system design**, not just C# syntax.

---

# 🤖 Stage 8 — Console JARVIS

This is your long-term project.

**Start without AI.**

```text
================================
             JARVIS
================================

Hello. How can I assist you?

> help

Available commands:

time
date
calculator
open
search
system
exit
```

Example:

```text
> time

Current time: 5:36 PM

> calculator

Enter calculation:
150 * 25

Result: 3750

> open notepad

Opening Notepad...

> exit

Goodbye.
```

### Evolution

```text
C# Console JARVIS
       ↓
Commands
       ↓
File System
       ↓
Windows Processes
       ↓
HTTP / APIs
       ↓
AI API
       ↓
Speech-to-Text
       ↓
Text-to-Speech
       ↓
🤖 JARVIS
```

Don't worry about the AI portion yet. Your first goal is simply to make a useful **C# console assistant**.

---

# ⭐ Recommended Progression

```text
C# Fundamentals
       ↓
Generics ← YOU
       ↓
Exception Handling
       ↓
LINQ
       ↓
OOP
       ↓
Student Management System
       ↓
Expense Tracker
       ↓
Inventory System
       ↓
Bank Account System
       ↓
Hotel Reservation System
       ↓
Console JARVIS
       ↓
SQL Server
       ↓
ASP.NET Core
       ↓
Real Web-Based Business Systems
```

---

# 🧠 The Most Important Rule

Don't ask AI to build the project for you first.

Instead:

> **Try → Get stuck → Think → Research if needed → Try again → Ask for help**

For example, if you don't know how to remove an object from:

```csharp
List<Student>
```

Ask about the **concept** first.

Don't immediately ask:

> "Give me the complete code."

This is important because your goal isn't just to have working software.

Your goal is to become the person who can **build the software**.

---

# 👨‍💻 Code Review System

When you finish a project, send me your code.

I'll review it as your **C# mentor/code reviewer**.

I'll check:

### 1. Correctness
Does it actually work?

### 2. C# Fundamentals
Are you using the concepts correctly?

### 3. Structure
Are methods/classes organized properly?

### 4. OOP
Are responsibilities in the right classes?

### 5. Readability
Can another developer understand your code?

### 6. Improvements
What could be made better?

### 7. Learning Gaps
What concept should you study next?

I won't simply rewrite the whole project unless you specifically ask me to.

---

# 🚀 Long-Term Goal

The idea is to repeatedly improve the same type of projects as your knowledge grows.

For example:

```text
Inventory System v1
       ↓
Basic C#
       ↓
Inventory System v2
       ↓
OOP + LINQ
       ↓
Inventory System v3
       ↓
SQL Server
       ↓
Inventory System v4
       ↓
ASP.NET Core MVC
       ↓
Real Web Application
```

That gives you a natural path from:

**Beginner C# → Strong C# Fundamentals → OOP → SQL → .NET → ASP.NET Core → Professional Development**

---

## 🎯 Your Next Step

For now:

**Keep studying Generics.**

You don't need to start Stage 3 yet.

When you reach a comfortable point with:

```text
Generics
   ↓
Collections
   ↓
Exception Handling
   ↓
LINQ
   ↓
OOP
```

then tackle the **Student Management System** from scratch.

No tutorial. No copying.

Just you, C#, and the problem. 💪
