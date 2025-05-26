# 🛒 E-Shop Database Design Project

## 📌 Overview

This project the design and implementation of a database for an E-Shop system. It includes:

- ✅ Entity Relationship Diagram (ERD)
- ✅ Relational Schema Diagram
- ✅ SQL for database and table creation
- ✅ Entity Framework (EF) classes with relationships

---

## 📊 Diagrams

### 1. Entity Relationship Diagram (ERD)
- Includes all key entities: `Customer`, `Order`, `Product`, `Category`, `Review`, etc.
- Includes a multi-valued attribute: `Phone`, which was converted into a separate class/table for normalization.

### 2. Schema Diagram
- Represents the physical design of the database including keys and relationships.
- All foreign key connections are clearly shown between entities.

---

## 🧱 SQL Script

A complete SQL file (`SQLQueryShopfinal.sql`) was created to:

- Create the database
- Define all tables and relationships
- Include primary and foreign keys


---

## 💻 Entity Framework Classes

I converted the schema into EF Core classes in C#. The classes are well-structured and maintain all database relationships:

- `Customer`
- `Order`
- `OrderItem`
- `Product`
- `Category`
- `ShippingAddress`
- `PaymentInformation`
- `Review`
- `Phone` *(previously named `Contact Information` in the senario, renamed and converted to a separate class to handle multiple phone numbers per customer)*

---

## 📝 Notes

- The attribute originally named **Contact Information** was **renamed to `Phone`** for clarity.
- Since it is a **multi-valued attribute**, I created a **dedicated class/table (`Phone`)** and linked it to the `Customer` entity through a one-to-many relationship.


