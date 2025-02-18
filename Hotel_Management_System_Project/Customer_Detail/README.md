# CustomerDetails UserControl  

## Overview  
The `CustomerDetails` UserControl is a part of the **Hotel Management System**. It allows users to view and filter customer details based on different criteria such as all customers, checked-in customers, and checked-out customers.  

## Features  
- Displays customer details along with room information.  
- Allows filtering of data using a dropdown (`txtSearchBy`).  
- Retrieves data from a database and binds it to a `DataGridView`.  

## Technologies Used  
- C# (.NET Framework)  
- Windows Forms (`UserControl`)  
- SQL Database  

## Code Structure  
### `CustomerDetails.cs`  
- **Constructor:** Initializes the control.  
- **comboBox1_SelectedIndexChanged:** Fetches and updates customer data based on selected criteria.  
- **CustomerDetails_Load:** Handles form load events (currently empty).  

## Database Queries  
The system uses SQL queries to fetch customer details:  
- **All Customers:** Displays all customers with their room details.  
- **Checked-in Customers:** Filters records where `checkout` is `NULL`.  
- **Checked-out Customers:** Filters records where `checkout` is **not** `NULL`.  

## How to Use  
1. Add `CustomerDetails` to the Windows Forms project.  
2. Ensure the `function` class is properly implemented for fetching data.  
3. Select a filter from the dropdown to view relevant customer details.  

## Dependencies  
- A database with `customer` and `rooms` tables.  
- A `function` class with a `getData(query)` method to execute SQL queries.  

## Notes  
- The `CustomerDetails_Load` method is currently empty but can be used for initialization.  
- The `function` class should be properly configured to connect to the database.  

