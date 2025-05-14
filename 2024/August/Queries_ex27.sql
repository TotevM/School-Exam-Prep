CREATE DATABASE Travel

--A
CREATE TABLE Countries
(
Id INT PRIMARY KEY IDENTITY,
[Name] Varchar(30)
)

--B
CREATE TABLE Destinations
(
Id INT PRIMARY KEY IDENTITY,
Town VARCHAR(30),
Distance INT,
Duration INT,
Price DECIMAL(10,2),
CountryId INT FOREIGN KEY REFERENCES Countries(Id)
)

--C
INSERT INTO Countries([Name])
VALUES ('France'),
( 'Germany'),
('Italy'),
( 'Spain'),
( 'Austria')


--D
INSERT INTO Destinations(Town, Distance,Duration,Price,CountryId)
VALUES ('Paris', 2169,4,1800.00,1),
('Berlin', 4006,6,2100.00,2),
('Rome', 1666,3,1500.00,3),
('Madrid', 2966,7,1800.00,4),
('Milan', 1408,4,1900.00,3),
('Venice', 1152,3,1200.00,3),
('Barcelona', 2375,7,2800.00,4)

--E
UPDATE Destinations
SET Price=1700
WHERE Town='Paris'

--F
DELETE FROM Destinations
WHERE Town Like 'Ba%'

--G
SELECT Town, Distance
FROM Destinations
WHERE Distance>=1500 AND Distance<=2500

--H
SELECT Top(1) Town, Max(Price)
FROM Destinations
Group by Town

--I
SELECT [Name], COUNT(*) AS [Count]
FROM Countries AS c
JOIN Destinations AS d ON c.Id=d.CountryId
GROUP BY [Name]
ORDER BY [Count] DESC, [Name]