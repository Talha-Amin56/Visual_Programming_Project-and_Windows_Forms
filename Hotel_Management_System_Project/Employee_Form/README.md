# Hotel Management System - Employee Module

## Overview
The `UC_Employee` User Control is a part of the Hotel Management System that handles employee-related functionalities such as registration, deletion, and displaying employee records.

## Features
- **Employee Registration**: Allows users to add new employees with details like name, mobile number, gender, email, username, and password.
- **Employee Deletion**: Enables the removal of employee records by providing their employee ID.
- **Employee Listing**: Displays employee records in a DataGridView.
- **Auto-Increment Employee ID**: Fetches the maximum employee ID and increments it for the next entry.
- **Report Generation**: Opens an `Employee_Report` form for generating reports.

## Technologies Used
- **C#** (.NET Framework)
- **Windows Forms (WinForms)**
- **SQL Database**

## Code Structure
### Main Methods
- `getMaxID()`: Retrieves the maximum employee ID from the database and increments it for the next employee.
- `setEmployee(DataGridView dgv)`: Fetches employee records and binds them to a DataGridView.
- `clearAll()`: Clears all input fields after registration.
- `btnRegister_Click()`: Handles employee registration and stores the details in the database.
- `btnDelete_Click()`: Deletes an employee record from the database based on the provided employee ID.

### Event Handlers
- `tabEmployee_SelectedIndexChanged()`: Loads employee data when switching between tabs.
- `UC_Employee_Load()`: Executes when the control loads to fetch the next available employee ID.
- `UC_Employee_Leave()`: Clears input fields when leaving the control.
- `button1_Click()`: Opens the `Employee_Report` form.

## Database Queries
- **Insert Query**: Adds a new employee to the `employee` table.
- **Delete Query**: Removes an employee record based on `eid`.
- **Select Query**: Retrieves all employee records for display.

## Usage
1. Navigate to the Employee Management section in the Hotel Management System.
2. Register a new employee by filling in the required fields and clicking **Register**.
3. View all employees in the **Employee List** tab.
4. Delete an employee by entering their ID and clicking **Delete**.
5. Generate an Employee Report by clicking **Report**.

## Notes
- Ensure database connectivity is properly configured.
- Modify SQL queries as needed based on your database schema.
- Error handling should be implemented for better stability.

## Author
- **Project Name**: Hotel Management System
- **Module**: Employee Management

