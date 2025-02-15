# Hotel Management System

This is a simple Hotel Management System built using C# and Windows Forms, with a SQL Server database.

## Features
- User Signup
- User Login Authentication
- Room Management
- Customer Registration
- Dashboard Access
- Basic Error Handling

## Technologies Used
- C# (Windows Forms)
- SQL Server (Database)

## Database Connection
The application connects to a SQL Server database using the following connection string:
```csharp
con.ConnectionString = "data source=DESKTOP-IPD12LT;Initial Catalog=myHotel;integrated security=True";
```

## How to Run
1. Clone the repository.
2. Open the project in Visual Studio.
3. Configure the database connection string if necessary.
4. Run the application.

## Functions
### 1. **connect()**
Establishes a connection to the SQL Server database.

### 2. **insert()**
Inserts a new user into the `signup` table after validating input fields.

### 3. **match()**
Checks login credentials against stored values in the database and grants access if correct.

### 4. **clear()**
Clears the input fields after signup or login attempts.

### 5. **UC_AddRoom_Load()**
Loads room data from the database into the DataGridView.

### 6. **button1_Click()**
Validates input fields and inserts a new room into the `rooms` table.

### 7. **UC_CustomerRegisteration_Load()**
Handles customer registration functionality.

### 8. **setComboBox()**
Fills combo boxes with available room data from the database.

### 9. **btnAlloteRoom_Click()**
Allocates a room to a customer and updates the `rooms` table accordingly.

### 10. **clear()**
Clears the input fields in the `UC_CustomerRegisteration` UserControl.

## UI Components
- Textboxes for Username, Password, Room No, Type, Bed, Price, Customer Details, etc.
- Buttons for Login, Signup, Add Room, Allocate Room, and Exit
- DataGridView for displaying room data
- ComboBoxes for selecting Room Type and Bed Type
- Label for Error Message Display

## Usage
- Enter a username and password to sign up.
- Use the same credentials to log in.
- Successful login redirects to the Dashboard.
- Incorrect credentials display an error message.
- Add rooms by providing room details and clicking the "Add Room" button.
- Register customers by filling in their details and allocating a room.

## License
This project is for educational purposes only.

---
**Author:** [Talha Amin]  
**Date:** [14-03-2024]

