-- Creating Table 

--CREATE TABLE Books (
--	bookId INT IDENTITY(1,1),
--	title VARCHAR(300),
--	author VARCHAR(300),
--	publicationYear INT,
--	genre VARCHAR(150),
--	shelfLocation VARCHAR(50),
--	isAvailable BIT 
--);

-- Shelf 1 Finance 
-- Shelf 2 Science Fiction
-- Shelf 3 History 
-- Shelf 4 Fiction
-- Shelf 5 Horror


--INSERT INTO Books (title , author , publicationYear , genre , shelfLocation , isAvailable) VALUES ('Rich Dad Poor Dad' , 'Robert Kiyosaki' , 1997 , 'Finance' , 'Shelf 1' , 1 );
--INSERT INTO Books (title , author , publicationYear , genre , shelfLocation , isAvailable) VALUES ('The Martian' , 'Andy Weir' , 2011 , 'Science Fiction' , 'Shelf 2' , 1 );
--INSERT INTO Books (title , author , publicationYear , genre , shelfLocation , isAvailable) VALUES ('Shikasta' , 'Doris Lessing' , 1979 , 'Science Fiction' , 'Shelf 2' , 1 );
--INSERT INTO Books (title , author , publicationYear , genre , shelfLocation , isAvailable) VALUES ('A Tale of Two Cities' , 'Charles Dickens' , 1859 , 'History' , 'Shelf 3' , 1 );
--INSERT INTO Books (title , author , publicationYear , genre , shelfLocation , isAvailable) VALUES ('Killers of the Flower Moon' , 'David Grann' , 2017  , 'History' , 'Shelf 3' , 1 );
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('The Diary of Anne Frank', 'Anne Frank', 1952, 'History', 'Shelf 3', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Band of Brothers', 'Stephen Edward Ambrose', 1992, 'History', 'Shelf 3', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('The Guns of August', 'Barbara Wertheim Tuchman', 1962, 'History', 'Shelf 3', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Project Hail Mary', 'Andy Weir', 2021, 'Science Fiction', 'Shelf 2', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Atemis', 'Andy Weir', 2017, 'Science Fiction', 'Shelf 2', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('The Egg', 'Andy Weir', 2009, 'Fiction', 'Shelf 4', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('the Egg and Other Stories', 'Andy Weir', 2017, 'Fiction', 'Shelf 4', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Night', 'Ellie Wiesel', 1981, 'History', 'Shelf 3', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Beloved', 'Toni Morrison', 1987, 'History', 'Shelf 3', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Night', 'Ellie Wiesel', 1981, 'History', 'Shelf 3', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('It', 'Stephen King', 1986, 'Horror', 'Shelf 5', 1);
--INSERT INTO Books (title, author, publicationYear, genre, shelfLocation, isAvailable) VALUES ('Forward', 'Andy Weir', 2021, 'Science Fiction', 'Shelf 2', 1);


SELECT * FROM Books;

--1--

--SELECT title AS book_title , author AS book_author 
--FROM Books 
--WHERE genre = 'Science Fiction';

--SELECT title , author
--FROM Books 
--WHERE genre = 'Science Fiction';

--2--

--SELECT bookId , title , genre 
--FROM Books
--WHERE publicationYear < 2000;

--3--

--SELECT * 
--FROM Books
--ORDER BY publicationYear, title; -- By default ordered by ascending we can add ASC but it is already default

--4--

-- We Update Availble Status of few books to FALSE (0)

--UPDATE Books SET isAvailable = 0 WHERE bookId IN (1,5,7,12);

--SELECT * 
--FROM Books
--WHERE isAvailable = 0;

--5--

--SELECT title , genre , author 
--FROM Books
--WHERE genre = 'History'
--ORDER BY author;

--6--

-- Book Id 1 of genre Finance has only 1 book and is not availble that is why not showing in result. 

-- If you want to set Finance genre book to available and check
--UPDATE Books SET isAvailable = 1 WHERE bookId = 1;

--SELECT genre , COUNT(*) AS 'Available_Books'
--FROM Books
--WHERE isAvailable = 1
--GROUP BY genre;

--7--

--SELECT title , publicationYear
--FROM Books
--WHERE publicationYear BETWEEN 1980 AND 1990;

-- Can also be written as 

--SELECT title , publicationYear
--FROM Books
--WHERE publicationYear >= 1980 AND publicationYear <= 1990;

--8--

--SELECT author , COUNT(*) AS count_of_books
--FROM Books
--GROUP BY author
--HAVING COUNT(*) >= 5;

--9--

--SELECT publicationYear , COUNT(*) * (1.0 / (COUNT(DISTINCT publicationYear))) AS average_books_per_year
--FROM Books
--GROUP BY publicationYear;

--10--

--SELECT TOP 1 genre , COUNT(*) AS available_titles
--FROM Books
--WHERE isAvailable = 1
--GROUP BY genre
--ORDER BY COUNT(*) DESC;



