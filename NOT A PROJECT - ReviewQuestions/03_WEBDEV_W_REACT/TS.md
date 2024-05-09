# Typescript

## Questions
- What is typescript? How is it different from javascript?
    - TypeScript is a superset of JavaScript that adds optional static typing, interfaces, enums, generics, and other features to JavaScript. TypeScript code is transpiled to JavaScript before execution. The main difference is that TypeScript provides static type checking at compile-time, which helps catch errors and provides better tooling support compared to JavaScript.
- What is the primary benefit typescript brings?
    - The primary benefit of TypeScript is its static typing system, which helps catch errors during development, provides better tooling support (like auto-completion and type inference), and improves code maintainability and scalability by enabling developers to define clear interfaces and enforce type safety.
- what is transpiling?
    - Transpiling is the process of converting source code from one programming language to another language with a similar level of abstraction. In the context of TypeScript, transpiling refers to converting TypeScript code to JavaScript code, allowing it to run in any JavaScript environment.
- how do you take a typescript file and turn it into js file?
    - You can transpile TypeScript code to JavaScript using the TypeScript compiler (tsc). You run the TypeScript compiler on your .ts files, and it generates equivalent .js files. You can do this via the command line using tsc filename.ts, or by configuring a build process in tools like Webpack or Gulp.
- what is tsconfig file?
    - tsconfig.json is a configuration file used to specify compiler options and project settings for the TypeScript compiler (tsc). It allows you to define compiler options such as target ECMAScript version, module system, output directory, and more.
- Describe special types that typescript has that javascript doesn't (any, unknown)
    - any: Represents a dynamic type that can hold any value. It essentially disables type checking for variables of this type.
    - unknown: Represents a type-safe counterpart of any. Variables of type unknown can hold any value, but you must perform type checks or type assertions before using them.
- How do you declare variables with types?
    - Variables in TypeScript can be declared with types using the syntax 'variableName: type'. For example: let age: number = 25;
- How do you declare functions with return types and parameter types?
    - function add(num1: number, num2: number): number {
        return num1 + num2;
    }
- How do you create custom types?
    - You can create custom types in TypeScript using the type keyword or the interface keyword. For example:
    // Using type keyword
    type Point = {
        x: number;
        y: number;
    };
    // Using interface keyword
    interface Point {
        x: number;
        y: number;
    }
- How about interfaces?
    - Interfaces in TypeScript are used to define contracts for object shapes. They can describe the properties and methods that an object must have. Interfaces are often used for type checking and ensuring consistency across objects.
- What is a union type?
    - A union type in TypeScript allows a variable to have one of multiple possible types. It is denoted using the pipe | symbol between the types. For example: number | string represents a type that can be either a number or a string.
- How does Typescript infer a type of an object (ducktyping)?
    - TypeScript uses a mechanism called "structural typing" or "duck typing" to infer types. It checks the shape of an object (i.e., the properties it has) rather than its explicit type annotation. If an object has all the required properties of a type, TypeScript will consider it compatible with that type.
- What are two different ways to cast in TS?
    - Type casting in TypeScript can be done using the as syntax or angle brackets < >. For example:
    - let strLength1: number = (someValue as string).length;
    - let strLength2: number = (<string>someValue).length;
- How do you type generics in TS?
    - Generics in TypeScript allow you to define functions, classes, or interfaces that work with a variety of types rather than a single specific type. You can define generics using angle brackets < > and specify the type parameter. For example:
    function identity<T>(arg: T): T {
        return arg;
    }
- Is TS strongly or weakly typed?
    - TypeScript is strongly typed, meaning it provides static type checking and enforces type safety at compile time.
- What are type guards?
    - Type guards are TypeScript expressions used to narrow down the type of a variable within a certain block of code. They are typically used with conditional statements to check the type of a variable and perform different actions based on its type.
    - function isNumber(value: any): value is number {
        return typeof value === 'number';
    }
- What features does TS introduce apart from strong typing & new datatypes?
    - Interfaces: TypeScript allows developers to define interfaces, which describe the structure of objects. Interfaces specify the properties and methods that an object must have, enabling better code documentation, type checking, and adherence to contracts.
    - Enums: TypeScript supports enums, which allow developers to define a set of named constants. Enums provide a way to represent a group of related values with descriptive names, improving code readability and maintainability.
    - Decorators: TypeScript supports decorators, which are a form of metadata attached to declarations like classes, methods, or properties. Decorators enable the addition of behavior or metadata to components at runtime, facilitating features like dependency injection, logging, and authentication.
- What are decorators?
    - Decorators: TypeScript supports decorators, which are a form of metadata attached to declarations like classes, methods, or properties. Decorators enable the addition of behavior or metadata to components at runtime, facilitating features like dependency injection, logging, and authentication.