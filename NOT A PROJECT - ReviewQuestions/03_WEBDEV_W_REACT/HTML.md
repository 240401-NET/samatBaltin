## HTML
- What is HTML?
    - HTML stands for Hypertext Markup Language. It's the standard markup language for creating web pages and web applications. HTML provides the structure for web documents by using various tags to define elements on a webpage.

- What are html tags? Give me examples of common tags
	- HTML tags are keywords surrounded by angle brackets (<>) used to define elements within an HTML document. Examples of common HTML tags include:
		- html: Defines the root of an HTML document.
		- head: Contains metadata about the HTML document.
		- body: Contains the content of the HTML document.
		- div: Defines a division or a section.
		- p: Defines a paragraph.
		- a: Defines a hyperlink.
		- img: Defines an image.
		- h1, ..., h6: Define headings of different levels.

- how are tags different from elements?
	- Tags are the markup syntax used to define elements in HTML, while elements consist of the opening tag, content, and closing tag combined. For example, ' p ' is a tag, while ' p>Hello</p ' is an element.

- What are the two main parts of an HTML document? What are their roles?
    - The two main parts of an HTML document are the <head> and <body>.
    - <head>: Contains metadata about the HTML document, such as title, links to stylesheets, scripts, and other information that is not displayed on the webpage.
    - <body>: Contains the content of the HTML document that is displayed in the browser, including text, images, links, forms, and other elements.

- what are attributes?
	- Attributes provide additional information about HTML elements and are defined within the opening tag of an element. They modify the behavior or appearance of an element. Examples of attributes include src in '<img' tag and href in ' a>' tag.

- What are global attributes?
	- Global attributes are attributes that can be used with any HTML element. Some common global attributes include id, class, style, title, lang, and data-*.
	
- What is the difference between id attribute and class attribute?
	- The id attribute is used to uniquely identify an HTML element within a document, while the class attribute is used to group elements together based on a common purpose or style.

- What is the difference between head , header, and heading?
	- head: Contains metadata about the HTML document, such as title, links to stylesheets, and scripts.
	- header: Typically used to define introductory content or navigation links at the top of a webpage.
	- h1, ..., h6: Define headings of different levels, with '<h1 ' being the most important and '<h6 ' being the least important.

- What is semantic tags? Why would we want to use them?
	- Semantic tags are HTML elements that convey meaning about the content they contain. They provide a clear structure to the document and improve accessibility and SEO. Examples of semantic tags include 'header', 'nav', 'article', 'section', 'footer', etc.

- How are forms created in HTML?
    - Forms are created using the <form> tag in HTML. The <form> tag encloses form elements such as input fields, buttons, checkboxes, and dropdown lists. Form elements use various input types and attributes to collect and submit data.

- How do we use forms to accept user input?
	- To accept user input, you can use the HTML <form> element along with various input elements like input, textarea, select, and button. These elements allow users to input data such as text, numbers, checkboxes, radio buttons, and submit buttons. When a user submits the form, the data is typically sent to a server for processing using HTTP methods like GET or POST.
	
- What are inline & block elements?
    - Inline elements: These elements do not start on a new line and only take up as much width as necessary. Examples include <span>, <a>, <strong>, and <em>.
    - Block elements: These elements start on a new line and take up the full width available. Examples include <div>, <p>, <h1> to <h6>, and <ul>.

- How are images created in HTML?
    - Images are created using the <img> tag in HTML. The <img> tag is a self-closing tag and requires the src attribute to specify the image file's path. Optionally, you can include attributes like alt for alternative text and width and height for specifying the image's dimensions.

- How are links created in HTML?
    - Links are created using the <a> (anchor) tag in HTML. The <a> tag requires the href attribute to specify the URL of the destination page. You can also include text or other HTML elements between the opening and closing <a> tags to create the clickable link.

- How are lists created in HTML?
    - Lists are created using the <ul> (unordered list) and <ol> (ordered list) tags in HTML.
    <ul>: Defines an unordered list, where list items are displayed with bullets.
    <ol>: Defines an ordered list, where list items are displayed with numbers or letters.
    List items are defined using the <li> (list item) tag within <ul> or <ol>.

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