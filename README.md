# RazorPage-StatsCalculator
RazorPage calculator dotnet csharp level 3 lab 1 
# ASP.NET Razor Page: Statistics Calculator

This project is a simple **ASP.NET Razor Page**. The application calculates and displays basic statistics for up to three numerical inputs provided by the user.

## Features

- **User Input**: Accepts up to three numerical inputs through text boxes.
- **Statistics Calculation**: Computes and displays:
  - Maximum
  - Minimum
  - Total
  - Average (to two decimal places)
- **Input Validation**:
  - Ignores blank or non-numerical inputs.
  - Displays a message if no valid numbers are entered.
- **Data Persistence**: Retains user inputs after displaying the results.

## How It Works

1. **Initial Load**: The web page presents three text boxes for the user to input numbers and a `Calculate` button.
2. **Input Processing**:
   - When the user clicks `Calculate`, the app processes the inputs:
     - Non-numerical inputs are ignored.
     - Blank fields are excluded from the calculation.
   - If no valid inputs are provided, an error message is displayed.
3. **Statistics Display**:
   - The calculated statistics (max, min, total, and average) are shown below the form.
   - User inputs remain visible in the text boxes.

## Screenshots

### Initial View
![Initial View](path/to/initial-view-screenshot.png)

### Valid Inputs
![Valid Inputs](path/to/valid-inputs-screenshot.png)

### Invalid Inputs
![Invalid Inputs](path/to/invalid-inputs-screenshot.png)

## Project Structure

The project consists of the following key files:
- `Index.cshtml`: The main Razor page for user interaction.
- `Index.cshtml.cs`: The PageModel code-behind file for processing input and calculating statistics.
- `launchSettings.json`: Configures the development environment for the project.

## Requirements

To run this application, you need:
- **.NET SDK**: Version 6.0 or higher.
- A modern web browser (e.g., Chrome, Edge, Firefox).

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   cd your-repo-name
