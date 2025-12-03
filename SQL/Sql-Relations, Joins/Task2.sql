CREATE DATABASE CompanyForTask;

USE CompanyForTask;



CREATE TABLE Countries (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100)
);


CREATE TABLE Cities (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    CountryId INT FOREIGN KEY REFERENCES Countries(Id)
);


CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Surname NVARCHAR(100),
    Age INT,
    Salary DECIMAL(10,2),
    Position NVARCHAR(100),
    IsDeleted BIT,
    CityId INT FOREIGN KEY REFERENCES Cities(Id)
);


INSERT INTO Countries (Name) VALUES ('Azerbaijan'), ('Turkey');

INSERT INTO Cities (Name, CountryId)
VALUES ('Baku', 1), ('Ganja', 1), ('Istanbul', 2);

INSERT INTO Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId)
VALUES 
('Aslan', 'Mammadov', 25, 2500, 'Developer', 0, 1),
('Leyla', 'Aliyeva', 30, 1800, 'Reseption', 0, 2),
('Orxan', 'Quliyev', 28, 2200, 'Reseption', 1, 3);




SELECT e.Name, e.Surname, c.Name AS City, co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id;



SELECT e.Name, e.Surname, co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.Salary > 2000;


SELECT c.Name AS City, co.Name AS Country
FROM Cities c
JOIN Countries co ON c.CountryId = co.Id;


SELECT e.Name, e.Surname, e.Age, e.Salary, e.Position, e.IsDeleted
FROM Employees e
WHERE e.Position = 'Reseption';


SELECT e.Name, e.Surname, c.Name AS City, co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.IsDeleted = 1;

