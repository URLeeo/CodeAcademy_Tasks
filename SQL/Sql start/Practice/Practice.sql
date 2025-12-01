CREATE DATABASE Practice;
USE Practice;

CREATE TABLE PracticeTest(
	Id INT,
	[Name] NVARCHAR(50),
	Surname NVARCHAR(50),
	Age INT,
	Email NVARCHAR(50)
);

INSERT INTO PracticeTest (Id, [Name], Surname, Age, Email)
VALUES 
(1,'Ali', 'Aliyev', 25, 'ali@example.com'),
(2,'Aysel', 'Memmedova', 19, 'aysel@example.com'),
(3,'Kamran', 'Huseynov', 30, 'kamran@example.com'),
(4,'Nigar', 'Ismayilova', 17, 'nigar@example.com'),
(5,'Orxan', 'Quliyev', 22, 'orxan@example.com');


SELECT * FROM PracticeTest;


SELECT * FROM PracticeTest
WHERE Age < 20;
