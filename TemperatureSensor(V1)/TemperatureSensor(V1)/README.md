# 🌡️ Temperature Sensor System (Version 1 - Observer Pattern)

A console-based project built with C# to practice the **Observer Pattern** using **Events & EventHandler**.  
The program simulates a temperature sensor that notifies multiple subscribers (Display & Alarm) whenever the temperature changes.

---

## ✨ Features

- 📊 Read and update temperature from the sensor.
- 🔔 Alarm triggers if temperature passes the threshold.
- 🖥️ Display shows the current temperature.
- ⚙️ User can update the alarm threshold anytime.
- 🚪 Exit safely with a menu-driven console flow.

---

## 🛠️ Technologies & Concepts

- ⚡ .NET 8 Console Application
- 🎯 **Observer Pattern** implemented with Events
- 📡 **EventHandler\<TempEventArgs\>** → used for extensibility
- 🧩 OOP (Sensor, Display, Alarm classes)
- 🛡️ Input validation (`int.TryParse`)

---

## 🔍 Techniques Used

- **Class (`Sensor`)**

  - Raises an event `SensorChanged` whenever temperature is updated.
  - Uses `EventHandler<TempEventArgs>` instead of a simple delegate.

- **Event Arguments (`TempEventArgs`)**

  - Holds the temperature value.
  - ✅ **Made generic/extensible** → easy to add more data later (like timestamp, sensor ID, unit °C/°F) without changing the event structure.

- **Subscribers**

  - **Display** → Shows the updated temperature.
  - **Alarm** → Alerts when temperature ≥ threshold.

- **Input Validation**
  - Prevents invalid numeric inputs.
  - Disallows negative values for temperature or alarm.

---

## 🚀 Getting Started

```bash
git clone https://github.com/a7medhazem/TemperatureSensor-ObserverPattern.git
cd TemperatureSensor-ObserverPattern
dotnet run
```
