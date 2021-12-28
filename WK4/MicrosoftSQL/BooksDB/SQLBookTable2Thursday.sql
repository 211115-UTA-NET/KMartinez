-- Create a Books Table
CREATE TABLE Books
(
	Title VARCHAR(250) PRIMARY KEY,
	Author VARCHAR(100) NOT NULL,
	Pages INT NOT NULL,
	Thickness VARCHAR(10) NOT NULL,
	GenreID INT NOT NULL,
	PublisherID INT NOT NULL,
);


--Create an Authors Table
CREATE TABLE Authors
(
	Author VARCHAR(100) PRIMARY KEY,
	AuthorNationality VARCHAR(100) NOT NULL
);

--Create a Genres Table
CREATE TABLE Genres
(
	ID INT PRIMARY KEY,
	Genre VARCHAR(100) NOT NULL
);


--ALTER - change something about a table that is already in the db.
--VERB NOUN <NAME>, VERB <NAME> <TYPE> <Mods>
--ALTER TABLE Genres ADD Genre VARCHAR(100) NOT NULL;

--DROP Table
--DROP TABLE Genres; (no longer need)

--Modify a table to REMOVE the NOT NULL property from a field.
ALTER TABLE Books ALTER COLUMN Pages INT NOT NULL;


DROP Table FormatPrice;

--Create the Format-Price Table *Composite KEY!*
CREATE TABLE FormatPrice
(
	Title VARCHAR(250) NOT NULL,
	PrintFormat VARCHAR(50) NOT NULL,
	Price MONEY NOT NULL,
	PRIMARY KEY (Title, PrintFormat),
);

--Example 
--ALTER TABLE FormatPrice ADD PRIMARY KEY (Title, PrintFormat);
--Rename a table?
--ALTER TABLE Genres CHANGE COLUMN Genre TO Genre2;


--Create a Foreign Key as an alteration
--Verb Noun <TableName> VERB NOUN <ColumnNAME> "REFERENCES" <FTable>(<FColumn>)
ALTER TABLE Books ADD FOREIGN KEY (Author) REFERENCES Authors(Author);

ALTER TABLE Books ADD FOREIGN KEY (GenreID) REFERENCES Genres(ID);

ALTER TABLE FormatPrice ADD FOREIGN KEY (Title) REFERENCES Books(Title);


--Insert infomation
INSERT Genres 
	(ID,Genre)
VALUES 
	(1,'Tutorial'),
	(2,'Popular Science');

INSERT Authors
	(Author, AuthorNationality)
VALUES
	('Chad Russell', 'American'),
	('E.F.Codd', 'British');

INSERT Books
	(Title, Author, Pages, Thickness, GenreID, PublisherID)
VALUES
	('Beginning MySQL Database Design and Optimization', 'Chad Russell', 520, 'Thick', 1, 1),
	('The Relational Model for Database Management: Version 2', 'E.F.Codd', 538, 'Thick', 2, 2),
	('Chads New Book', 'Chad Russell', 20, 'Thin', 2, 1);

INSERT FormatPrice
	(Title, PrintFormat, Price)
VALUES
	('Beginning MySQL Database Design and Optimization', 'Hardcover', 49.99),
	('Beginning MySQL Database Design and Optimization',  'E-book',	22.34),
	('The Relational Model for Database Management: Version 2', 'E-book', 13.88),
	('The Relational Model for Database Management: Version 2', 'Paperback', 39.99);

--In Azure Data Studio
--DML/DQL Data Query Language
--SELECT - requests information from a table
--*everything!
--VERB <TARGET/What/filter> FROM <Table>
SELECT * FROM Books;

SELECT Author FROM Books;

SELECT Title, Author, Pages FROM Books;

--SELECT WHERE - add filter to a SELECT
SELECT * FROM Books WHERE Author='Chad Russell';

SELECT * FROM Books WHERE Thickness!='Thick';

--JOINs a way to reach from one table into another to collect info across tables.

--INNER JOIN--
--Selects all rows from both tables, as long as there is a batch between the columns.
--If there are records in "Table A" that do not have a matching record in "Table B", they are not shown

-- SELECT column_name
-- FROM Table_A
-- INNER JOIN Table_B
-- ON Table_A.column_name = Table_B.column_Name;

--Group examples
--WORKED
SELECT * FROM FormatPrice
INNER JOIN Books ON FormatPrice.Title = Books.Title;
--Did not work for me
SELECT * FROM Books
INNER JOIN Author ON Books.Author = Author.AuthorPK
WHERE Thickness = 'Thin';

--..............................................................
-- LEFT JOIN--
-- Returns all records from the "Left" table, even if there are not matching records in the "Right" table

-- SELECT column_name
-- FROM Table_A
-- LEFT JOIN Table_B
-- ON Table_A.column_name = Table_B.column_Name;

--Group examples
--did not work for me
SELECT Books.Title, Genre.GenreName
FROM Books LEFT JOIN Genre
ON Books.GenreID = Genre.GenreID

--did not work for me
SELECT Book.Title, Books.Author, FormatPrice.PrintFormat, FormatPrice.Price
FROM Books
LEFT JOIN FormatPrice ON Books.Title = FormatPrice.Title;
--.................................................................
-- RIGHT JOIN
-- Returns all records from the "Right" table, even if there are not matching records in the "Left" table.

-- SELECT column_name
-- FROM Table_A
-- LEFT JOIN Table_B
-- ON Table_A.column_name = Table_B.column_Name;

--Group examples
--did not work for me :/
SELECT Books.Author, Author.Author
FROM Books
RIGHT JOIN Author
ON Books.Author = Author.Author;
--.................................................................
-- FULL JOIN
-- Returns all records when there is a match in "Left" or "Right" table.

-- SELECT column_name
-- FROM Table_A
-- FULL OUTER JOIN Table_B
-- ON Table_A.column_name = Table_B.column_Name;

--Group examples
--did not work for me :((
SELECT Book.Title, Book.Author, FormatPrice.PrintFomartm, FormatPrice.Price
FROM Books
FULL JOIN FormatPrice
ON Books.Title = FormatPrice.Title;

SELECT * FROM Books
FULL OUTER JOIN FormatPrice
ON Books.Title = FormatPrice.Title
WHERE PrintFormart = 'E-book';
--.................................................................
-- SELF JOIN
-- Returns a table that has been formed by joining a table with itself.

-- SELECT A.columnA, B.columnB, A.columnC
-- FROM TableA A, TableA B
-- WHERE A.columnA <> B.columnB
-- And A.columnC = B.columnC;

--Group examples


--................................................

--UNIQUE - every value in the specified column is different
--NOT NULL - ever record (row) must have the specified column filled
--NULL - NULL is allowed as a possible value (and is also the default)
--DEFAULT (expr) - use a different default instead of NULL

--UNIQUE and NOT NULL are part of a columns eligibility to be a PRIMARY KEY

--IDENTITY - the SQL Server way to automatically increment the next record(row) in the specified column

--CREATE TABLE People
-- (
-- 	ID INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
--  LastName VARCHAR(255) NOT NULL,
--  FirstName VARCHAR(255) NOT NULL
-- )

--IDENTITY(_,_) - start counting at, increment by

-- INSERT People
-- (LastName, FirstName)
-- VALUES
-- ('Schweers', 'Stefan'),
-- ('Cicio', 'Edward');

--DATES
--DATE, DATETIME, SMALLDATE, TIMESTAMP
--YYYY-MM-DD, YYYY-MM-DD HH:mm:ss, YYYY-MM-DD HH:mm:ss, unique



--WHERE... AND/OR/NOT
--and/or/not allows us o refine the results of a select where statement

-- SELECT column1, column2
-- FROM TableA
-- WHERE Condition1 AND Condition2 OR Condition3
-- WHERE Condition1 OR Condition2 AND Condition3
-- WHERE NOT Condition1 AND Condition2

--ORDER Gives us a way to sort reslut of a query
--ASC/DES Ascending or Desceind order

SELECT * FROM Books
ORDER BY Author, Pages DESC;

--Thursday---