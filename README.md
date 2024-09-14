# Ecommerce Order Management System

This repository contains the code for the **Ecommerce Order Management System**, a .NET application designed to manage customer orders, products, and transactions for an ecommerce platform. The project follows a layered architecture with distinct separation of concerns between different functionalities.

## Project Structure

- **App Layer**: 
  - Contains the core business logic and application flow.
  - Manages user interactions and ensures data is properly handled and displayed.
  
- **DAL (Data Access Layer)**: 
  - Handles database interactions through **Entity Framework Core**.
  - Contains the entity models and repository patterns for `Orders`, `Customers`, `Products`, and more.
  
- **Solution File**: 
  - The `Ecommerce Order Management System.sln` solution file includes all projects and layers, making it easy to manage the application in **Visual Studio**.



## Getting Started

To set up and run the **Ecommerce Order Management System** locally:

1. Clone the repository:
   ```bash
   git clone https://github.com/Saddam70/Ecommerce-Order-Management-System.git
