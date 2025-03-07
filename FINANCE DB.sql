CREATE DATABASE FinanceDB
USE FinanceDB

CREATE TABLE Transactions (
    Id INT PRIMARY KEY IDENTITY,
    Category NVARCHAR(50),
    Amount DECIMAL(10,2),
    Date DATE,
    Description NVARCHAR(255)
)


select *from Transactions