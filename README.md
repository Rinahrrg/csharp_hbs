# 🏨 BOOKIFY - Hotel Booking Management System

A comprehensive hotel booking management system developed in C# using Windows Forms and MySQL database.

## 📋 Table of Contents

1. [Project Overview](#project-overview)
2. [Features](#features)
3. [Technology Stack](#technology-stack)
4. [Installation](#installation)
5. [Database Schema](#database-schema)
6. [Usage Guide](#usage-guide)
7. [Program Flow](#program-flow)
8. [Design Decisions](#design-decisions)
9. [Troubleshooting](#troubleshooting)

---

## 🎯 Project Overview

BOOKIFY is a complete hotel booking solution designed as a final project for a C# programming course. It provides separate interfaces for administrators and customers, enabling efficient hotel management and seamless booking experiences.

### Key Capabilities

- **Multi-Role Authentication**: Separate login systems for admins and customers
- **Complete Hotel Management**: CRUD operations with image upload support
- **Hierarchical Structure**: Hotels → Floors → Rooms
- **Dynamic Pricing**: Room types with configurable prices
- **Food Options**: Breakfast, Lunch, Dinner, Full Board packages
- **Booking Management**: Full lifecycle from search to confirmation
- **Reporting**: Export bookings to CSV format

---

## ✨ Features

### Admin Dashboard
| Feature | Description |
|---------|-------------|
| Add Hotels | Create hotels with name, address, image |
| Manage Floors | Add/edit/delete floors per hotel |
| Manage Rooms | Configure rooms with types and pricing |
| View Bookings | See all bookings with search and export |
| Room Types | Define room categories with prices |
| Assets Management | Manage amenities for room types |

### Customer Dashboard
| Feature | Description |
|---------|-------------|
| Search Hotels | Filter by destination/address |
| Date Selection | Check-in and check-out date pickers |
| Hotel Cards | Visual cards with images and details |
| Room Selection | Browse available rooms by floor |
| Food Options | Choose meal packages |
| Booking Summary | Real-time price calculation |
| My Bookings | View personal booking history |

---

## 🛠 Technology Stack

| Component | Technology |
|-----------|------------|
| Language | C# (.NET Framework) |
| IDE | Visual Studio 2022 |
| UI Framework | Windows Forms |
| Database | MySQL 8.0 |
| DB Connector | MySql.Data NuGet Package |
| Design Pattern | Repository Pattern |

---

## 📥 Installation

### Prerequisites

1. **Visual Studio 2022** with .NET desktop development workload
2. **MySQL Server 8.0** or later
3. **MySQL Workbench** (recommended)

### Database Setup

1. Open MySQL Workbench and connect to your server

2. Create the database:
```sql
CREATE DATABASE hotel_system;
USE hotel_system;
```

3. Create the required tables:
```sql
-- Hotels table
CREATE TABLE hotels (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    address VARCHAR(500) NOT NULL,
    default_booking_time INT DEFAULT 24,
    image LONGBLOB NULL
);

-- Floors table
CREATE TABLE floors (
    id INT PRIMARY KEY AUTO_INCREMENT,
    hotel_id INT NOT NULL,
    floor_number INT NOT NULL,
    FOREIGN KEY (hotel_id) REFERENCES hotels(id) ON DELETE CASCADE
);

-- Room types table
CREATE TABLE room_types (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    bed_count INT NOT NULL,
    price DECIMAL(10,2) NOT NULL
);

-- Rooms table
CREATE TABLE rooms (
    id INT PRIMARY KEY AUTO_INCREMENT,
    floor_id INT NOT NULL,
    room_type_id INT,
    room_number VARCHAR(20) NOT NULL,
    status VARCHAR(50) DEFAULT 'available',
    FOREIGN KEY (floor_id) REFERENCES floors(id) ON DELETE CASCADE,
    FOREIGN KEY (room_type_id) REFERENCES room_types(id)
);

-- Assets table
CREATE TABLE assets (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL
);

-- Room type assets junction table
CREATE TABLE room_type_assets (
    room_type_id INT NOT NULL,
    asset_id INT NOT NULL,
    PRIMARY KEY (room_type_id, asset_id),
    FOREIGN KEY (room_type_id) REFERENCES room_types(id) ON DELETE CASCADE,
    FOREIGN KEY (asset_id) REFERENCES assets(id) ON DELETE CASCADE
);

-- Customers table
CREATE TABLE customers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    email VARCHAR(255) NOT NULL
);

-- Admins table
CREATE TABLE admins (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);

-- Bookings table
CREATE TABLE bookings (
    id INT PRIMARY KEY AUTO_INCREMENT,
    booking_code VARCHAR(50) NOT NULL UNIQUE,
    hotel_id INT NOT NULL,
    room_id INT NOT NULL,
    customer_id INT NOT NULL,
    start_time DATE NOT NULL,
    end_time DATE NOT NULL,
    food_option VARCHAR(50) DEFAULT 'none',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (hotel_id) REFERENCES hotels(id),
    FOREIGN KEY (room_id) REFERENCES rooms(id),
    FOREIGN KEY (customer_id) REFERENCES customers(id)
);

-- Insert default admin
INSERT INTO admins (username, password) VALUES ('admin', 'admin123');

-- Insert sample room types
INSERT INTO room_types (name, bed_count, price) VALUES 
('Single', 1, 75.00),
('Double', 2, 120.00),
('Suite', 2, 200.00),
('Family', 4, 250.00);
```

### Application Setup

1. Clone or download the project files

2. Open `HotelBookingSystem.sln` in Visual Studio 2022

3. Install MySql.Data NuGet package:
   - Tools → NuGet Package Manager → Manage NuGet Packages
   - Search "MySql.Data" and install

4. Update the connection string in all files:
```csharp
private readonly string conn = "server=localhost;database=hotel_system;user=root;password=YOUR_PASSWORD;";
```

5. Build and run the application (F5)

---

## 📊 Database Schema

### Entity Relationship Diagram

```
┌─────────────┐       ┌─────────────┐       ┌─────────────┐
│   HOTELS    │───────│   FLOORS    │───────│    ROOMS    │
│─────────────│ 1   * │─────────────│ 1   * │─────────────│
│ id          │       │ id          │       │ id          │
│ name        │       │ hotel_id    │       │ floor_id    │
│ address     │       │ floor_number│       │ room_type_id│
│ image       │       └─────────────┘       │ room_number │
│ booking_time│                             │ status      │
└─────────────┘                             └──────┬──────┘
                                                   │
┌─────────────┐       ┌─────────────┐              │
│ ROOM_TYPES  │───────│ ROOM_TYPE   │              │
│─────────────│ *   * │   ASSETS    │              │
│ id          │       │─────────────│              │
│ name        │       │ room_type_id│              │
│ bed_count   │       │ asset_id    │              │
│ price       │       └─────────────┘              │
└─────────────┘               │                    │
                              │                    │
                        ┌─────────────┐            │
                        │   ASSETS    │            │
                        │─────────────│            │
                        │ id          │            │
                        │ name        │            │
                        └─────────────┘            │
                                                   │
┌─────────────┐       ┌─────────────┐              │
│  CUSTOMERS  │───────│  BOOKINGS   │──────────────┘
│─────────────│ 1   * │─────────────│
│ id          │       │ id          │
│ username    │       │ booking_code│
│ password    │       │ hotel_id    │
│ first_name  │       │ room_id     │
│ last_name   │       │ customer_id │
│ email       │       │ start_time  │
└─────────────┘       │ end_time    │
                      │ food_option │
                      │ created_at  │
                      └─────────────┘
```

---

## 📖 Usage Guide

### Admin Workflow

1. **Login**: Select "Admin" → Enter credentials → Access dashboard
2. **Add Hotel**: Fill name, address → Browse image → Click "Add Hotel"
3. **Add Floor**: Select hotel → Enter floor number → Click "Add Floor"
4. **Add Room**: Select hotel/floor → Select room type → Click "Add Room"
5. **View Bookings**: See all reservations → Search/filter → Export to CSV

### Customer Workflow

1. **Register/Login**: Create account or login with existing credentials
2. **Search**: Enter destination → Select dates → Click "Search"
3. **Select Hotel**: Browse hotel cards → Click "Book Now"
4. **Choose Room**: Select floor → Click on available room
5. **Add Food**: Choose meal option (Breakfast/Lunch/Dinner/Full Board)
6. **Confirm**: Review summary → Click "Confirm Booking"

### Food Pricing

| Option | Price per Night |
|--------|----------------|
| Breakfast | $15.00 |
| Lunch | $20.00 |
| Dinner | $25.00 |
| Full Board | $50.00 |

---

## 🔄 Program Flow

### Startup Sequence

```
Program.cs
    └── Application.Run(FormChooseRole)
            ├── [Admin] → FormAdminLogin
            │                 └── FormAdminDashboard
            │                       ├── AddHotelControl
            │                       ├── ManageFloorsControl
            │                       ├── ManageRoomsControl
            │                       ├── ViewHotelsControl
            │                       └── ViewBookingsControl
            │
            └── [Customer] → FormCustomerLogin
                               └── FormCustomerDashboard
                                     └── FormRoomSelection
```

### Booking Flow

```
1. Customer Dashboard
   │
2. Search Hotels (filter by destination)
   │
3. Click "Book Now" on Hotel Card
   │
4. FormRoomSelection opens
   │  ├── Load available floors
   │  ├── Select floor → Load rooms
   │  ├── Select room → Show details
   │  └── Select food option
   │
5. Click "Confirm Booking"
   │  ├── Generate booking code (BK-YYYYMMDD-####)
   │  ├── Calculate total price
   │  └── INSERT into bookings table
   │
6. Success → Return to Dashboard
```

---

## 🎨 Design Decisions

### Why Windows Forms?

- **Course Requirement**: Part of C# curriculum
- **Rapid Development**: Visual designer accelerates UI creation
- **Rich Controls**: DataGridView, FlowLayoutPanel ideal for data display
- **VS Integration**: Seamless tooling with designer files

### Why MySQL?

- **Open Source**: Free and well-documented
- **Industry Standard**: Real-world applicability
- **BLOB Support**: LONGBLOB perfect for image storage
- **Referential Integrity**: Foreign keys ensure data consistency

### Why Repository Pattern?

- **Separation of Concerns**: Database logic isolated from UI
- **Reusability**: Same methods across multiple forms
- **Maintainability**: Centralized query modifications
- **Testability**: Repositories can be mocked

### Why Store Images in Database?

- **Simplicity**: No external file management
- **Portability**: Backup includes all data
- **Consistency**: Images tied to hotel records
- **Security**: Database access controls apply

### Why Card-Based UI?

- **Modern Design**: Familiar from hotel booking websites
- **Information Density**: Compact yet informative
- **Responsive**: FlowLayoutPanel auto-arranges cards
- **Interactive**: Hover effects provide feedback

---

## 🔧 Troubleshooting

### Connection Failed

**Cause**: MySQL server not running or wrong credentials

**Solution**: Start MySQL service, verify connection string

### Images Not Displaying

**Cause**: Image column missing in database

**Solution**: 
```sql
ALTER TABLE hotels ADD COLUMN image LONGBLOB NULL;
```

### Food Option Shows "None"

**Cause**: food_option not saving to database

**Solution**: Verify INSERT includes food_option parameter

### Rooms Not Appearing

**Cause**: No rooms created for selected floor

**Solution**: Add rooms via Admin Dashboard → Manage Rooms

### Price Shows $0

**Cause**: Room has no room_type or type has no price

**Solution**: Assign room type with price > 0

---

## 📄 License

This project was developed for educational purposes as a C# course final project.

---

## 👨‍💻 Author

Developed as a C# Programming Course Final Project

**Technologies**: Visual Studio 2022 | C# | Windows Forms | MySQL
