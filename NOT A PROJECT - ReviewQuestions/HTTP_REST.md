# HTTP, REST

## HTTP
- What does HTTP stand for? What is it?
	- HTTP stands for Hypertext Transfer Protocol. It's the foundation of data communication on the World Wide Web, allowing browsers and servers to communicate.

- Describe req/res cycle
	- The request-response cycle in HTTP involves a client sending a request to a server and the server responding to that request.

- Describe parts of HTTP Request and Response
	- Parts of an HTTP request include the method (GET, POST, etc.), URL, headers, and body. Parts of an HTTP response include status code, headers, and body.

- What is header?
	- A header is a part of an HTTP message that contains metadata about the message, such as the type of content being sent or received.

- what is method/request verb and give examples of them.
	- A method or request verb specifies the action the client wants to perform on a resource. Examples include GET (retrieve data), POST (submit data), PUT (update data), DELETE (remove data).

- What do you put in request body?
	- In the request body, you put data that you want to send to the server, often used in POST and PUT requests to send form data or JSON payloads.

- What is a response code?
	- A response code is a numeric status code returned by a server in response to an HTTP request.

- Describe 5 categories of response codes and what they mean in general
	- Informational (1xx) - indicates a provisional response while processing continues.
	- Success (2xx) - indicates that the request was successfully received, understood, and accepted.
	- Redirection (3xx) - indicates further action needs to be taken to complete the request.
	- Client Error (4xx) - indicates that the client has sent bad data or made an invalid request.
	- Server Error (5xx) - indicates that the server failed to fulfill a valid request.

## REST
- What is REST?
	- REST stands for Representational State Transfer. It's an architectural style for designing networked applications.

- What does it mean for an API to be RESTful?
	- For an API to be RESTful, it means it adheres to the principles of REST, including client-server architecture, statelessness, caching, a uniform interface, layered system, and optionally, code on demand.

- Describe the following guiding principles/constraints:
	- Client-Server: Separation of concerns between client and server.
	- Stateless: Each request from a client must contain all the information necessary to understand and fulfill it, without relying on context stored on the server.
	- Cache: Responses must be cacheable to improve performance and scalability.
	- Uniform Interface: Resources are uniquely identified and accessed via a standard interface, typically using URIs and HTTP methods.
	- Layered System: Components should be organized into layers, with each layer performing a specific function and hiding the complexity from other layers.
	- Code on Demand (optional): Servers can provide executable code to clients, such as JavaScript, to extend client functionality.
