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
        - strings
        - Arrays
        - classes
    - The main differences between value types and reference types.
        - Memory storage location: Value types are stored on the stack, while reference types are stored on the heap.
        - Copying behavior: Value types create a copy of the data when they are assigned or passed, while reference types use the same instance of the data when they are assigned or passed.
        - Equality comparison: Value types compare the data by value, while reference types compare the data by reference.
        - Immutability vs. mutability: Value types are immutable, which means that they cannot be changed after they are created, while reference types are mutable, which means that they can be changed after they are created.
        - Common use cases: Value types are used for simple and primitive data, such as numbers, booleans, and structs, while reference types are used for complex and dynamic data, such as objects, arrays, and classes.


- What are some collections available in C#? (Beyond List)
- How do we achieve Abstraction in C#?
- How do we achieve Encapsulation?
- How about Inheritance?
- Polymorphism in C#?
- What is overloading?
- What is overriding?
- What's the difference between overloading and overriding
- What are properties?
- What are fields?
- What are methods?
- What is constructor?
- Describe 4 commonly used access modifiers in C#
- what does static modifier do?
- (T/F) It is perfectly fine to always use the implicit typing instead of strongly typing my variables
- What is regular expressions? Give me some use cases for regex's.
- Bonus: What could be an regEx for validating the email address?
- What is unmanaged resource and how do you manage it?
- What is serialization?
- what are generic classes?
- what is boxing  and unboxing?
- what's a struct, and how is it different from class?
- What is lambda expression?
### Testing
- what do you use to unit test in C#?
- Describe AAA of unit testing
- What do you unit test?
- What do you NOT unit test?
### Design Principles
- Describe SOLID
- What is Singleton pattern, and when do we use it?
- what is factory method pattern, and when do we use it?
- what is dependency injection, and why do we use it?
- How is dependency injection differ from dependency inversion?
- what is separation of concerns principle?