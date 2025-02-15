# Hotel Management System

This is a simple Hotel Management System built using C# and Windows Forms, with a SQL Server database.

## Features
- User Signup
- User Login Authentication
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

## UI Components
- Textboxes for Username & Password
- Buttons for Login, Signup, and Exit
- Label for Error Message Display

## Usage
- Enter a username and password to sign up.
- Use the same credentials to log in.
- Successful login redirects to the Dashboard.
- Incorrect credentials display an error message.

## License
This project is for educational purposes only.

---
**Author:** [Talha Amin]  
**Date:** [12-03-2024]
