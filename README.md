# Food Delivery System

## 1. Project Overview
***
This project is a **C#-based Food Delivery System** designed to simulate the core functionalities of a modern online food ordering platform. The system allows customers to browse restaurant menus, place orders, choose payment methods, and receive delivery notifications. It is built with a strong focus on **object-oriented design principles**, ensuring modularity, scalability, and maintainability.

The application follows a clean architectural structure where responsibilities such as ordering, payment processing, notifications, and delivery logistics are clearly separated and coordinated through well-defined interfaces and design patterns.

## 2. Project Objectives
***
The main objectives of this project are to **design and implement a complete food delivery workflow**, apply **object-oriented programming concepts**, respect **SOLID principles**, and integrate **Gang of Four (GoF) design patterns**. The system aims to provide a flexible structure that can be easily extended with new features such as additional delivery methods or notification channels.

## 3. Core Features
***
- Customer profile management and order placement
- Menu browsing with categorized food items
- Dynamic cart management and total price calculation
- Multiple payment methods (Cash / Card)
- Order status tracking
- Email and SMS notification support
- Flexible delivery strategies (Standard / Express)
- Centralized order processing using a façade

## 4. System Architecture & Design
***
The system is structured around a clear **class hierarchy**, where the **User** class acts as a base for the **Customer** subclass, promoting reusability and logical separation of responsibilities. Orders are processed through a unified interface that coordinates cart validation, payment, delivery, and notifications.

To reduce coupling and improve maintainability, the system relies heavily on **interfaces**, **abstract classes**, and **design patterns**, allowing components to evolve independently without impacting the overall architecture.

## 5. Object-Oriented Concepts Used
***
- **Abstraction:** Interfaces such as `INotification` and `IDeliveryStrategy` define clear contracts for system behavior.
- **Inheritance:** `Customer` inherits from `User`, extending shared functionality.
- **Encapsulation:** Classes expose behavior through methods while protecting internal state.
- **Polymorphism:** Different notification and delivery implementations are used interchangeably through interfaces.
- **Constructor Overloading:** Used in classes

## 6. SOLID Principles
***
- **Single Responsibility Principle:** Each class handles a single concern (e.g., `Cart`, `User`, `Order`).
- **Open/Closed Principle:** New delivery methods can be added without modifying existing code.
- **Liskov Substitution Principle:** Notification implementations (Email/SMS) can replace each other seamlessly.
- **Interface Segregation Principle:** Interfaces expose only required functionality.
- **Dependency Inversion Principle:** High-level modules depend on abstractions rather than concrete implementations.

## 7. Design Patterns Implemented
***
- **Facade Pattern:** `OrderProcessorFacade` simplifies complex order workflows.
- **Singleton Pattern:** Ensures a single instance of the order processor manages all orders.
- **Strategy Pattern:** Delivery behavior is selected dynamically using delivery strategy implementations.

## 8. Technologies Used
***
- **Language:** C#
- **Framework:** .NET / Windows Forms
- **UI:** Windows Forms
- **Design:** UML Class Diagrams
- **Paradigm:** Object-Oriented Programming (OOP)

## 9. User Interface
***
The Windows Forms interface allows users to browse restaurant menus, add items to a cart, confirm orders, choose payment methods, track order status, and manage their profile. The UI is designed to be intuitive while clearly reflecting the underlying system workflow.

## 10. Learning Outcomes
***
This project strengthened practical understanding of **object-oriented design**, **SOLID principles**, and **design patterns**, while providing hands-on experience in building a modular and extensible C# application. It also reinforced the importance of clean architecture, code reusability, and separation of concerns in software engineering.
