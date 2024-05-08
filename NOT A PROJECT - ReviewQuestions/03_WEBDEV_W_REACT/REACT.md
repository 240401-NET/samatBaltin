## Node
- What is node? Why is it used?
    - Node.js, commonly referred to as Node, is an open-source, cross-platform JavaScript runtime environment that executes JavaScript code outside of a web browser. It allows developers to build server-side and networking applications using JavaScript, a language traditionally used for client-side scripting in web browsers. Node.js uses an event-driven, non-blocking I/O model, making it lightweight and efficient for handling concurrent requests and real-time applications like chat servers, APIs, and microservices.

- What is npm?
    - npm stands for Node Package Manager. It is the default package manager for Node.js, used to install, manage, and share JavaScript packages and dependencies. npm provides access to a vast ecosystem of open-source libraries and tools that help developers build and manage JavaScript applications more efficiently. Developers can use npm to install packages locally within their projects or globally on their system, manage project dependencies, and execute various package-related commands.

- What is npx?
    - npx is a command-line tool bundled with npm version 5.2.0 and higher. It stands for "Node Package Runner" and is used to execute Node.js packages directly from the npm registry without installing them globally or locally. npx simplifies the process of running packages and scripts, allowing developers to execute commands without worrying about conflicting versions or dependencies. It also provides a way to run one-time commands without polluting the global package namespace.

- What is package.json?
    - package.json is a metadata file used in Node.js projects to define project settings, dependencies, scripts, and other configuration details. It contains information about the project, such as its name, version, description, author, license, and dependencies required for development and production. package.json also includes scripts that automate common tasks, such as building, testing, and running the project. It serves as a central source of project configuration and is essential for managing Node.js applications and their dependencies.

- What is node_modules?
    - node_modules is a directory created by npm to store locally installed dependencies for a Node.js project. When npm installs packages listed in the project's package.json file, it places them in the node_modules directory along with their dependencies. This directory serves as a repository for all project-specific dependencies and their versions. Node.js applications automatically look for required modules in the node_modules directory, allowing developers to manage dependencies efficiently and ensure consistent behavior across different environments.


## React Basics
- What is a component?
    - A component is a reusable, self-contained building block of a React application that encapsulates a piece of UI (User Interface). Components can be thought of as custom HTML elements with their own logic and styling. They help in organizing the UI into smaller, manageable pieces, making the codebase more modular, maintainable, and scalable.

- What is the structure of a functional component?
    - A functional component in React is a JavaScript function that returns JSX (JavaScript XML), describing the UI elements to be rendered. It typically follows this structure:
    - const MyComponent = (props) => {
        return (
            <div>
                {/* JSX content */}
            </div>
        );
    };
    export default MyComponent;
    -Functional components accept props (short for properties) as arguments, which are data passed down from parent components. They are simpler and more concise compared to class components and are often preferred for their readability and ease of use.

- What is special about the App.tsx file?
    - The App.tsx file, or App component, is a special component in a React application as it serves as the root component of the entire application. It acts as the entry point for rendering other components and organizing the overall structure of the UI. The App component is typically responsible for managing the main layout, routing, and state at the highest level of the application hierarchy.

- What is the virtual DOM?
    - The virtual DOM (Document Object Model) is a concept in React that represents a lightweight, in-memory copy of the actual DOM. It is a programming abstraction that React uses to optimize and efficiently update the UI.
    - When changes are made to the state or props of a component in a React application, React doesn't immediately update the real DOM. Instead, it first updates the virtual DOM, comparing it with the previous version to determine the minimal set of changes needed to update the actual DOM. This process is known as reconciliation.
    - By using the virtual DOM, React minimizes the number of manipulations needed to update the UI, resulting in faster rendering and better performance. Additionally, the virtual DOM abstraction allows React to work efficiently across different platforms and environments, making it suitable for building complex and interactive web applications.


## React SPA
- What is an SPA? What are the advantages and disadvantages?
    - SPA stands for Single Page Application. It is a web application that dynamically updates the content on a single web page, without the need for page reloading during usage. Advantages of SPAs include improved user experience, faster navigation, and reduced server load due to fewer requests. However, SPAs may face challenges with initial load times, SEO (Search Engine Optimization) optimization, and browser history management.

- What is routing?
    - Routing in the context of a React application refers to the process of determining which UI components to display based on the current URL or location. It enables navigation within the application by mapping URLs to specific components or views.

- How is a new route set up?
    - In React, a new route can be set up using a routing library like React Router. First, you define route paths and their corresponding components using Route components provided by React Router. Then, you wrap your application with a Router component and specify the type of routing (e.g., BrowserRouter, HashRouter). Finally, you navigate between routes using Links or programmatically using useHistory or withRouter hooks.

- React state management
    - State management in React refers to the management of component state, which represents data that can change over time. It involves initializing, updating, and accessing state data within React components. State management techniques include using the useState hook for functional components or this.state for class components.

- What are props?
    - Props (short for properties) are a mechanism for passing data from parent components to child components in React. They are read-only and allow components to be customizable and reusable by accepting input data from their parent components.

- What is state?
    - State in React is an internal data storage mechanism that allows components to manage and maintain their own data. State represents the current condition or values of a component and can be updated over time in response to user interactions or other events.

- Are props mutable? Is state mutable?
    - Props are immutable and cannot be directly modified within a component. State, on the other hand, is mutable and can be updated using setState method (for class components) or useState hook (for functional components) to trigger re-rendering of the component.

- What is context? Why is it used?
    - Context in React is a feature that allows data to be passed through the component tree without having to pass props manually at every level. It is primarily used to share global data or state between components that are not directly related. Context provides a convenient way to manage application-wide data and avoid prop drilling.

- How is data sent from a parent component to a child component?
    - Data is sent from a parent component to a child component in React by passing it as props to the child component when it is rendered. The parent component specifies the data as attributes in the JSX tag of the child component.

- How is data sent from a child component to a parent component (name of the technique & how it’s done)
    - Data can be sent from a child component to a parent component in React using callbacks. The parent component passes a function as a prop to the child component. The child component then invokes this function, passing the data as an argument, which allows the parent component to receive and handle the data. This technique is often referred to as "lifting state up" or "callback props."


## React rendering
- What is JSX?
    - JSX (JavaScript XML) is an extension of JavaScript syntax that allows for the embedding of HTML-like code within JavaScript. It enables developers to write UI components using a syntax similar to HTML, making React code more readable and expressive. JSX is transpiled into regular JavaScript by tools like Babel before being rendered in the browser.

- What does it mean when there are curly braces { } in the return statement of a component?
    - When curly braces { } are used in the return statement of a component in React, it indicates that JavaScript expressions should be evaluated within the JSX code. This allows dynamic content, such as variables, functions, or expressions, to be included in the rendered output of the component.

- How can you display a variable on your site in React (one-way binding)?
    - In React, you can display a variable on your site using curly braces { } within JSX code. For example:
    - const myVariable = 'Hello, World!';
    function MyComponent() {
    return (
        <div>
        {myVariable}
        </div>
    );}

- What is conditional rendering?
    - Conditional rendering in React refers to the practice of rendering different UI components or content based on certain conditions or criteria. It allows developers to display different parts of the UI dynamically, depending on the state of the application or user interactions.

- How do I display an array of items as individual components in React?
    - You can display an array of items as individual components in React by using the map() function to iterate over the array and return a new array of React components. Each item in the original array corresponds to a React component in the new array, which can then be rendered in the component's JSX code.

- What are lists & keys in react?
    - In React, a list is a collection of elements or components rendered dynamically based on an array of data. Each item in the array corresponds to a component in the list. Keys are special attributes assigned to list items to help React identify which items have changed, been added, or been removed. Keys should be unique within the list and remain stable across re-renders.

- When does a component re-render?
    - A component in React re-renders when its state or props change. React automatically detects changes in state or props and triggers a re-render of the component and its children to update the UI accordingly. Additionally, a component can be forced to re-render manually by calling the forceUpdate() method, though this approach is generally discouraged in favor of using state and props to manage component updates.


## Data & Event binding
- How is data binding done in React (one way binding)?
    - In React, data binding (one-way binding) refers to the process of passing data from a parent component to a child component via props. The parent component defines the data and passes it down to the child component as props. The child component receives the data through its props and can use it to render its UI. However, the child component cannot directly modify the data it receives; it can only read and display it.
    - function ParentComponent() {
    const data = 'Hello from Parent';
    return (
        <div>
        <ChildComponent message={data} />
        </div>
    );}
    function ChildComponent(props) {
    return (
        <div>
        <p>{props.message}</p>
        </div>
    );}

- How is event binding done in React?
    - Event binding in React involves attaching event handlers to DOM elements or React components to handle user interactions, such as clicks, keypresses, or form submissions. Event handlers are functions that are executed when a specific event occurs. In class components, event handlers are typically defined as methods of the component class and bound to the component instance using the this keyword. In functional components, event handlers are defined as arrow functions or functions passed as props.
    - function MyComponent() {
    const [inputValue, setInputValue] = useState('');

    const handleChange = (event) => {
        setInputValue(event.target.value);
    };
    return (
        <div>
        <input type="text" value={inputValue} onChange={handleChange} />
        <p>You typed: {inputValue}</p>
        </div>
    );}

- How can you retrieve input box data in React?
    - In React, you can retrieve input box data by using controlled components, where the value of the input element is controlled by React state. This involves setting the value attribute of the input element to a state variable and providing an onChange event handler to update the state when the input value changes. Here's an example of how to retrieve input box data in React using controlled components:
    - function MyComponent() {
    const [inputValue, setInputValue] = useState('');
    const handleChange = (event) => {
        setInputValue(event.target.value);
    };
    return (
        <div>
        <input type="text" value={inputValue} onChange={handleChange} />
        <p>You typed: {inputValue}</p>
        </div>
    );}


## React hooks
- What are hooks?
    - Hooks are functions that enable React components to use state and other React features without writing a class. They allow you to reuse stateful logic across different components, making it easier to manage state and side effects in functional components. Some commonly used hooks include:
    1. useState: Allows functional components to manage state.
    2. useEffect: Performs side effects in functional components (e.g., data fetching, subscriptions, DOM manipulation) after render.
    3. useContext: Provides access to the context object.
    4. useReducer: A more powerful alternative to useState, often used for managing complex state logic.
    5. useCallback: Memoizes callback functions to prevent unnecessary re-renders.
    6. useMemo: Memoizes computed values to improve performance.
    7. useRef: Provides a mutable ref object to persist values between renders.

- What does useEffect do?
    - useEffect is a built-in hook in React that allows you to perform side effects in functional components. It replaces lifecycle methods like componentDidMount, componentDidUpdate, and componentWillUnmount in class components. useEffect accepts a function as its first argument, which will be executed after the component renders. You can also specify dependencies as a second argument to control when the effect runs.
    - function MyComponent() {
    const [data, setData] = useState(null);
    useEffect(() => {
        // Fetch data from an API
        axios.get('https://api.example.com/data')
        .then(response => {
            setData(response.data);
        })
        .catch(error => {
            console.error('Error fetching data:', error);
        });
    }, []); // Empty dependency array means the effect runs once after initial render
    return (
        <div>
        {/* Display fetched data */}
        {data && <p>{data}</p>}
        </div>
    );}

- What does setState do?
    - setState is a method used in class components to update the component's state. When you call setState, React schedules an update to the component's state and re-renders the component with the updated state. It can take an object containing new state values or a function that returns the new state based on the previous state.
    class MyComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
        count: 0
        };}

    incrementCount = () => {
        // Update count using setState
        this.setState({ count: this.state.count + 1 });};

    render() {
        return (
        <div>
            <p>Count: {this.state.count}</p>
            <button onClick={this.incrementCount}>Increment</button>
        </div>
        );
    }}

- what is axios?
    - Axios is a popular JavaScript library used for making HTTP requests from both the browser and Node.js environments. It provides an easy-to-use interface for performing asynchronous operations, such as sending and receiving data from web servers and APIs.
    axios.get('https://api.example.com/data')
    .then(response => {
        console.log('Data:', response.data);
    })
    .catch(error => {
        console.error('Error:', error);
    });

- what is jest?
    - Jest is a popular JavaScript testing framework developed by Facebook. It is designed to make testing JavaScript code, particularly React applications, easy and efficient. Jest is widely used in the JavaScript community for writing unit tests, integration tests, and end-to-end tests for web applications.

- what is shallow rendering?
    - Shallow rendering is a testing technique used in React to render a component without rendering its child components. It allows you to isolate the component you are testing and focus on its behavior without worrying about the behavior of its children. Shallow rendering is often used for unit testing to keep tests focused and avoid unnecessary complexity.

- what is mocking (conceptual)?
    - Mocking is a technique used in software development and testing to replace real objects with simulated objects, known as mocks. Mocks mimic the behavior of real objects but allow you to control their behavior and responses for testing purposes. Mocking is commonly used in unit testing to isolate the code being tested from its dependencies and ensure predictable and reliable test results.