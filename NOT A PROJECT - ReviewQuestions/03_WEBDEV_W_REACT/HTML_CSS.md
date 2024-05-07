# HTML_CSS
## HTML
- What is HTML, and what do we use html for?
	- HTML stands for Hypertext Markup Language. It is the standard markup language for creating web pages and web applications. HTML is used to structure the content of web pages by defining different elements and their relationships.
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
- How do we use forms to accept user input?
	- To accept user input, you can use the HTML <form> element along with various input elements like input, textarea, select, and button. These elements allow users to input data such as text, numbers, checkboxes, radio buttons, and submit buttons. When a user submits the form, the data is typically sent to a server for processing using HTTP methods like GET or POST.


## CSS
- What is CSS? What's the purpose of CSS in a webpage?
	- CSS stands for Cascading Style Sheets. It is a style sheet language used for describing the presentation of a document written in HTML. CSS controls the layout, formatting, and appearance of elements on a webpage. 
	- Its purpose is to separate the content of a webpage from its presentation, allowing for greater flexibility and control over the visual aspects of the website.
- what are selectors?
	- Selectors are patterns used to select and style HTML elements on a webpage. They specify which elements the CSS rules should apply to. Selectors can target elements based on their tag names, classes, IDs, attributes, or their relationship with other elements in the document.
- What are rules?
	- In CSS, rules consist of two main parts: selectors and declarations. Selectors specify the elements to which the styles should be applied, and declarations define the styles themselves. Declarations are made up of property-value pairs, where the property is the aspect of the element being styled (such as color, font-size, margin), and the value is the specific styling applied to that property (such as red, 16px, 10px). Multiple declarations can be grouped within curly braces ({ }) and separated by semicolons (;).
- Describe following types of selectors and their syntax:
	- Tag selector: Targets HTML elements based on their tag name.
		- Syntax: tagname { styles }
	- Class selector: Targets HTML elements based on their class attribute.
		- Syntax: .classname { styles }
	- Id selector: Targets HTML elements based on their id attribute.
		- Syntax: #idname { styles }
	- Pseudo class selectors: Targets elements based on their state or position.
		- Syntax: selector:pseudo-class { styles }
	- Combination selectors: Combines multiple selectors to target specific elements.
		- Syntax: selector1 selector2 { styles }
- Describe box model
	- The box model in CSS describes the layout and design of elements on a webpage. It consists of four main components: content, padding, border, and margin. These components define the dimensions and spacing of an element within its containing block.
		- Content:
			The actual content of the HTML element, such as text, images, or other media.
			It is surrounded by padding, border, and margin.
- What is responsive web design
- Play this game: https://flexboxfroggy.com/
- Play this game: https://cssgridgarden.com/
- What do we mean by cascading in CSS?
- What is specificity in CSS?
