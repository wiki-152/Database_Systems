--CREATE DATABASE University;

--USE University;

--CREATE TABLE Students (
--    StudentID INT PRIMARY KEY,
--    FirstName VARCHAR(50) NOT NULL,
--    LastName VARCHAR(50) NOT NULL,
--    DOB DATE,
--    DepartmentID INT,
--    --CONSTRAINT FK_DepartmentID FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
--);

--CREATE TABLE Departments (
--    DepartmentID INT PRIMARY KEY,
--    DepartmentName VARCHAR(255)
--);

--ALTER TABLE Students
--ALTER COLUMN FirstName VARCHAR(50) NOT NULL;

--ALTER TABLE Students
--ALTER COLUMN LastName VARCHAR(50) NOT NULL;

--ALTER TABLE Students
--ADD Email VARCHAR (50);

--ALTER TABLE Students
--ADD CONSTRAINT Unique_Email UNIQUE(Email);

--CREATE INDEX index_DepartmentName ON Departments (DepartmentName);

-- first do steps at end then this will work
--CREATE INDEX index_StudentCourse ON StudentCourses (StdID, CourseID);

--already defined in create table
--ALTER TABLE Students
--ADD CONSTRAINT PK_Students PRIMARY KEY (StudentID);

--ALTER TABLE Students
--ADD CONSTRAINT FK_Students_Departments FOREIGN KEY (DepartmentID)
--REFERENCES Departments(DepartmentID);

--INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
--(1, 'Computer Science'),
--(2, 'Electrical Engineering'),
--(3, 'Mechanical Engineering'),
--(4, 'Civil Engineering'),
--(5, 'Mathematics');

--INSERT INTO Students (StudentID, FirstName, LastName, DOB, DepartmentID, Email) VALUES
--(1, 'Ali', 'Khan', '1995-03-15', 1, 'ali@gmail.com'),
--(2, 'Umer', 'Khan', '1997-09-22', 1, 'umer@gmail.com'),
--(3, 'Sami', 'Khan', '1996-05-10', 2, 'sami@gmail.com'),
--(4, 'Waqas', 'Khan', '1998-11-07', 3, 'waqas@gmail.com'),
--(5, 'ahmed', 'Khan', '1999-02-28', 2, 'ahmed@gmail.com'),
--(6, 'Aqsa', 'Khan', '1994-07-18', 4, 'aqsa@gmail.com'),
--(7, 'Sara', 'Khan', '1997-12-03', 1, 'sara@gmail.com'),
--(8, 'Abdullah', 'Khan', '1998-04-20', 5, 'abdullah@gmail.com'),
--(9, 'Faaizan', 'Khan', '1996-08-11', 3, 'faaizan@gmail.com'),
--(10, 'Danial', 'Khan', '1995-10-25', 2, 'danial@gmail.com');

--UPDATE Students SET DepartmentID = NULL WHERE DepartmentID = 5;
--DELETE FROM Departments WHERE DepartmentID = 5;

--DELETE FROM Students WHERE StudentID = 10;


--UPDATE Students SET DepartmentID = NULL WHERE DepartmentID = 1;
--DELETE FROM Departments WHERE DepartmentID = 1;


--UPDATE Students SET DOB = '1995-06-20' WHERE StudentID = 1;

--UPDATE Students SET DepartmentID = 2 WHERE StudentID = 7;

-- Already added above	
--ALTER TABLE Students
--ADD Email VARCHAR(255);

--ALTER TABLE Students
--DROP COLUMN DOB;

--CREATE TABLE Courses (
--Courses_ID INT PRIMARY KEY,
--Course_Name VARCHAR(50));

--INSERT INTO Courses VALUES
--(1, 'Prob'),
--(2, 'Database'),
--(3, 'PF'),
--(4, 'OOP'),
--(5, 'Algebra');

--CREATE TABLE StudentCourses(
--StdID INT,
--CourseID INT
--);

--INSERT INTO StudentCourses VALUES
--(1, 1),
--(1, 2),
--(2, 1),
--(2, 3),
--(3, 2),
--(3, 4),
--(4, 3),
--(4, 4),
--(5, 1),
--(5, 5),
--(6, 2),
--(6, 3),
--(7, 4),
--(7, 5),
--(8, 1),
--(8, 2),
--(9, 1),
--(9, 3),
--(10, 4),
--(10, 5);

--DELETE FROM StudentCourses WHERE StdID = 1;


SELECT * FROM Students;

SELECT * FROM Departments;