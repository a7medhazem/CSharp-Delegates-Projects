# 🌡️ Temperature Sensor System (Version 2 - Broker Pattern)

A console-based project built with **C#** to practice the **Broker (Publisher/Subscriber) Pattern**.  
The program simulates a temperature sensor that communicates through a **Broker**, which manages subscriptions between publishers (Sensor) and subscribers (Display & Alarm).

---

## ✨ Features
- 📊 Read and update temperature from the sensor.  
- 🔔 Alarm triggers if temperature passes the threshold.  
- 🖥️ Display shows the current temperature.  
- ⚙️ User can update the alarm threshold anytime.  
- 🧩 Uses **Broker** instead of direct Events → more flexible and scalable.  
- 🚪 Exit safely with a menu-driven console flow.  

---

## 🛠️ Technologies & Concepts
- ⚡ .NET 8 Console Application  
- 📡 **Broker Pattern (Pub/Sub)** instead of EventHandler  
- 🎯 Decoupling between Sensor, Alarm, and Display (no direct references)  
- 🧩 OOP (Sensor, Display, Alarm, Broker, TempEventArgs classes)  
- 🛡️ Input validation (`int.TryParse`)  

---

## 🔍 Techniques Used

### **Broker**
- Maintains a dictionary of `subject → subscribers`.  
- Handles **Subscribe** (registering a subscriber) and **Publish** (notifying subscribers).  

### **Sensor**
- Publishes `"TemperatureChanged"` event via Broker whenever temperature is updated.  

### **Event Arguments (TempEventArgs)**
- Holds the temperature value.  
- ✅ Generic/extensible → easy to add more fields later (e.g., timestamp, sensor ID, units).  

### **Subscribers**
- **Display** → Shows the updated temperature.  
- **Alarm** → Alerts when temperature ≥ threshold.  

### **Input Validation**
- Prevents invalid numeric inputs.  
- Disallows negative values for temperature or alarm.  

---

## 🚀 Getting Started

```bash
git clone https://github.com/a7medhazem/TemperatureSensor-BrokerPattern.git
cd TemperatureSensor-BrokerPattern
dotnet run
