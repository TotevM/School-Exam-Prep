CREATE DATABASE University;
USE University;


CREATE TABLE Student (
 admission_no int PRIMARY KEY,
 first_name nvarchar(25) NOT NULL,
 last_name nvarchar(25) NOT NULL,
 city nvarchar(25) NOT NULL
);


CREATE TABLE Fee (
 admission_no int NOT NULL,
 course nvarchar(25) NOT NULL,
 amount_paid int
 );


INSERT INTO Student (admission_no, first_name, last_name, city)
VALUES (3354, 'Георги', 'Георгиев', 'Варна'),
(4321, 'Милена', 'Красимирова', 'Стара Загора'),
(8345, 'Михаил', 'Мартинов', 'Пловдив'),
(7555, 'Антонио', 'Тачев', 'Стара Загора'),
(2135, 'Мартин', 'Иванов', 'София');

INSERT INTO Fee (admission_no, course, amount_paid)
VALUES (3354, 'Java', 2000),
(7555, 'C#', 1800),
(4321, 'SQL', 1600),
(4321, 'Java', 2000),
(8345, 'C++', 1700);

SELECT city FROM student WHERE admission_no = 8345;

SELECT Avg(amount_paid) FROM fee;

UPDATE fee SET course = 'Java' WHERE amount_paid = 1800;

SELECT course, COUNT(course)
FROM fee
GROUP BY course;

SELECT first_name, last_name, course
FROM student
LEFT JOIN fee ON student.admission_no = fee.admission_no;