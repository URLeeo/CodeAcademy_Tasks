CREATE DATABASE Course;

USE Course;

CREATE TABLE Teachers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Email NVARCHAR(100),
    Age INT,
    Salary DECIMAL(10,2)
);

INSERT INTO Teachers (Name, Surname, Email, Age, Salary) VALUES
('Alice', 'Johnson', 'alice@mail.ru', 30, 2000),
('Bob', 'Smith', 'bob@gmail.com', 40, 1500),
('Charlie', 'Brown', 'charlie@mail.ru', 35, 1200),
('Catherine', 'Davis', 'catherine@yahoo.com', 28, 3000),
('David', 'Wilson', 'david@mail.ru', 45, 5000),
('Carol', 'Taylor', 'carol@mail.ru', 32, 2500);


SELECT *
FROM Teachers
WHERE Age > (SELECT AVG(Age) FROM Teachers);

SELECT *
FROM Teachers
WHERE Salary BETWEEN 1000 AND 3000;

SELECT Name, Surname
FROM Teachers
WHERE Email LIKE '%@mail.ru';

SELECT *
FROM Teachers
WHERE Name LIKE 'C%';
