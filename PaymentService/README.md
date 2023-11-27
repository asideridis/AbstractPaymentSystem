# .NET Core Payment Processing Project

## Overview

This project demonstrates a .NET Core application for handling payment processing. It showcases the use of various design patterns and best practices in software architecture to achieve a flexible, maintainable, and scalable solution.

## Key Features

- Support for multiple payment methods (Credit Card, PayPal, Bank Transfer, etc.).
- Extensible architecture for adding new payment methods.
- Use of design patterns for effective problem-solving and scalability.

## Design Patterns Used

- **Strategy Pattern**: For handling different payment strategies.
- **Factory Pattern**: For creating instances of various payment strategies.
- **Template Method Pattern**: For defining a common payment process workflow with customizable steps.
- **Dependency Injection (DI)**: For managing dependencies.
- **SOLID Principles**: Ensuring that the application adheres to good object-oriented design principles.

## Building and Running the Project

### Prerequisites

- .NET 8 SDK (Ensure you have the .NET 8 SDK installed on your system)

### Steps

1. **Clone the Repository**: Clone or download this repository to your local machine.
2. **Navigate to the Solution**: Change directory to the root of the cloned repository.
3. **Build the Solution**: Run `dotnet build` to build the entire solution.
4. **Run the Console Application**: Navigate to `PaymentService.ConsoleApp` and run `dotnet run` to see the demonstration.

## Contributing

Contributions to enhance this project are welcome. Please follow the standard fork, branch, and pull request workflow.
