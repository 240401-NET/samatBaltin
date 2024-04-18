# ASP.NET Core
- What is ASP.NET Core?
	- ASP.NET Core is a cross-platform, open-source framework for building modern, cloud-based, and internet-connected applications.

- What is Controller in asp.net core?
	- A controller in ASP.NET Core is a C# class that handles incoming HTTP requests, executes the appropriate logic, and returns an HTTP response.

- How does controller based routing work?
	- Controller-based routing in ASP.NET Core maps incoming HTTP requests to controller actions based on route templates defined in the controllers.

- how do you create end points in asp.net core?
	- Endpoints in ASP.NET Core are created by defining routes that map HTTP requests to controller actions.

- What is appsettings.json? Why do we have appsettings.json and appsettings.Development.json?
	- appsettings.json is a configuration file used in ASP.NET Core to store application settings. appsettings.Development.json is used specifically for development environment settings, allowing for different configurations in different environments.

- How do you achieve dependency injection in asp.net core?
	- Dependency injection in ASP.NET Core is achieved by registering dependencies in the ConfigureServices method of the Startup class and then injecting them into controllers and other components.

- What are middlewares? Where do you configure them?
	- Middlewares in ASP.NET Core are components that handle requests and responses in the HTTP pipeline. They are configured in the Configure method of the Startup class.

- What are filters?
	- Filters in ASP.NET Core are attributes or classes that can be applied to controller actions or globally to the MVC pipeline to perform cross-cutting concerns such as logging, validation, or authorization.

- What is Model binding?
	- Model binding in ASP.NET Core is the process of mapping data from HTTP requests to action method parameters or model properties.

- How do you utilize Data Annotations to enhance Model Binding?
	- Data Annotations are attributes applied to model properties to specify validation rules, formatting options, or other metadata used by model binding.

- How do you configure a route to...
	- To configure a route to accept a route parameter, you define a route template with a placeholder for the parameter in the controller's route attribute. 
	- To accept query parameters, you can define parameters in the action method signature.
	- To accept JSON as a request body, you can use the [FromBody] attribute on the action method parameter.

- How do you set up memcache in ASP.NET Core?
	- To set up memcache in ASP.NET Core, you can use a library like Microsoft.Extensions.Caching.Memcached and configure it in the ConfigureServices method of the Startup class.

- What is CORS, and how do you configure it?
	- CORS (Cross-Origin Resource Sharing) is a security feature that controls access to resources from different origins. You can configure CORS in ASP.NET Core using the CORS middleware in the Configure method of the Startup class.

- What is Authentication and Authorization, and how are they different?
	- Authentication is the process of verifying the identity of a user, while authorization is the process of determining whether a user has permission to access a resource. In ASP.NET Core, authentication and authorization are implemented using middleware components and policies configured in the ConfigureServices method of the Startup class.
