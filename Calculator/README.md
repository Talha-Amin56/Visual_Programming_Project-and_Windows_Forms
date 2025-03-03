# Simple Calculator

This is a basic Windows Forms application built using C# that functions as a simple calculator. The application allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division.

## Features
- Allows input of numeric values.
- Supports basic arithmetic operations: Addition (+), Subtraction (-), Multiplication (*), and Division (/).
- Displays the current operation being performed.
- Clears the input field when needed.

## Code Explanation

### Global Variables
- `resultvalue`: Stores the first operand of the calculation.
- `operationperformed`: Stores the arithmetic operation selected by the user.
- `isoperationperformed`: Tracks whether an operation button was clicked to clear the textbox before entering a new number.

### Event Handlers

#### `button_click(object sender, EventArgs e)`
Handles the event when a number button is clicked. It appends the clicked number to the `textBox1` unless the text is "0" or a new operation was started, in which case it clears the textbox before appending.

#### `operator_click(object sender, EventArgs e)`
Handles the event when an operator (+, -, *, /) is clicked. It stores the current value from `textBox1` in `resultvalue` and sets the `operationperformed` variable to the clicked operator.

#### `button13_Click(object sender, EventArgs e)` (Equals `=` button)
Performs the calculation based on the stored `operationperformed` and updates `textBox1` with the result.

#### `button9_Click(object sender, EventArgs e)` (Clear button)
Clears the `textBox1` by setting its text to an empty string.

## How It Works
1. User enters a number.
2. User clicks an operator (+, -, *, /), which stores the number and operation.
3. User enters a second number.
4. User clicks the `=` button to display the result.
5. The Clear button (`C`) resets the input field

## Requirements
- .NET Framework
- Visual Studio (or any C# compatible IDE)

## Running the Application
1. Open the project in Visual Studio.
2. Build and run the application.
3. Use the UI buttons to perform calculations.

This project demonstrates basic Windows Forms event handling and simple calculator logic in C#.

