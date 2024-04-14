# SQL Questions
These questions are here to help you engage with the material. We will use these questions to review and to prepare for QC. 
Define following terms and answer the questions in your own words, using any resources.

### DB terms
- Relational database
	- A type of database that stores and organizes data in tables with rows and columns, and establishes relationships between these tables.

- SQL
	- SQL (Structured Query Language): A programming language used to manage and manipulate relational databases.

- SQL Sublanguages:
	- DDL (Data Definition Language): Used to define and modify the structure of database objects such as tables, views, and indexes.
	- DML (Data Manipulation Language): Used to manipulate data within the database, including inserting, updating, and deleting records.
	- DQL (Data Query Language): Used to retrieve data from the database.
	- DCL (Data Control Language): Used to control access to data within the database, including granting and revoking permissions.
	- TCL (Transaction Control Language): Used to manage transactions within the database, including committing and rolling back changes.

- Primary Key
	- A column (or combination of columns) in a table that uniquely identifies each row in the table.

- Foreign Key
	- A column or set of columns in one table that refers to the primary key in another table, establishing a relationship between the two tables.

- Candidate Key
	- A column or set of columns in a table that could potentially serve as the primary key.

- Composite Key
	- A primary key composed of multiple columns, used when a single column cannot uniquely identify each row in a table.

- tell me about normalization
	- The process of organizing data in a database to reduce redundancy and dependency, leading to improved data integrity and efficiency.
    - 1NF (First Normal Form): Each column contains atomic values, and each row is unique.
	- 2NF (Second Normal Form): Meets the criteria of 1NF and all non-key attributes are fully functionally dependent on the primary key.
	- 3NF (Third Normal Form): Meets the criteria of 2NF and has no transitive dependencies between non-key attributes.

- Referential Integrity
	- The concept of maintaining consistency between related tables in a database, typically enforced through foreign key constraints.

- Which keyword do I use to...
    - Create new table: CREATE TABLE
	- Create a new record in a table: INSERT INTO
	- Modify table structure: ALTER TABLE
	- Delete table: DROP TABLE
	- Modify existing row in a table: UPDATE
	- Delete a row: DELETE FROM
	- Drop all rows in a table w/o deleting the table: TRUNCATE TABLE

- What are some SQL dialects/vendors we have?
    - Various implementations of SQL by different database vendors such as MySQL, PostgreSQL, SQL Server, Oracle. The choice depends on the specific requirements and preferences of the project.

- What are constraints?
    - Rules applied to columns to enforce data integrity. Examples include PRIMARY KEY, FOREIGN KEY, UNIQUE, NOT NULL.

- Tell me about some common SQL data types
	- VARCHAR, INTEGER, FLOAT, DATE, TIMESTAMP, BOOLEAN.
- tell me about multiplicity and some examples
	- Describes the relationships between entities in a database, such as one-to-one, one-to-many, and many-to-many.

- tell me about identity keyword
	- Used to define a column in a table as an identity column, typically used for auto-incrementing primary keys.

- What is ERD?
	- ERD (Entity-Relationship Diagram): A visual representation of the relationships between entities in a database schema.

### Select statement
- Which Sublanguage is SELECT statement part of?
	- DQL (Data Query Language)

- Describe what each of the clause does
	- SELECT: Specifies the columns to be retrieved from the database.
	- FROM: Specifies the table or tables from which to retrieve the data.
	- WHERE: Filters the rows returned by the SELECT statement based on a specified condition.
	- GROUP BY: Groups the rows returned by the SELECT statement based on one or more columns.
	- HAVING: Filters the groups produced by the GROUP BY clause based on a specified condition.
	- ORDER BY: Sorts the rows returned by the SELECT statement based on one or more columns.

- how do I only get non-duplicate values?
	- Use the DISTINCT keyword after SELECT. For example, SELECT DISTINCT column_name FROM table_name.

- How do I limit the result to a certain number?
	- Use the LIMIT clause at the end of the SELECT statement. For example, SELECT * FROM table_name LIMIT 10; retrieves the first 10 rows from the table.

### Joins/Set Ops/Subqueries
- Joins
    - Inner Join: Returns rows when there is a match in both tables.
	- Left Join: Returns all rows from the left table and matching rows from the right table.
	- Right Join: Returns all rows from the right table and matching rows from the left table.
	- Full Join: Returns all rows when there is a match in either table.
	- Other joins: Cross Join, Self Join, Natural Join, Non-Equi Join.

- Set Operation
    - Union: Combines the results of two or more SELECT statements and removes duplicates.
	- Union all: Combines the results of two or more SELECT statements, including duplicates.
	- Intersect: Returns the intersection of the results of two or more SELECT statements.
	- Except: Returns the difference between the results of two SELECT statements.

- What is the difference between set operation and join?
	- Set operations combine the results of two or more queries into a single result set, while joins are used to retrieve data from multiple tables based on a related column between them.

- Subquery
    - Is a query nested inside another query.
    - Subqueries can be used in SELECT, INSERT, UPDATE, DELETE, and FROM clauses.

### Functions/Stored Procedures/Triggers/Cascades/Views/Index/Transactions
- What are functions?
	- Functions are reusable blocks of code that perform a specific task. They can accept parameters, perform calculations, and return a value.
    - Aggregate functions: Perform a calculation on a set of values and return a single value. 
		Examples include SUM, AVG, COUNT, MAX, MIN.
    - Take one or more values as input and return a single value.
		Examples include CONCAT, UPPER, LOWER.
	- The three different types of functions are Aggregate functions, Scalar functions, and Table-valued functions.

- What are stored procedures?
	- Stored procedures are precompiled SQL code that can be executed on demand. They allow for complex logic and business rules to be encapsulated within the database.
	- Difference between functions and stored procedures: Functions return a value, while stored procedures do not necessarily return a value. Functions can be used in SQL statements, whereas stored procedures are called using EXECUTE or CALL.
	- Stored procedures can perform DML (Data Manipulation Language) operations, such as INSERT, UPDATE, DELETE, which functions cannot do.
	- How do you write stored procedures?
		-- Create a stored procedure named GetEmployeeById
		CREATE PROCEDURE GetEmployeeById
    		@EmployeeId INT
		AS
		BEGIN
    	-- Select employee details based on the provided ID
    		SELECT * FROM Employees WHERE EmployeeId = @EmployeeId;
		END;

- What is index?
	- An index is a database object that improves the speed of data retrieval operations on a table by providing a fast way to look up data based on the values in specific columns.
	- Difference between clustered and non-clustered index: A clustered index determines the physical order of rows in a table, while a non-clustered index does not. A table can have only one clustered index, but multiple non-clustered indexes.
	- Best practices on using index: Index only on columns frequently used in WHERE clauses, avoid over-indexing, regularly maintain and update indexes.

- What is trigger?
	- A trigger is a database object that automatically executes in response to certain events, such as INSERT, UPDATE, DELETE operations on a table.
	- Types of triggers: BEFORE triggers and AFTER triggers.
	- How do you write triggers? Define the trigger's SQL code using the CREATE TRIGGER statement.
		CREATE TRIGGER UpdateAuditTrail
		ON Employees
		AFTER UPDATE
		AS
		BEGIN
			-- Insert a record into the AuditTrail table for each updated employee
			INSERT INTO AuditTrail (EmployeeId, Action, Timestamp)
			SELECT EmployeeId, 'UPDATE', GETDATE() FROM inserted;
		END;

	- When to use triggers: When you need to enforce business rules, maintain referential integrity, or log changes to the database.

- What is cascading? 
	- Cascading refers to the automatic propagation of actions from one table to another, typically when a related record is modified or deleted.
	- Types of cascades: Cascade update and cascade delete.
	- Best practices with cascades: Use with caution to avoid unintended consequences, such as data loss.

- What is view?
	- A view is a virtual table generated by a query. It represents a subset of data from one or more tables and is stored in the database.
	- How do you make views? Define a view's SQL query using the CREATE VIEW statement.
		-- Create a view named SalesSummary
		CREATE VIEW SalesSummary AS
		SELECT
			ProductName,
			SUM(Quantity) AS TotalQuantity,
			AVG(UnitPrice) AS AveragePrice
		FROM
			Sales
		GROUP BY
			ProductName;
	- When to use views: When you need to simplify complex queries, provide a customized view of data, or enforce

- What is transaction?
	- Transaction is a collection of SQL statements that either succeed or fail together/as a unit
	- You manage transactions with TCL sublaguage: transaction control language
		TCL ex: Commit, Savepoint, Rollback
	- Describe the 4 properties of transaction (ACID)
		- Atomicity : all statements in a transaction either succeeds or fails as a whole
		- Consistency : When a transaction commits, it should follow the rules in the db tables
		- Isolation : Transaction should be isolated and free from other sql operations
		- Durability : When the transaction commits, it's saved to a persistent/durable storage
	- What are isolation levels in transaction? What phenomena do we allow/not allow based on its level?
		Isolation Levels:
			- Read Uncommitted : allows all 3 phenomena
			- Read Committed : does not allow dirty read
			- Repeatable Read : does not allow dirty and non-repeatable read
			- Serializable : does not allow all 3 phenomena
		- What's the default for SQL Server?
			- The default isolation level for SQL Server is Read Committed.