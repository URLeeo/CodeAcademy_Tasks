CREATE DATABASE Company;
USE Company;

CREATE TABLE Users(
	Id INT,
	[Name] NVARCHAR(50),
	Surname NVARCHAR(50),
	Age INT,
	Email NVARCHAR(50)
);

INSERT INTO Users (Name, Surname, Age, Email)
VALUES 
('Ali', 'Aliyev', 25, 'ali@example.com'),
('Aysel', 'Memmedova', 19, 'aysel@example.com'),
('Kamran', 'Huseynov', 30, 'kamran@example.com'),
('Nigar', 'Ismayilova', 17, 'nigar@example.com'),
('Orxan', 'Quliyev', 22, 'orxan@example.com');


UPDATE Users SET Id = 1 WHERE Name = 'Ali';
UPDATE Users SET Id = 2 WHERE Name = 'Aysel';
UPDATE Users SET Id = 3 WHERE Name = 'Kamran';
UPDATE Users SET Id = 4 WHERE Name = 'Nigar';
UPDATE Users SET Id = 5 WHERE Name = 'Orxan';


SELECT * FROM Users;


SELECT * FROM Users
WHERE Age < 20;
