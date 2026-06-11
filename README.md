# EnergyGrid Management System

## Overview

EnergyGrid Management System is a C# desktop application integrated with SQL Server that helps manage energy sites, power units, technicians, inspections, and warehouse inventory.

The system allows technicians to perform inspections on power units, record efficiency readings, track maintenance activities, and manage replacement parts used during inspections.

---

## Features

### Energy Site Management
- Store and manage energy sites.
- Track site coordinates and terrain types.

### Power Unit Management
- Manage power units assigned to sites.
- Store manufacturer information.
- Track installation dates.
- Monitor maximum power output (kW).
- Maintain unit status and type.

### Technician Management
- Manage technician profiles.
- Store technical certifications.
- Assign technicians to inspections.

### Inspection Management
- Create inspection records.
- Record machine efficiency readings.
- Track inspection status.
- Link inspections to technicians and sites.

### Warehouse Inventory
- Store replacement part information.
- Track serial numbers.
- Record part usage during inspections.
- Maintain warehouse logs.

---

## Database Operations

### INSERT
- Create new inspections.
- Add inspection details.
- Log replacement parts usage.

### UPDATE
- Correct efficiency readings.
- Modify power unit specifications.

### DELETE
- Remove incorrect inspection details.
- Delete incorrect warehouse log entries.

### SELECT
- Retrieve technician information.
- Generate inspection reports using SQL joins.

---

## Technologies Used

- C#
- Windows Forms
- SQL Server
- ADO.NET
- Entity Relationship Diagram (ERD)

---

## Database Entities

- EnergySite
- PowerUnit
- Technician
- Inspection
- InspectionDetails
- WarehouseInventory
- WarehouseLog

---

## Installation

1. Clone the repository:

```bash
git clone https://github.com/your-username/EnergyGrid-Management-System.git
```

2. Open SQL Server Management Studio.

3. Execute the database script.

4. Open the C# solution in Visual Studio.

5. Configure the SQL Server connection string.

6. Build and run the application.

---

## Project Structure

```text
EnergyGrid-Management-System
│
├── Database
│   └── EnergyGrid.sql
│
├── SourceCode
│   └── EnergyGrid.sln
│
└── README.md
```


## Project Purpose

This project was developed as part of the Database Systems course to demonstrate database design, SQL operations, and desktop application development using C# and SQL Server.

---

## License

This project is intended for educational purposes only.
