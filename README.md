# Design Patterns - Iterator

This repository showcases an implementation of the Iterator design pattern in C#. The code demonstrates how to traverse a collection without exposing its internal structure, promoting a clean and maintainable design.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Iterator design pattern is a behavioral pattern that allows sequential access to elements in a collection without exposing its underlying representation. It helps decouple the collection logic from the iteration logic, promoting better code organization.

## Implementation Overview
This repository provides a C# implementation of the Iterator design pattern. Key components of the code include:

- **IIterable Interface**: Defines the contract for collections that need an iterator.
- **IIterator Interface**: Specifies methods for iteration, such as `HasNext()` and `Next()`.
- **ItemCollection Class**: Represents the collection and provides an iterator.
- **ItemIterator Class**: A concrete implementation of `IIterator` for iterating over `ItemCollection`.
- **Program Class**: Demonstrates how to use the Iterator pattern in a client application.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Iterator.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Iterator
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Iterator pattern in action.
3. Modify or extend the `ItemCollection` or `ItemIterator` class to simulate different scenarios.

### Example Output:
```
Iterating over the collection:
Item 1
Item 2
Item 3
Item 4
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.
