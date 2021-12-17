CREATE TABLE Department
(
    [EmployeeID] VARCHAR (10) FOREIGN KEY REFERENCES EmpDetails(EmployeeID),
    [Name] VARCHAR (10) NOT NULL, 
    [Location] NVARCHAR(70) NOT NULL,

);

CREATE TABLE Employee
(
    [EmployeeID] VARCHAR (10) FOREIGN KEY REFERENCES EmpDetails(EmployeeID),
    [FirstName] NVARCHAR (20) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
    [SSN] VARCHAR (10),
    [DeptID] NVARCHAR (50) NOT NULL,
);

CREATE TABLE EmpDetails
(
    [EmployeeID] VARCHAR (10) PRIMARY KEY,
    [Salary] NVARCHAR (20) NOT NULL,
    [Address] NVARCHAR(70),
    [Address 2] NVARCHAR(70),
    [City] NVARCHAR(40),
    [State] NVARCHAR(40),
    [Country] NVARCHAR(40),
    
);