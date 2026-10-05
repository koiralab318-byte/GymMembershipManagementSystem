# Gym Membership Management System

## Project Description

The Gym Membership Management System is a Windows Forms application developed in C# using Microsoft Visual Studio.

The purpose of the application is to help manage gym members and their membership information in a simple and organised way. The application allows users to add new members, view existing members, search for members, update member details, and delete member records.

Member and membership information is stored using an SQLite database.

## Main Features

- Add new gym members
- Store member details including name, phone and email
- Record join date and membership start date
- Select different membership plans
- Automatically calculate membership expiry date
- Record membership fee
- Record payment status
- View all members in a DataGridView
- Search members by member ID, name, phone or email
- Refresh member records
- Update existing member information
- Delete member records
- SQLite database storage
- Validation and exception handling

## Object-Oriented Programming Concepts

The application demonstrates several object-oriented programming principles.

### Classes and Objects

The project contains meaningful classes such as:

- `Person`
- `Member`
- `Membership`
- `DatabaseHelper`

Objects of the `Member` and `Membership` classes are created when member information is added or updated.

### Encapsulation

Encapsulation is demonstrated through the use of properties and access modifiers.

For example, member information such as `Name`, `Phone`, `Email` and `JoinDate` is stored using public properties.

### Inheritance

The `Member` class inherits from the abstract `Person` class.

Example:

```csharp
public class Member : Person