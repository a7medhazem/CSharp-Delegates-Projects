# 🌟 C# Console Projects Collection — Practical Hands-On Learning

This repository includes three practical C# console applications designed to reinforce advanced C# concepts through real-world scenarios.  
Each project is simple, interactive, and built to demonstrate clean, organized code — perfect for learning, practicing, or showcasing your skills. 🎓

---

## 📁 Projects Included

1. 🧮 **[Student Grading System](./StudentGradingSystem)**  
2. 🌡️ **[TemperatureSensor (V1 - Observer Pattern)](./TemperatureSensor%20(V1%20-%20Observer%20Pattern))**  
3. 🌡️ **[TemperatureSensor (V2 - Broker Pattern)](./TemperatureSensor%20(V2%20-%20Broker%20Pattern))**  

---

### 🧮 [Student Grading System](./StudentGradingSystem)

A small console application built with **C#** to practice **Delegates** (Func, Action, Predicate).  
The program calculates students’ averages and determines pass/fail status.

📋 **Key Features**:
- ➕ Enter student grades interactively  
- 📊 Calculate average using **Func**  
- ✅ Check pass/fail using **Predicate**  
- 🖨️ Display results using **Action**  
- 🔄 Uses LINQ (`Sum`, `Count`) for efficient calculations  
- 🛡️ Input validation for names and numeric grades  

📂 **Project Folder:** `StudentGradingSystem`

---

### 🌡️ [Temperature Sensor (V1 - Observer Pattern)](./TemperatureSensor%20(V1%20-%20Observer%20Pattern))

A console-based project built with **C#** to practice the **Observer Pattern** using Events & EventHandler.  
The program simulates a temperature sensor that notifies multiple subscribers (Display & Alarm) whenever the temperature changes.

📋 **Key Features**:
- 📊 Read and update temperature from the sensor  
- 🔔 Alarm triggers if temperature passes the threshold  
- 🖥️ Display shows the current temperature  
- ⚙️ User can update the alarm threshold anytime  
- 🚪 Exit safely with a menu-driven console flow  

📂 **Project Folder:** `TemperatureSensor (V1 - Observer Pattern)`

---

### 🌡️ [Temperature Sensor (V2 - Broker Pattern)](./TemperatureSensor%20(V2%20-%20Broker%20Pattern))

An upgraded version of the Temperature Sensor project using the **Broker (Publisher/Subscriber) Pattern** instead of direct Events.  
The program simulates a temperature sensor that communicates through a **Broker**, which manages subscriptions between publishers (Sensor) and subscribers (Display & Alarm).

📋 **Key Features**:
- 📊 Read and update temperature from the sensor  
- 🔔 Alarm triggers if temperature passes the threshold  
- 🖥️ Display shows the current temperature  
- ⚙️ User can update the alarm threshold anytime  
- 🧩 Uses **Broker** instead of direct Events → more flexible and scalable  
- 🚪 Exit safely with a menu-driven console flow  

📂 **Project Folder:** `TemperatureSensor (V2 - Broker Pattern)`

---

## 🛠 Technologies Used
- **Language:** C#  
- **Type:** Console Applications  
- **Paradigm:** Object-Oriented Programming (OOP)  
- **Concepts:** Delegates, Events, Observer Pattern, Broker Pattern  

---

## 📄 License & Author
Created with ❤️ by [a7medhazem](https://github.com/a7medhazem)  
Licensed under the [MIT License](LICENSE.md)
