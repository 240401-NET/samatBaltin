# C# Questions
These questions are here to help you engage with the material. We will use these questions to review and to prepare for QC
### .NET Platform
- What is C#?
    - C# (C-sharp) is a cross-platform, open-source, object-oriented programming language developed by Microsoft. It's designed to work with the .NET platform, which is a software ecosystem for developing, compiling, and running application code. C# is used to create and use software components, including mobile applications, desktop applications, web applications, and games.

- What is .NET Platform?
    - .NET is a free, open-source framework for building applications and cloud services. It's supported on Linux, Windows, and macOS, and can be used to build apps for web, mobile, and desktop applications.

- What is Intermediary Language (IL)?
    - Intermediate language (IL) is a low-level language that is generated from programming source code during the compilation process. It is also known as bytecode, p-code, pseudocode, or pseudo language. IL is platform independent and can be run in any computer environment that has a runtime engine for the language. 

- what does .csproj file do?
    - csproj file tells dotnet how to build the ASP.NET application. It's one of the most important files in an ASP.NET project. An ASP.NET project can depend on third-party libraries developed by other developers. Usually, these libraries are installed as Nuget packages using Nuget package manager

- When do we use project reference?
    - Project references are used when referencing another project from another project in the same solution. For example, Tests

- What is a solution in .NET?
    - In Visual Studio .NET, a solution is a container that contains one or more related projects, along with build information, Visual Studio window settings, and any miscellaneous files that aren't associated with a particular project. A solution also contains information about the dependencies between those projects. 

### C# Basics
- Which method do I use to write something to the console?
    - Console.WriteLine()

- How about taking user input from the console?
    - Console.ReadLine()

- How do I take a string input and convert to integer and vice versa?
    - Convert.ToInt32(Console.ReadLine())
    - Convert.ToString(int);

- Why do we create methods? What are the benefits of compartmentalizing your code?
    - Methods promote code reusability, break down complex problems into smaller chunks, and save time by allowing sections of code to be repeated without retyping.
    - Some benefits of compartmentalizing code include: Parallel development, Faster process, Reduced risk of conflicts, Easier maintenance and debugging, and Easier scalability.

- What is an array? How do you initialize one?
    - Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
    - int[] array1 = [1, 2, 3, 4, 5, 6];
    - int[] array2 = new int[2, 3];

- What is variable declaration?
    - A variable declaration is when you specify a type and an identifier but have not yet assigned a value to the variable.
    - int a = 7; // Declaring and initializing the variable at same time
    - int x; // Declaring variable x

- What is variable initialization?
    - The term initializing means to assign some value to the variable.
    - x = 5; // initializing x with value 5

- What is the main method? Why is it important?
    - The Main method is the entry point of a C# program, where the program's control begins and ends. It is present in every C# executable file, and is the first method that is called when an application starts. 

- Why do we not see the main method after .NET 6?
    - In C# 9 they introduced top-level statements, which is new simplified entry point. It is a single file where you can just write commands without all the void Main hassle. It is compiled to an actual Main method by compiler.

- Debugger: What are breakpoints? What happens when the program hits the breakpoint?
    - A breakpoint instructs the debugger to stop at a particular code location in the user's program, returning control of the debugger to them. The user may then inspect the application's state.

- Debugger: What is step over, step into, step out?
    - When you choose to “step into” while debugging, you are instructing the debugger to enter the code of the current line if it is a function call. The debugger will pause the program’s execution at the first line of the called function, allowing you to examine the code inside that function.
    - When you choose to “step over” while debugging, the debugger will execute the current line of code and pause on the next line, without entering any function calls that might be present on the current line.
    - When you choose to “step out” while debugging, the debugger will continue the program’s execution until it exits the current function. It allows you to skip the remaining lines of the current function and return to the caller’s context.

- What are exceptions? Why do we use them?
    - exception handling features help you deal with any unexpected or exceptional situations that occur when a program is running.

- Describe Try/Catch/Finally
    - try – A try block encloses a section of code.
    - catch – When an exception happens, the code within the Catch block executes.
    - finally – The finally block enables the execution of specific code irrespective of exception.

### C# Intermediate
- What is class in C#?
    - A class is a data structure in C# that combines data variables and functions into a single unit. Instances of the class are known as objects. While a class is just a blueprint, the object is an actual instantiation of the class and contains data.

- What are the difference between Value types and Reference types?
    - Value types are data types that directly store data in a fixed amount of memory. They are stored on the stack, which is a region of memory that is allocated and deallocated automatically by the program. Value types are passed by value, which means that when they are assigned to a variable or passed to a method, a copy of the data is created and used.
        - All numeric data types
        - Boolean, Char, and Date
    - Reference types are data types that store references to data in a variable amount of memory. They are stored on the heap, which is a region of memory that is allocated and deallocated manually by the program. Reference types are passed by reference, which means that when they are assigned to a variable or passed to a method, the reference to the data is used, not the data itself.
        - strings: they can't be changed after they're created. All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.
        - Arrays
        - classes
    - The main differences between value types and reference types.
        - Memory storage location: Value types are stored on the stack, while reference types are stored on the heap.
        - Copying behavior: Value types create a copy of the data when they are assigned or passed, while reference types use the same instance of the data when they are assigned or passed.
        - Equality comparison: Value types compare the data by value, while reference types compare the data by reference.
        - Immutability vs. mutability: Value types are immutable, which means that they cannot be changed after they are created, while reference types are mutable, which means that they can be changed after they are created.
        - Common use cases: Value types are used for simple and primitive data, such as numbers, booleans, and structs, while reference types are used for complex and dynamic data, such as objects, arrays, and classes.


- What are some collections available in C#? (Beyond List)
    - C# has many collection types, including arrays, lists, dictionaries, sets, queues, and stacks. Some of these collections are:
        - List<T>: An indexable collection, meaning each element can be accessed using its index
        - HashSet: is an unordered collection of unique elements. It is generally used when we want to prevent duplicate elements from being placed in the collection.
        - ArrayList: A non-generic collection that contains data of any data type
        - Queue: A collection that serves items using the first-in, first-out (FIFO) principle
        - Stack: A collection that uses the last added element to be the first one to go
        - Dictionary<TKey,TValue>: A generic collection and a basic implementation of IDictionary<TKey, TValue>

- How do we achieve Abstraction in C#?
    - In C#, abstraction is implemented using abstract classes and methods. An abstract class is a class that cannot be instantiated, and must be inherited by a derived class in order to be used. Abstract classes are created using the abstract keyword, and can contain both abstract and non-abstract members.

- How do we achieve Encapsulation?
    - In C#, encapsulation is achieved through the use of access modifiers, such as "private," "protected," and "internal". These modifiers define the scope and visibility of a class member:
        - Private: Members can only be accessed within the class itself.
        - Protected: Members can be accessed within the class and any derived classes.
        - Internal: Members can be accessed within the same assembly.

- How about Inheritance?
    - inheritance is a key feature of Object-Oriented Programming (OOP) that allows you to create a new class from an existing class. 
        - class Animal { fields and methods }
        - class Dog : Animal{fields and methods of Animal and fields and methods of Dog }

- Polymorphism in C#?
    - Polymorphism in C# is a concept that allows a single interface to be used to refer to multiple implementations of a particular behavior. It occurs when multiple classes are related to each other by inheritance. For example, a base class called Animal could have a method called animalSound(), and derived classes of Animals could be Pigs, Cats, Dogs, or Birds. Each derived class could have its own implementation of animalSound(), and the base class method can be overridden by adding the virtual keyword to the method inside the base class.

- What is overloading?
    - Method overloading in C# is when a class has two or more methods with the same name but different parameters, numbers, or order.
        - Constructor
        - PlusMethod() that works for both int and double.

- What is overriding?
    - An override method provides a new implementation of the method inherited from a base class. 
        - animalSound()

- What's the difference between overloading and overriding?
    - overloading occurs when methods in the same class have the same method name but different parameters
    -  overriding occurs when two methods have the same method name and parameters.

- What are properties?
    - Properties are members of a class that encapsulate data and provide controlled access to it. They typically consist of a get accessor (getter) and a set accessor (setter) to read and modify the property's value.

- What are fields?
    - Fields are variables declared within a class or struct to store data. They represent the state of an object and can be accessed directly within the class.

- What are methods?
    - Methods are functions defined within a class or struct that perform specific actions or operations. They encapsulate behavior and can be called to execute their functionality.

- What is constructor?
    - A constructor is a special method used to initialize objects of a class. It is automatically called when an instance of the class is created and is responsible for initializing the object's state.

- Describe 4 commonly used access modifiers in C#
    - public: Accessible from any other code in the same assembly or another assembly.
    - private: Accessible only from within the same class or struct.
    - protected: Accessible only from within the same class or from derived classes.
    - internal: Accessible from any code in the same assembly but not from outside the assembly.

- what does static modifier do?
    - Static modifier: The static modifier indicates that a member belongs to the type itself rather than to instances of the type. It means the member is shared among all instances of the class and can be accessed directly using the class name.

- (T/F) It is perfectly fine to always use the implicit typing instead of strongly typing my variables
    - False. While implicit typing (var keyword) can improve code readability and maintainability in certain scenarios, it's essential to use it judiciously and maintain clarity and explicitness in code where necessary.

- What is regular expressions? Give me some use cases for regex's.
    - Regular expressions are patterns used to match character combinations in strings. They provide a powerful and flexible way to search, manipulate, and validate text data. Use cases include:
        - Validating input (e.g., email addresses, phone numbers)
        - Extracting data from strings (e.g., parsing log files)
        - Finding and replacing text (e.g., text processing)

- Bonus: What could be an regEx for validating the email address?
    - ^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$

- What is unmanaged resource and how do you manage it?
    - An unmanaged resource is a resource (such as memory, file handles, network connections) that is not managed by the .NET runtime's garbage collector. It requires manual management, including allocation, deallocation, and cleanup, to prevent resource leaks and ensure proper resource utilization.

- What is serialization?
    - Serialization is the process of converting an object into a format that can be easily persisted, transmitted, or stored, such as JSON, XML, or binary. It allows objects to be written to streams or files and reconstructed later.

- what are generic classes?
    - Generic classes are classes that are parameterized with one or more type parameters. They enable code reusability by allowing classes to be defined with placeholders for data types, making them more flexible and versatile.

- what is boxing  and unboxing?
    - Boxing is the process of converting a value type (e.g., int, double) into an object reference. Unboxing is the reverse process, converting an object reference back to a value type. These conversions involve copying the value from the stack to the heap (boxing) or from the heap to the stack (unboxing).

- what's a struct, and how is it different from class?
    - A struct is a value type that represents a lightweight data structure. It is similar to a class but is typically used for small, simple data types. Unlike classes, structs are value types and are typically used for immutable data types or when memory allocation overhead needs to be minimized.

- What is lambda expression?
    - A lambda expression is an anonymous function that can be used to create delegates or expression tree types. It provides a concise syntax for writing inline functions without explicitly defining a separate method.

### Testing
- what do you use to unit test in C#?
    - NUnit, MSTest, xUnit.net are commonly used frameworks for unit testing in C#.

- Describe AAA of unit testing
    - AAA stands for Arrange, Act, and Assert, representing the three phases of a unit test.
        - Arrange: Set up the test environment, including creating objects and initializing variables.
        - Act: Execute the code being tested.
        - Assert: Verify that the expected behavior occurred and the outcome is as expected.

- What do you unit test?
    - Unit tests should focus on testing individual units of code, such as methods or functions, in isolation. They should verify the behavior of the unit under different conditions and edge cases.

- What do you NOT unit test?
    - Unit tests should not depend on external dependencies, such as databases, network connections, or file systems. Integration tests are more suitable for testing interactions between components or external systems.

### Design Principles
- Describe SOLID
    - SOLID is a set of five design principles in object-oriented programming:
    - Single Responsibility Principle
    - Open/Closed Principle
    - Liskov Substitution Principle
    - Interface Segregation Principle
    - Dependency Inversion Principle

- What is Singleton pattern, and when do we use it?
    - The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. It is typically used when exactly one object is needed to coordinate actions across the system.

- what is factory method pattern, and when do we use it?
    - The Factory Method pattern defines an interface for creating objects but allows subclasses to alter the type of objects that will be created. It is commonly used when a class cannot anticipate the class of objects it must create.

- what is dependency injection, and why do we use it?
    - Dependency injection is a design pattern in which dependencies of a class are provided from the outside rather than created internally. It promotes loose coupling between components and facilitates unit testing and maintainability.

- How is dependency injection differ from dependency inversion?
    - Dependency inversion is a principle that states high-level modules should not depend on low-level modules but should depend on abstractions. It decouples modules by allowing them to depend on interfaces or abstract classes rather than concrete implementations.

- what is separation of concerns principle?
    - The Separation of Concerns principle states that a class or module should have a single responsibility and should not be responsible for multiple unrelated tasks. It promotes modular design and maintainability by isolating different concerns.
