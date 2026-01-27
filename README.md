# csharp-collections-generics

This repository focuses on **Collections and Generics in C#**, covering built-in collection libraries, generic classes, generic methods, and practical real-world use cases.

The goal is to build a **strong foundation in type-safe and efficient data handling** while improving **problem-solving skills** through scenario-based implementations.

---

## 🛠 Tech Stack

- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio Code
- **Version Control:** Git & GitHub

---

## ✨ Features

- Structured **branch-wise learning approach**
- Separate branches for different **core concepts**
- Beginner-friendly **C# practice problems**
- Strong focus on **logic building**
- Real-world **edge case handling**

---

## 📂 Branch Structure

### 🔹 [`generics` branch](../../tree/generics)

This branch focuses on **Generics in C#**, demonstrating how to write **type-safe, reusable, and scalable code** using:

- Generic Classes  
- Generic Methods  
- Constraints  
- Interfaces with Generics  
- Basic Variance concepts  

All problems are modeled around **real-world systems** to show how generics improve flexibility while maintaining **compile-time safety**.

---

## 📝 Generics – Practice Problems

### 1️⃣ Smart Warehouse Management System

**Problem Statement:**  
Design a warehouse system that can safely manage different types of items while ensuring type safety and reusability.

**Concepts Used:**
- Generic Classes
- Constraints
- Variance

**Tasks:**
- Manage items such as Electronics, Groceries, and Furniture  
- Create a generic `Storage<T>` class constrained to `WarehouseItem`  
- Store and retrieve items using `List<T>`  

**Edge Cases:**
- Empty warehouse  
- Invalid item type  
- Null item references  

---

### 2️⃣ Dynamic Online Marketplace

**Problem Statement:**  
Build a flexible product catalog system that supports multiple product categories using generics.

**Concepts Used:**
- Generic Methods
- Type Parameters
- Constraints

**Tasks:**
- Create a generic product catalog  
- Apply discounts using generic methods  
- Support multiple product categories safely  

**Edge Cases:**
- Invalid discount percentage  
- Duplicate products  

---

### 3️⃣ Multi-Level University Course Management System

**Problem Statement:**  
Manage different types of courses with varying evaluation strategies using generics.

**Concepts Used:**
- Generic Classes
- Constraints

**Tasks:**
- Handle exam-based and assignment-based courses  
- Create a generic `Course<T>` constrained to `CourseType`  

**Edge Cases:**
- Invalid course type  
- Empty course list  

---

### 4️⃣ Personalized Meal Plan Generator

**Problem Statement:**  
Generate customized meal plans while enforcing dietary rules using generic constraints.

**Concepts Used:**
- Generic Methods
- Interfaces
- Constraints

**Tasks:**
- Generate Vegetarian, Vegan, Keto, and High-Protein plans  
- Validate meal rules dynamically  

**Edge Cases:**
- Conflicting dietary rules  
- Unsupported meal type  

---

### 5️⃣ AI-Driven Resume Screening System

**Problem Statement:**  
Screen resumes for different job roles efficiently using generics.

**Concepts Used:**
- Generic Classes
- Generic Methods
- Constraints

**Tasks:**
- Process resumes for multiple job roles  
- Create a generic `Resume<T>` constrained to `JobRole`  

**Edge Cases:**
- Empty resume data  
- Invalid job role  

---

## 🎯 Learning Outcomes (Generics)

- Design reusable and type-safe systems  
- Apply generic constraints correctly  
- Improve compile-time safety  

---

### 🔹 [`collections` branch](../../tree/collections)

This branch focuses on **C# Collection Libraries**, covering practical usage of:

- `List`
- `Set`
- `Queue`
- `Dictionary`

The emphasis is on **efficient data handling, traversal, modification, and edge-case management**.

---

## 📁 Collections – Folder Structure

``text
collections/
├── List/
├── Set/
├── Queue/
├── Map/
└── Collections_Extra_Questions/
## 📂 List – Practice

### 1️⃣ List Operations Practice

**Problem Statement:**  
Implement common list-based problems focusing on traversal, order preservation, and element manipulation.

**Collections Used:**
- `List<int>`
- `Dictionary<int, int>`

**Tasks:**
- Reverse a list without using built-in reverse methods  
- Rotate elements of a list by N positions  
- Remove duplicates while preserving order  
- Find the Nth element from the end of the list  
- Find frequency of elements using a dictionary  

**Edge Cases:**
- Empty list  
- Single element list  
- N greater than list size  
- Duplicate values  
- Large list size  

---

## 📂 Set – Practice

### 2️⃣ Set Operations Practice

**Problem Statement:**  
Perform set-based operations emphasizing uniqueness, comparison, and mathematical set logic.

**Collections Used:**
- `HashSet<int>`
- `SortedSet<int>`

**Tasks:**
- Check whether two sets are equal  
- Find union and intersection of two sets  
- Compute symmetric difference  
- Convert a set into a sorted list  
- Check if one set is a subset of another  

**Edge Cases:**
- Empty sets  
- Identical sets  
- One set fully contained in another  
- Duplicate input values  
- Large data sets  

---

## 📂 Queue – Practice

### 3️⃣ Queue Operations Practice

**Problem Statement:**  
Implement queue-based solutions demonstrating FIFO behavior and priority-based processing.

**Collections Used:**
- `Queue<int>`
- `PriorityQueue<int, int>`

**Tasks:**
- Reverse a queue using only queue operations  
- Generate first N binary numbers using a queue  
- Implement a hospital triage system using a priority queue  

**Edge Cases:**
- Empty queue  
- Single element queue  
- Priority tie cases  
- Large N values  
- Queue underflow  

---

## 📂 Map (Dictionary) – Practice

### 4️⃣ Dictionary Operations Practice

**Problem Statement:**  
Solve key–value based problems using dictionaries for efficient lookup, grouping, and aggregation.

**Collections Used:**
- `Dictionary<string, int>`
- `Dictionary<int, List<string>>`

**Tasks:**
- Count word frequency from text input  
- Invert a dictionary to map values to multiple keys  

**Edge Cases:**
- Empty input  
- Case-sensitive keys  
- Duplicate keys  
- Null or missing values  
- Large input size  
---

## 👤 Author

**Sai Charan Muchakarla**  
C# | .NET | 

-  GitHub: https://github.com/Charansaimsc  
-  Focus Areas: C#, .NET, Generics, Collections, Data Structures  
-  Goal: Writing clean, efficient, and type-safe code with strong fundamentals
