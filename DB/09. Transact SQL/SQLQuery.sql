-- 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id
-- (PK), PersonId(FK), Balance).
-- Insert few records for testing.
-- Write a stored procedure that selects the full names of all persons.
-- * Database created with SQL Management Studio

USE TSQL_Homework
GO
/*
CREATE PROC usp_SelectFullNamesOfAllPersons
AS
	SELECT FirstName + ' ' + LastName AS 'FullName' 
	FROM Persons
GO
 */
EXEC usp_SelectFullNamesOfAllPersons
-- 2. Create a stored procedure that accepts a number as a parameter and returns all persons who -- have more money in their accounts than the supplied number.
/*
CREATE PROC usp_PersonsWithMoreMoneyThanParam(
	@amount money = 0)
AS
	SELECT p.FirstName + ' ' + p.LastName AS 'FullName', a.Balance 
	FROM Persons p
	JOIN Accounts a
	ON p.PersonID = a.PersonID
	WHERE a.Balance > @amount
GO
 */
EXEC usp_PersonsWithMoreMoneyThanParam 100
-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of 
-- months. It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.
/*
CREATE FUNCTION ufp_interestFunc(
	@sum money, @yearlyInterestRate decimal, @months int) RETURNS MONEY
AS
	BEGIN
		RETURN @sum + (@sum * (@yearlyInterestRate / 12 / 100) * @months)
	END
GO
*/
SELECT Balance, dbo.ufp_interestFunc(Balance, 0.5, 2) AS 'Current Balance'
FROM Accounts
-- Apparently functions work only with the prefix 'dbo'

-- -4. Create a stored procedure that uses the function from the previous example to give an -- interest to a person's account for one month.
-- It should take the AccountId and the interest rate as parameters.
/*
CREATE PROC dbo.usp_interestFunc2(
	@accountID int, @yearlyInterestRate decimal)
AS

DECLARE @answer money = 
	(SELECT Balance FROM Accounts WHERE PersonID = @accountID)

SELECT Balance, dbo.ufn_interestFunc(Balance, @yearlyInterestRate, 1) - @answer AS [Current 
Interest]
FROM Accounts
WHERE AccountID = @accountId
GO
*/
EXEC dbo.usp_interestFunc2 1, 2
-- 5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, -- money) that operate in transactions.
/*
CREATE PROC usp_WithdrawMoney(
	@id int, @cash money)
AS
	UPDATE Accounts
	SET Balance -=@cash
	WHERE AccountID = @id
GO

CREATE PROC usp_DepositMoney(
	@id int, @cash money)
AS
	UPDATE Accounts
	SET Balance +=@cash
	WHERE AccountID = @id
GO
*/

BEGIN TRAN
	EXEC usp_WithdrawMoney 3, 100
	EXEC usp_DepositMoney 3, 200
ROLLBACK TRAN

-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
-- Add a trigger to the Accounts table that enters a new entry into the Logs table every time the -- sum on an account changes.

USE TSQL_Homework
/*
CREATE TABLE Logs (
LogsID INT IDENTITY,
AccountID INT NOT NULL,
OldSum MONEY NOT NULL,
NewSum MONEY NOT NULL,
CONSTRAINT PK_LogsID PRIMARY KEY (LogsID),
CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountID)
	REFERENCES Accounts(AccountID)
)
*/
