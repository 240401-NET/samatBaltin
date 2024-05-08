## HTML
- What is HTML?
    - HTML stands for Hypertext Markup Language. It's the standard markup language for creating web pages and web applications. HTML provides the structure for web documents by using various tags to define elements on a webpage.
- What are inline & block elements?
    - Inline elements: These elements do not start on a new line and only take up as much width as necessary. Examples include <span>, <a>, <strong>, and <em>.
    - Block elements: These elements start on a new line and take up the full width available. Examples include <div>, <p>, <h1> to <h6>, and <ul>.
- What are the two main parts of an HTML document? What are their roles?
    - The two main parts of an HTML document are the <head> and <body>.
    - <head>: Contains metadata about the HTML document, such as title, links to stylesheets, scripts, and other information that is not displayed on the webpage.
    - <body>: Contains the content of the HTML document that is displayed in the browser, including text, images, links, forms, and other elements.
- How are images created in HTML?
    - Images are created using the <img> tag in HTML. The <img> tag is a self-closing tag and requires the src attribute to specify the image file's path. Optionally, you can include attributes like alt for alternative text and width and height for specifying the image's dimensions.
- How are links created in HTML?
    - Links are created using the <a> (anchor) tag in HTML. The <a> tag requires the href attribute to specify the URL of the destination page. You can also include text or other HTML elements between the opening and closing <a> tags to create the clickable link.
- How are lists created in HTML?
    - Lists are created using the <ul> (unordered list) and <ol> (ordered list) tags in HTML.
    <ul>: Defines an unordered list, where list items are displayed with bullets.
    <ol>: Defines an ordered list, where list items are displayed with numbers or letters.
    List items are defined using the <li> (list item) tag within <ul> or <ol>.
- How are forms created in HTML?
    - Forms are created using the <form> tag in HTML. The <form> tag encloses form elements such as input fields, buttons, checkboxes, and dropdown lists. Form elements use various input types and attributes to collect and submit data.
- What features were introduced in HTML5?
    - HTML5 introduced several new features and enhancements, including:
    - Semantic elements like <header>, <footer>, <nav>, <article>, <section>, and <aside>.
    - New form input types such as <input type="email">, <input type="url">, <input type="date">, etc.
    - Multimedia elements like <audio> and <video> for embedding audio and video content.
    - Canvas and SVG for drawing graphics and animations directly within the browser.
    - Offline storage capabilities using localStorage and sessionStorage.
    - Geolocation API for accessing the user's geographical location.
    - WebSockets and WebRTC for real-time communication between clients.
    - Improved support for accessibility and internationalization.

## CSS
- What are the 3 ways to introduce CSS styling to a site? Which is generally preferable?
    - The three ways to introduce CSS styling to a site are:
        1. Inline CSS: Adding styles directly to HTML elements using the style attribute.
        2. Internal CSS: Including CSS rules within the <style> element in the <head> section of an HTML document.
        3. External CSS: Linking an external CSS file to an HTML document using the <link> element.
    External CSS is generally preferable as it separates the styling from the HTML content, making it easier to manage and maintain styles across multiple pages.
- In what order do these 3 ways get prioritized?
    - Inline CSS has the highest priority and will override styles defined in external or internal CSS.
    - Internal CSS has the second-highest priority and will override styles defined in external CSS.
    - External CSS has the lowest priority and will be overridden by styles defined in inline or internal CSS.
- What are some of the selectors used in CSS?
    - Type selectors (e.g., p, h1, div)
    - Class selectors (e.g., .classname)
    - ID selectors (e.g., #idname)
    - Attribute selectors (e.g., [type="text"])
    - Pseudo-classes (e.g., :hover, :nth-child())
    - Pseudo-elements (e.g., ::before, ::after)
- How do I select elements by their id?
    - You can select elements by their id using the # symbol followed by the id name. For example: #myId { styles }.
- How do I select elements by their class?
    - You can select elements by their class using the . symbol followed by the class name. For example: .myClass { styles }.
- How do I select elements by their type?
    - You can select elements by their type (tag name) directly. For example: p { styles }.
- How do CSS rules get selected when there are multiple conflicting rules?
    - When there are multiple conflicting rules, CSS rules are selected based on specificity, where more specific selectors take precedence over less specific ones. If specificity is the same, the order of the rules in the CSS file determines which one is applied last.
- Can you describe the CSS box model?
    - The CSS box model describes the layout and design of elements on a webpage. It consists of four main components: content, padding, border, and margin. These components define the dimensions and spacing of an element within its containing block.
- What does responsive web design mean?
    - Responsive web design is an approach to web development aimed at creating web pages that provide an optimal viewing experience across a wide range of devices and screen sizes. It involves designing and coding websites to automatically adjust and adapt their layout, content, and functionality based on the device's screen size, orientation, and capabilities. The goal of responsive web design is to ensure that websites look and function well on desktop computers, laptops, tablets, and smartphones, without the need for separate designs or development efforts for each device.


## Typescript
- What is TS?
- Is TS strongly or weakly typed?
- Why should TS be used?
- What datatypes are introduced in TS which are not in JS?
- What are union types?
- What are type guards?
- What features does TS introduce apart from strong typing & new datatypes?
- What are decorators?

## Node
- What is node? Why is it used?
- What is npm?
- What is npx?
- What is package.json?
- What is node_modules?

## React Basics
- What is a component?
- What is the structure of a functional component?
- What is special about the App.tsx file?
- What is the virtual DOM?

## React SPA
- What is an SPA? What are the advantages and disadvantages?
- What is routing?
- How is a new route set up?
- React state management
- What are props?
- What is state?
- Are props mutable? Is state mutable?
- What is context? Why is it used?
- How is data sent from a parent component to a child component?
- How is data sent from a child component to a parent component (name of the technique & how it’s done)

## React rendering
- What is JSX?
- What does it mean when there are curly braces { } in the return statement of a component?
- How can you display a variable on your site in React (one-way binding)?
- What is conditional rendering?
- How do I display an array of items as individual components in React?
- What are lists & keys in react?
- When does a component re-render?

## Data & Event binding
- How is data binding done in React (one way binding)?
- How is event binding done in React?
- How can you retrieve input box data in React?

## React hooks
- What are hooks?
- What does useEffect do?
- What does setState do?
- what is axios?
- what is jest?
- what is shallow rendering?
- what is mocking (conceptual)?