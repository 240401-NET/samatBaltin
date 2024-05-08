# Javascript

## Questions
### Asynchronous JS



## Javascript
- What is JS?
    - JavaScript (JS) is a high-level, interpreted programming language primarily used for adding interactivity and dynamic behavior to web pages. It is one of the core technologies of the World Wide Web, alongside HTML and CSS.
- Is JS strongly or loosely typed?
    - JavaScript is loosely typed, meaning variables do not require explicit declaration of data types and can hold values of any data type.
- What are the datatypes of JS?
    - JavaScript has six primitive data types: string, number, boolean, null, undefined, and symbol (added in ES6). Additionally, JavaScript also has one complex data type: object.
- What are the different ways to declare variables in JS?
    - Variables in JavaScript can be declared using var, let, or const keywords.
- What is the difference between var and let?
    - var has function scope, whereas let has block scope. Variables declared with let are only accessible within the block they are declared in, whereas variables declared with var are accessible throughout the function in which they are declared.
- What's the difference between let and const?
    - let: Variables declared with let can be reassigned a new value, but they cannot be re-declared within the same block scope.
    - const: Constants declared with const cannot be reassigned a new value after initialization, and they cannot be re-declared within the same block scope. However, they do not prevent mutation of objects or arrays that they reference.
- How is a JS script attached to an HTML file?
    - A JavaScript file can be linked to an HTML file using the <script> tag. You can specify the src attribute to link an external JavaScript file, or you can include JavaScript code directly within <script> tags in the HTML file.
- What are the scopes featured in JS?
    - Global Scope: Variables declared outside of any function have global scope and can be accessed from anywhere within the script.
    - Function Scope: Variables declared within a function have function scope and can only be accessed within that function.
    - Block Scope: Variables declared with let and const have block scope and can only be accessed within the block (enclosed by curly braces) they are defined in.
- What is type coercion?
    - Type coercion is the automatic conversion of data types by JavaScript during operations. It can occur when operands of different data types are used together in an operation.
- What are truthy and falsy values?
    - In JavaScript, values that are considered "truthy" evaluate to true when converted to a Boolean, whereas values that are considered "falsy" evaluate to false. Examples of falsy values include false, 0, "" (empty string), null, undefined, and NaN.
- What is the difference between == and ===?
    - == is the equality operator in JavaScript, which performs type coercion before comparing two values. === is the strict equality operator, which does not perform type coercion and checks both the value and the data type.
- What are some of the different ways to interact with Arrays in JS?
    - Some common array methods in JavaScript include push(), pop(), shift(), unshift(), splice(), slice(), concat(), join(), indexOf(), includes(), map(), filter(), reduce(), and forEach().
- What is the DOM?
    - The Document Object Model (DOM) is a programming interface for web documents. It represents the structure of an HTML document as a tree of objects, allowing JavaScript to access and manipulate the elements and content of a webpage.
- How do you select something from the DOM in Javascript?
    - You can select elements from the DOM using various methods such as getElementById(), getElementsByClassName(), getElementsByTagName(), querySelector(), and querySelectorAll().
- List the steps to have new elements appear on a webpage
    - Select the target element: document.getElementById(body)
    - Create the new element: document.createElement(<p>)
    - Insert the new element into the DOM: appendChild()
- What is bubbling and capturing?
    - Event bubbling and event capturing are two phases of event propagation in the DOM. During event bubbling, the event is first captured by the innermost element and then propagated up to the outermost ancestor. During event capturing, the event is captured by the outermost ancestor first and then propagated down to the innermost element.
- What is the event loop in JS?
    - The event loop is a mechanism in JavaScript that handles asynchronous tasks and callbacks. It continuously checks the call stack for any pending tasks and executes them in a non-blocking manner.
- What do async and await do in JS?
    - async and await are keywords introduced in ES8 (ES2017) for asynchronous programming. They provide a cleaner syntax for working with asynchronous code, making it appear more synchronous and easier to understand.
- What is a callback function?
    - A callback function is a function passed as an argument to another function, which is then invoked inside the outer function to complete some kind of action or operation.
- What is an event listener and why do we use it?
    - An event listener is a function that listens for a specific event to occur on an HTML element, such as a click, mouseover, or keypress event. Event listeners are used to trigger actions or execute code in response to user interactions with the webpage.
- List at least 5 web browser events
    - click: Occurs when a mouse click is detected on an element.
    - submit: Occurs when a form is submitted.
    - load: Occurs when the entire page, including its dependencies such as stylesheets and images, has finished loading.
    - mouseover: Occurs when the mouse pointer moves over an element.
    - keydown: Occurs when a keyboard key is pressed.
- What is hoisting?
    - Hoisting is a JavaScript behavior where variable and function declarations are moved to the top of their containing scope during the compilation phase, regardless of where they are declared in the code.
- What does ‘strict mode’ do?
    - Strict mode is a feature introduced in ES5 that enables a stricter set of parsing and error handling rules in JavaScript. It helps catch common coding mistakes and prevents certain unsafe actions, promoting cleaner and more robust code.
- What features were introduced in ES6?
    - ES6 (ECMAScript 2015) introduced many new features to JavaScript, including let and const for variable declarations, arrow functions, classes, template literals, destructuring assignment, default parameters, rest and spread operators, and more.
- What are arrow functions?
    - Arrow functions are a concise syntax for writing function expressions in JavaScript. They provide a more concise and readable way to define anonymous functions, and they have lexical this binding.
- What are template literals?
    - Template literals are a new type of string literal introduced in ES6. They allow for easier string interpolation by allowing embedded expressions and multi-line strings.
- What are spread & rest operators?
    - The spread operator (...) is used to expand an iterable (like an array) into individual elements, while the rest parameter (...) is used to collect multiple elements into a single array.
- What do you use to make HTTP calls in javascript?
    You can use the fetch() API or third-party libraries like Axios methods to make HTTP calls (such as GET, POST, PUT, DELETE)
- What is a promise?
    - A promise is an object representing the eventual completion or failure of an asynchronous operation. It allows you to handle asynchronous code more cleanly and provides better error handling and chaining compared to traditional callback-based approaches.
    - Promises have two main methods: then() for handling success cases and catch() for handling error cases. You can chain multiple then() methods to handle multiple asynchronous operations sequentially, and the catch() method at the end to handle any errors that occur during the chain.
- What are closures?
    - Closures are a fundamental concept in JavaScript that allows functions to maintain access to variables from their lexical scope even after the parent function has finished executing. They are created every time a function is created and allow for the preservation of state in JavaScript.
- How is JSON different from javascript objects?
    - JSON (JavaScript Object Notation) is a lightweight data interchange format that is primarily used to transmit data between a server and a web application. It is a text-based format that closely resembles JavaScript object literal syntax, but it is distinct from JavaScript objects.
    - JSON is a string representation of data, while JavaScript objects are actual JavaScript data structures that can include various types of data, including functions, whereas JSON does not support functions.
    - JSON syntax is limited to simple data structures like objects and arrays, while JavaScript objects can have more complex structures and methods.
    - JSON keys must be enclosed in double quotes, while JavaScript object keys can be unquoted or enclosed in single quotes.
- How do you create class defn in javascript?
    - class MyClass {
        // Class methods and properties go here
    }
- How do you create constructor in class defn?
    - class MyClass {
        constructor(param1, param2) {
            this.param1 = param1;
            this.param2 = param2;
        }
    }
- How do you define class fields? (!the syntax is quite a bit different from C#!)
    - Class field is a feature introduced in ECMAScript 2022 (ES12), and its syntax is indeed quite different from C#. It provide a more concise way to declare and initialize class properties compared to the traditional constructor-based approach.
    - class MyClass {
        // Class field with default value
        field1 = 'default';

        // Constructor
        constructor(param1, param2) {
            this.param1 = param1;
            this.param2 = param2;
        }
    }