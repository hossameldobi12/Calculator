# C# Calculator

A simple console-based calculator built with C# and .NET as part of the Simulation Academy .NET Diploma.

## Features

* Accepts two numbers from the user.
* Supports addition (`+`), subtraction (`-`), multiplication (`*`), and division (`/`).
* Displays the calculation result clearly.
* Validates user input and handles invalid numbers.
* Prevents division by zero.
* Allows users to perform multiple calculations without restarting the application.
* Handles invalid operators with a clear error message.

## Technologies Used

* **Language:** C#
* **Framework:** .NET
* **Application Type:** Console Application
* **IDE:** Visual Studio
* **Version Control:** Git and GitHub

## Getting Started

### Prerequisites

* [Visual Studio](https://visualstudio.microsoft.com/) with the .NET desktop development workload, or the [.NET SDK](https://dotnet.microsoft.com/download).
* Git (optional, if you want to clone the repository).

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/YOUR-USERNAME/calculator.git
   ```

2. Navigate to the project directory:

   ```bash
   cd calculator
   ```

3. Open the `.csproj` file in Visual Studio.

### Run the Application

Run the project using **Ctrl + F5** in Visual Studio.

Alternatively, run it from the terminal:

```bash
dotnet run
```

## Example

```text
=== Simple Calculator ===
Enter first number: 10
Enter operator (+, -, *, /): +
Enter second number: 5
Result: 15
Perform another calculation? (y/n): y
```

## Error Handling

The application handles common input errors, including:

* Invalid numeric input.
* Unsupported mathematical operators.
* Division by zero.

## Screenshot

The following screenshot demonstrates the calculator running.

![Calculator Screenshot](screenshots/calculator.png)

> Replace the example screenshot path with the actual location of your screenshot.

## Git Workflow

The project follows a feature-branch workflow to keep development organized.

* `feature/basic-calculator` — Implement the basic calculator operations.
* `feature/input-validation` — Handle invalid input and division by zero.
* `docs/update-readme` — Add and improve project documentation.

The completed changes are merged into the `main` branch.

## Author

**Hossam Eldubai**

* GitHub: [@hossameldobi12](https://github.com/hossameldobi12)
* LinkedIn: [Hossam Eldubai](https://www.linkedin.com/in/hossam-eldubai-749433257/)

## License

This project was created for educational purposes as part of the Simulation Academy .NET Diploma.
