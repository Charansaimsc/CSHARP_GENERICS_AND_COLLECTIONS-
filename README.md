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

```
collections/
├── List/
├── Set/
├── Queue/
├── Map/
└── Collections_Extra_Questions/
```
## 📂 List

Problems based on the `List` collection focusing on **order preservation, traversal, and manipulation**.

---

### 1️⃣ Reverse a List

**Problem Statement:**  
Reverse the elements of a list without using built-in reverse methods.

**Collections Used:**
- `List<int>`

**Tasks:**
- Traverse the list manually  
- Reverse elements in-place  

**Edge Cases:**
- Empty list  
- Single element list  

---

### 2️⃣ Rotate Elements in a List

**Problem Statement:**  
Rotate the elements of a list by N positions.

**Collections Used:**
- `List<int>`

**Tasks:**
- Rotate left or right by N  
- Handle N greater than list size  

**Edge Cases:**
- N = 0  
- N > list size  

---

### 3️⃣ Remove Duplicates While Preserving Order

**Problem Statement:**  
Remove duplicate elements from a list while maintaining the original order.

**Collections Used:**
- `List<int>`
- `HashSet<int>`

**Tasks:**
- Track visited elements  
- Preserve insertion order  

**Edge Cases:**
- All elements duplicate  
- No duplicates  

---

### 4️⃣ Find Nth Element From End

**Problem Statement:**  
Find the Nth element from the end of a list without using the `Count` property.

**Collections Used:**
- `List<int>`

**Tasks:**
- Use two-pointer technique  

**Edge Cases:**
- N greater than list size  
- Empty list  

---

### 5️⃣ Frequency of Elements in a List

**Problem Statement:**  
Count the frequency of each element in a list.

**Collections Used:**
- `List<int>`
- `Dictionary<int, int>`

**Tasks:**
- Traverse list  
- Maintain frequency map  

**Edge Cases:**
- Empty list  
- All elements same
---

## 📂 Set

Problems based on the `Set` collection focusing on **uniqueness, comparison, and set operations**.

---

### 1️⃣ Check Equality of Two Sets

**Problem Statement:**  
Check whether two sets contain the same elements.

**Collections Used:**
- `HashSet<int>`

**Tasks:**
- Compare elements ignoring order  

**Edge Cases:**
- Empty sets  
- Different sizes  

---

### 2️⃣ Union and Intersection of Sets

**Problem Statement:**  
Find the union and intersection of two sets.

**Collections Used:**
- `HashSet<int>`

**Tasks:**
- Compute union  
- Compute intersection  

**Edge Cases:**
- No common elements  
- One empty set  

---

### 3️⃣ Symmetric Difference

**Problem Statement:**  
Find elements present in either set but not in both.

**Collections Used:**
- `HashSet<int>`

**Tasks:**
- Remove common elements  

**Edge Cases:**
- Identical sets  
- One empty set  

---

### 4️⃣ Convert Set to Sorted List

**Problem Statement:**  
Convert a set into a sorted list.

**Collections Used:**
- `HashSet<int>`
- `List<int>`

**Tasks:**
- Transfer elements  
- Sort list  

**Edge Cases:**
- Empty set  

---

### 5️⃣ Subset Check

**Problem Statement:**  
Check whether one set is a subset of another.

**Collections Used:**
- `HashSet<int>`

**Tasks:**
- Validate containment  

**Edge Cases:**
- Same sets  
- Empty subset  

---

## 📂 Queue

Problems based on the `Queue` collection focusing on **FIFO processing and priority handling**.

---

### 1️⃣ Reverse a Queue

**Problem Statement:**  
Reverse the elements of a queue using only queue operations.

**Collections Used:**
- `Queue<int>`
- `Stack<int>`

**Tasks:**
- Dequeue and push into stack  
- Re-enqueue elements  

**Edge Cases:**
- Empty queue  
- Single element  

---

### 2️⃣ Generate First N Binary Numbers

**Problem Statement:**  
Generate the first N binary numbers using a queue.

**Collections Used:**
- `Queue<string>`

**Tasks:**
- Generate binary numbers iteratively  

**Edge Cases:**
- N = 0  
- N = 1  

---

### 3️⃣ Hospital Triage System

**Problem Statement:**  
Serve patients based on priority using a priority queue.

**Collections Used:**
- `PriorityQueue<Patient, int>`

**Tasks:**
- Assign priorities  
- Serve highest priority first  

**Edge Cases:**
- Same priority patients  
- No patients  

---

## 📂 Map (Dictionary)

Problems based on the `Dictionary` collection focusing on **key–value mapping and efficient lookups**.

---

### 1️⃣ Word Frequency Counter

**Problem Statement:**  
Count the frequency of words in a given text.

**Collections Used:**
- `Dictionary<string, int>`

**Tasks:**
- Split text into words  
- Normalize and count occurrences  

**Edge Cases:**
- Empty input  
- Case sensitivity  

---

### 2️⃣ Invert a Dictionary

**Problem Statement:**  
Invert a dictionary to map values to multiple keys.

**Collections Used:**
- `Dictionary<K, V>`
- `Dictionary<V, List<K>>`

**Tasks:**
- Group keys by value  

**Edge Cases:**
- Duplicate values  
- Empty dictionary  

---

### 3️⃣ Key-Based Lookup System

**Problem Statement:**  
Retrieve values efficiently using keys.

**Collections Used:**
- `Dictionary<int, string>`

**Tasks:**
- Insert key–value pairs  
- Fetch values safely  

**Edge Cases:**
- Missing keys  
- Null values  

---

### 4️⃣ Group Elements by Category

**Problem Statement:**  
Group elements based on a common key.

**Collections Used:**
- `Dictionary<string, List<string>>`

**Tasks:**
- Group related elements  

**Edge Cases:**
- Empty groups  
- Single category  

---


## 👤 Author

**Sai Charan Muchakarla**  
C# | .NET | 

-  GitHub: https://github.com/Charansaimsc  
-  Focus Areas: C#, .NET, Generics, Collections, Data Structures  
-  Goal: Writing clean, efficient, and type-safe code with strong fundamentals
