CREATE DATABASE SoftUni

USE SoftUni
GO

CREATE TABLE Towns(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(MAX) NOT NULL
)
GO

CREATE TABLE Addresses(
	Id INT PRIMARY KEY IDENTITY,
	AddresstText NVARCHAR(30) NOT NULL,
	TownId INT CONSTRAINT FK_Addresses_Towns FOREIGN KEY REFERENCES Towns(Id) NOT NULL
)
GO

CREATE TABLE Departments(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL
) 
GO

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	JobTitle NVARCHAR(30) NOT NULL,
	DepartmentId INT CONSTRAINT FK_Employees_Departments 
	FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATE NOT NULL,
	Salary DECIMAL NOT NULL, 
	AddressId INT CONSTRAINT FK_Employees_Addresses 
	FOREIGN KEY REFERENCES Addresses(Id) NOT NULL,
)
