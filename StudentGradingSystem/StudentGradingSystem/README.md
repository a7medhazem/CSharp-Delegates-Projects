# 🧮 Student Grading System (Console App - C#)

A small console exercise built with C# to practice **Delegates** (Func, Action, Predicate).  
The program calculates students’ averages and determines pass/fail status.  

---


## ✨ Features
- ➕ Enter student grades interactively  
- 📊 Calculate average using **Func**  
- ✅ Check pass/fail using **Predicate**  
- 🖨️ Display results using **Action**  

---

## 🛠️ Technologies & Concepts
- ⚡ .NET 8 Console Application  
- 🎯 **Delegates**: Func, Action, Predicate  
- 🔄 LINQ (`Sum`, `Count`) for calculations  
- 🧩 OOP with **Class (Student)** to hold data  

---

## 🔍 Techniques Used
- **Class (`Student`)**
  - Holds `Name` + `Grades (List<int>)`.  

- **Delegates**
  - `Func<List<int>, double>` → Calculates average grade.  
  - `Predicate<double>` → Validates pass/fail (avg ≥ 50).  
  - `Action<string, double, bool>` → Displays result in console.  

- **LINQ**
  - `Sum()` + `Count()` → Efficient average calculation.  

- **Input Validation**
  - Rejects empty names.  
  - Ensures valid numeric grade input with `int.TryParse`.  
---

## 🚀 Getting Started
```bash
git clone https://github.com/a7medhazem/StudentGradingSystem-CSharp.git
cd StudentGradingSystem-CSharp
dotnet run
