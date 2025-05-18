CREATE DATABASE Music
USE Music

--A
CREATE TABLE Singers
(
Id INT PRIMARY KEY,
[Name] NVARCHAR(64),
Songs INT,
[Rank] INT,
Networth INT
)

--B
INSERT INTO Singers(Id, [Name],Songs,[Rank], Networth)
VALUES	(1,'Ivan Ivanov', 50,1,1000000),
(2,'Maria Ivanova', 55,3,900000),
(3,'Georgi Georgiev', 20,4,800000),
(4,'Gergana Petrova ', 55,2,1000000),
(5,'Boris Borisov ', 20,5,900000)

--C
SELECT TOP(3) [Name], [Rank]
FROM Singers
ORDER BY [Rank]

--D
SELECT Sum(Songs), AVG(Networth)*1.95583
FROM Singers

--E
UPDATE Singers
SET Networth=Networth*1.1
WHERE [Rank] BETWEEN 2 AND 4
