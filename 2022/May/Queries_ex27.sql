CREATE DATABASE Store


--1
CREATE TABLE Laptops
(
ID INT PRIMARY KEY IDENTITY,
Марка VARCHAR(256),
Модел VARCHAR(256),
Наличност int,
цена Decimal(8,2)
)

--2
INSERT INTO laptops (Марка, Модел, Наличност, Цена)
VALUES ('Laptop 1', ' L29KAS', 10, 1100);

INSERT INTO laptops (Марка, Модел, Наличност, Цена)
VALUES ('Laptop 2', '15FDR7', 14, 1350);

INSERT INTO laptops (Марка, Модел, Наличност, Цена)
VALUES ('Laptop 1', 'L29GTA', 12, 1500);

INSERT INTO laptops (Марка, Модел, Наличност, Цена)
VALUES ('Laptop 1', 'L29DFT', 8, 1499);

INSERT INTO laptops (Марка, Модел, Наличност, Цена)
VALUES ('Laptop 2', '15FDM5', 11, 1600);

--3
DELETE FROM Laptops
WHERE Модел='15FDR7'

--4
SELECT Модел,(Наличност*цена*1.2) AS обща_сума
FROM Laptops

--5
SELECT Марка, SUM(Наличност)
FROM Laptops
WHERE Марка='Laptop 1'
GROUP BY Марка