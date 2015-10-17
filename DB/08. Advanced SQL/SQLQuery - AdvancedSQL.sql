-- 1. Write a SQL query to find the names and salaries of the employees that
-- take the minimal salary in the company. Use a nested SELECT statement.

USE TelerikAcademy

SELECT FirstName + ' ' + LastName, Salary 
FROM Employees
WHERE Salary =
	(SELECT MIN(Salary) FROM Employees)

-- 2. Write a SQL query to find the names and salaries of the employees that
-- have a salary that is up to 10% higher than the minimal salary for the company.

SELECT FirstName + ' ' + LastName, Salary 
FROM Employees
WHERE Salary <
	(SELECT MIN(Salary) FROM Employees) * 1.1
ORDER BY Salary

-- 3. Write a SQL query to find the full name, salary and department of the employees that-- take the minimal salary in their department. Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS FullName, e.Salary, d.Name
FROM Employees e
	INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE Salary =
	(SELECT MIN(Salary) FROM Employees
	 WHERE DepartmentID = d.DepartmentID)
ORDER BY Salary 

-- 4. Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS 'Average Salary'
 FROM Employees 
WHERE DepartmentID = 1

-- 5. Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(Salary) AS 'Average Salary'
	FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 6. Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(*) AS 'Employees Count in ''Sales'''
	FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 7. Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(*) AS 'Employees with a Manager'
FROM Employees e, Employees m
WHERE e.EmployeeID = m.ManagerID

-- 8. Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(*) AS 'Employees with no Manager'
	FROM Employees e
WHERE e.ManagerID IS NULL

-- 9. Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name AS 'Department', AVG(Salary) AS 'Average Salary'
FROM Employees e
	JOIN Departments d 
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.

SELECT COUNT(*) AS 'Employee Count', d.Name AS 'Department', t.Name AS 'Town'
FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, t.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT m.FirstName, m.LastName
FROM Employees e
	JOIN Employees m
	ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(m.EmployeeID) = 5

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName +' '+ e.LastName AS 'Employee',
	 ISNULL(m.FirstName +' '+m.LastName, 'no manager') AS 'Manager'
FROM Employees e
	LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

SELECT FirstName +' '+ LastName AS 'Employee'
FROM Employees
WHERE LEN(LastName) = 5

-- 14. Write a SQL query to display the current date and time in the following format -- "day.month.year hour:minutes:seconds:milliseconds".
-- Search in Google to find how to format dates in SQL Server.

SELECT CONVERT(VARCHAR(50),GETDATE(),104)+' '+CONVERT(VARCHAR(50),GETDATE(),114) AS[Date and time]

-- 15. Write a SQL statement to create a table Users.
-- Users should have username, password, full name and last login time.
-- Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
-- * Define the primary key column as identity to facilitate inserting records.
-- * Define unique constraint to avoid repeating usernames.
-- * Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users (
  UserID int IDENTITY PRIMARY KEY,
  Username nvarchar(50) NOT NULL UNIQUE,
  Pass nvarchar(20) NOT NULL CHECK (LEN(Pass) > 5),
  FullName nvarchar(80) NOT NULL,
  LastLoginTime datetime
)
GO

-- 16. Write a SQL statement to create a view that displays the users from the Users table that -- have been in the system today. Test if the view works correctly.

CREATE VIEW UsersfromToday AS
SELECT *
FROM Users
WHERE CONVERT(VARCHAR(10), LastLoginTime, 102) <= CONVERT(VARCHAR(10), GETDATE(), 102)