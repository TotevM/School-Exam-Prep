CREATE DATABASE Geo;
USE Geo;

CREATE TABLE Mountains (
    ID INT NOT NULL IDENTITY PRIMARY KEY,
    MountainName NVARCHAR(20) NOT NULL,
    CountryCode CHAR(3) NOT NULL,
    Country NVARCHAR(20)
);

CREATE TABLE Peaks (
    ID INT NOT NULL IDENTITY PRIMARY KEY,
    PeakName NVARCHAR(20) NOT NULL,
    Elevation INT NOT NULL,
    MountainId INT NOT NULL REFERENCES Mountains(ID),
    CHECK (Elevation > 0)
);

INSERT INTO Mountains (MountainName, CountryCode, Country) VALUES
('Рила', 'BUL', 'България'),
('Пирин', 'BUL', 'България'),
('Стара планина', 'BUL', 'България'),
('Анди', 'ARG', 'Аржентина'),
('Анди', 'CHL', 'Чили'),
('Хималаи', 'NPL', 'Непал'),
('Алпи', 'SUI', 'Швейцария'),
('Алпи', 'ITA', 'Италия'),
('Алпи', 'AUT', 'Австрия'),
('Алпи', 'FRA', 'Франция'),
('Елбрус', 'RUS', 'Русия'),
('Елбрус', 'GEO', 'Грузия');

INSERT INTO Peaks VALUES
('Аконкагуа', 6962, 4),
('Ботев', 2376, 3),
('Мусала', 2925, 1),
('Еверест', 8849, 6),
('Вихрен', 2914, 2),
('Мальовица', 2729, 1),
('Монблан', 4809, 10),
('Матерхорн', 4478, 8),
('Дюфур', 4634, 7),
('Елбрус', 5642, 11),
('Ком', 2015, 3),
('Манаслу', 2729, 6),
('Дено', 2790, 1);

UPDATE Peaks
SET Elevation = 2016
WHERE PeakName = 'Ком';

SELECT AVG(Elevation) FROM Peaks
WHERE MountainId = 1;

SELECT COUNT(*) FROM Peaks
WHERE Elevation BETWEEN 5000 AND 9000;

SELECT p.PeakName, p.Elevation, m.MountainName, m.Country
FROM Peaks AS p
JOIN Mountains AS m ON p.MountainId = m.ID
WHERE Elevation > 2900
ORDER BY Country, Elevation DESC;

SELECT Country, COUNT(*) AS [Count]
FROM Mountains
GROUP BY Country
ORDER BY COUNT(*) DESC, Country;
