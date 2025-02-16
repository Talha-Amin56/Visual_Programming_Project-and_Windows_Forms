# UC_CustomerCheckOut

## Description
`UC_CustomerCheckOut` is a user control module for a Hotel Management System developed in C#. It manages customer checkouts by retrieving and displaying customer and room details, allowing the user to confirm checkouts, update the database, and free up booked rooms.

## Features
- Fetches customer and room details from the database.
- Allows searching for customers by name.
- Displays customer information in a DataGridView.
- Enables customer checkout with a confirmation prompt.
- Updates customer checkout status and room availability in the database.
- Clears form fields after checkout.

## Dependencies
- .NET Framework
- Windows Forms (`System.Windows.Forms`)
- A `function` class for database operations
- SQL Database with `customer` and `rooms` tables

## Database Queries Used
- `SELECT` query to retrieve customer and room data.
- `UPDATE` query to mark customers as checked out and update room availability.

## Usage
1. Load the control to display customers who have not yet checked out.
2. Search for a customer by name.
3. Select a customer from the list to populate details.
4. Click the `Check Out` button to confirm checkout.
5. The system updates the database and clears the form.

## Author
- Talha Amin

## License
This project is open-source and can be modified as per requirements.

