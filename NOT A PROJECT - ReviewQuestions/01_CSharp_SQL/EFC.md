# Entity Framework Core

- What is an ORM? What's the purpose of it?
	- An ORM (Object-Relational Mapper) is a programming technique that allows developers to map object-oriented domain models to relational database schemas. Its purpose is to simplify the interaction between an application's business logic and the underlying database by abstracting away the complexities of SQL queries and database interactions.

- What is DbContext class in EF Core?
	- DbContext class in Entity Framework Core is a crucial component that acts as a bridge between the application and the database. It represents a session with the database and allows for querying, saving, and managing entity instances.

- What are 2 ways of connecting your DB to code?
	-Two ways of connecting your database to code in Entity Framework Core are Database-First Approach and Code-First Approach:
		- Database-First is used when you already have an existing database schema and want to generate entity classes from it
		- Code-First is used when you want to define your entity classes first and then generate the database schema from them.

- What is migration?
	- Migration in Entity Framework Core is a way to manage changes to the database schema over time. It allows you to incrementally update the database to match changes made to the entity classes or DbContext.

- What is DbSet?
	- DbSet in Entity Framework Core represents a collection of entities in the context, typically corresponding to a database table.

- What does OnModelCreating method do?
	- OnModelCreating method in DbContext class is used to configure the model that is mapped to the database. It allows you to specify entity configurations, relationships, and other mapping details using Fluent API or data annotations.

- How do you add/update/delete/query data from DB using ef core?
	- To add/update/delete/query data from the database using Entity Framework Core, you use LINQ (Language Integrated Query) to write queries against DbSet properties exposed by the DbContext class. For example, you can use methods like Add, Update, Remove, and LINQ operators like Where, Select, and Join.

- How do you do "join" tables when querying your data in EF Core?
	- To perform joins when querying data in EF Core, you use LINQ's Join method or navigation properties defined in your entity classes to navigate relationships between entities.

- what does savechanges method do?
	- SaveChanges method in Entity Framework Core is used to persist changes made to entities in the context to the database. It executes INSERT, UPDATE, and DELETE statements necessary to synchronize the state of entities with the database.
	