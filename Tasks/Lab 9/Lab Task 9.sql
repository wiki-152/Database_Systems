--CREATE TABLE Users(
--UserID INT PRIMARY KEY IDENTITY(1,1),
--Username NVARCHAR(50) NOT NULL,
--Email NVARCHAR(100), 
--RegistrationDate DATETIME NOT NULL DEFAULT(GETDATE()) 
--);

--CREATE TABLE Posts (
--PostID INT PRIMARY KEY IDENTITY(1,1), 
--UserID INT FOREIGN KEY REFERENCES
--Users(UserID), 
--Title NVARCHAR(100) NOT NULL, 
--Content NVARCHAR(MAX) NOT NULL, 
--PostDate DATETIME NOT NULL DEFAULT(GETDATE())
--);

--CREATE TABLE Comments (CommentID INT PRIMARY KEY IDENTITY(1,1), 
--PostID INT FOREIGN KEY
--REFERENCES Posts(PostID), 
--UserID INT FOREIGN KEY REFERENCES Users(UserID), 
--CommentText NVARCHAR(MAX) NOT NULL, 
--CommentDate DATETIME NOT NULL DEFAULT(GETDATE()) );

--INSERT INTO Users (Username, Email, RegistrationDate) VALUES ('JohnDoe', 'johndoe@example.com', '2022-01-10'), ('JaneSmith', 'janesmith@example.com', '2022-01-15'), ('AliceJones', 'alicejones@example.com', '2022-01-20'), ('BobBrown', 'bobbrown@example.com', '2022-01-25'), ('CharlieDavis', 'charliedavis@example.com', '2022-02-01'), ('DianaEvans', 'dianaevans@example.com', '2022-02-05'), ('EvanFoster', 'evanfoster@example.com', '2022-02-10'), ('FionaGreen', 'fionagreen@example.com', '2022-02-15'), ('GeorgeHill', 'georgehill@example.com', '2022-02-20'), ('HannahIvy', 'hannahivy@example.com', '2022-02-25'); 


--INSERT INTO Posts (UserID, Title, Content, PostDate) VALUES (1, 'First Post', 'This is the content of the first post.', '2022-02-26'), (2, 'Second Post', 'This is the content of the second post.', '2022-03-01'), (1, 'Third Post', 'This is the content of the third post.', '2022-03-05'), (3, 'Fourth Post', 'This is the content of the fourth post.', '2022-03-10'), (4, 'Fifth Post', 'This is the content of the fifth post.', '2022-03-15'), (5, 'Sixth Post', 'This is the content of the sixth post.', '2022-03-20'), (2, 'Seventh Post', 'This is the content of the seventh post.', '2022-03-25'), (3, 'Eighth Post', 'This is the content of the eighth post.', '2022-03-30'), (4, 'Ninth Post', 'This is the content of the ninth post.', '2022-04-04'), (5, 'Tenth Post', 'This is the content of the tenth post.', '2022-04-08'); 

--INSERT INTO Comments (PostID, UserID, CommentText, CommentDate) VALUES (1, 2, 'Great first post!', '2022-02-27'), (1, 3, 'Looking forward to more!', '2022-02-28'), (2, 1, 'Very interesting read.', '2022-03-02'), (3, 4, 'I agree with your points.', '2022-03-06'), (4, 5, 'This topic is very relevant.', '2022-03-11'), (5, 1, 'Thanks for sharing.', '2022-03-16'), (6, 2, 'I learned a lot from this post.', '2022-03-21'), (7, 3, 'Can''t wait for your next post!', '2022-03-26'), (8, 4, 'Very detailed and informative.', '2022-03-31'), (9, 5, 'Your writing style is engaging.', '2022-04-05');


SELECT * FROM Users;

SELECT * FROM Posts;

SELECT * FROM Comments;

-- Query 1
--SELECT p.postID, p.UserID, p.Title, p.Content, p.PostDate, u.Username
--FROM Posts p JOIN Users u ON p.UserID = u.UserID;

--Query 2
--SELECT u.UserID, u.Username, u.Email, u.RegistrationDate, c.CommentText 
--FROM Users u FULL JOIN Comments c ON u.UserID = c.UserID;

--Query 3
--SELECT p.*, c.CommentText
--FROM Posts p 
--LEFT JOIN Comments c ON p.PostID = c.PostID;

--Query 4
--SELECT c.CommentID, c.PostID, c.UserID, c.CommentText, c.CommentDate, p.Title, u.Username
--FROM Comments c 
--INNER JOIN Posts p ON c.PostID = p.PostID 
--JOIN Users u ON c.UserID = u.UserID;

--Query 5
--SELECT u.UserID, u.Username, COUNT(p.PostID) AS Total_Posts
--FROM Users u 
--LEFT JOIN Posts p ON u.UserID = p.UserID
--GROUP BY u.Username;

--Query 6
--SELECT p.PostID, p.Title, COUNT(c.CommentID) AS NumOfComments
--FROM Posts p 
--LEFT JOIN Comments c ON p.PostID = c.PostID
--GROUP BY p.PostID, p.Title;

--Query 7
--SELECT *
--FROM Users u 
--NOT EXISTS (SELECT * FROM Posts p WHERE p.UserID = u.UserID)

--SELECT u.UserID, u.Username
--FROM Users u
--LEFT JOIN Posts p 
--ON u.UserID = p.UserID
--WHERE p.UserID IS NULL;


--Query 8
--SELECT p.PostID, p.Title
--FROM Posts p
--LEFT JOIN Comments c ON p.PostID = c.PostID
--WHERE c.PostID IS NULL;

--Query 9
--SELECT u.UserID, MAX(p.postDate)
--FROM Posts p 
--left JOIN Users u
--ON u.UserID = p.UserID 
--GROUP BY u.UserID;



--Query 10
--SELECT c.*
--FROM Comments c
--JOIN Posts p ON c.PostID = p.PostID
--WHERE p.UserID = 1;


--Query 11
--SELECT u.Username, p.Title, COUNT(c.CommentID) AS Total_Comments
--FROM Users u
--INNER JOIN Posts p ON u.UserID = p.UserID
--LEFT JOIN Comments c ON p.PostID = c.PostID
--GROUP BY u.Username, p.Title;

--Query 12
--SELECT c.UserID, u.Username
--FROM Comments c
--JOIN Users u ON c.UserID = u.UserID
--GROUP BY c.UserID, u.Username
--HAVING COUNT(DISTINCT c.PostID) = (SELECT COUNT(*) FROM Posts);



--Query 13
--SELECT p.PostID, p.Title, u.UserID, u.Username
--FROM Posts p
--LEFT JOIN Users u ON p.UserID = u.UserID
--LEFT JOIN Comments c ON p.PostID = c.PostID AND u.UserID = c.UserID
--WHERE c.CommentID IS NULL;



-- Query 14
--SELECT u.Username, p.*
--FROM (
--    SELECT UserID, MIN(PostDate) AS FirstPostDate
--    FROM Posts
--    GROUP BY UserID
--) AS fp
--JOIN Posts p ON fp.UserID = p.UserID AND fp.FirstPostDate = p.PostDate
--JOIN Users u ON p.UserID = u.UserID;


--Query 15
--SELECT p.PostID, p.Title, COUNT(c.CommentID) AS NumOfComments
--FROM Posts p
--LEFT JOIN Comments c ON p.PostID = c.PostID
--GROUP BY p.PostID, p.Title
--ORDER BY COUNT(c.CommentID) DESC;


