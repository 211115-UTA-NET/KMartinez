--Create a Books TAble

CREATE TABLE Books
(
	Title VARCHAR(250) PRIMARY KEY,
	Author VARCHAR(100) NOT NULL,
	Pages INT NOT NULL,
	Thickness VARCHAR(10) NOT NULL,
	GenreID INT NOT NULL,
	PublisherID INT NOT NULL,
);

--Create Authors Table
CREATE TABLE Authors
(
	Author VARCHAR(100) PRIMARY KEY,
	AuthorNationality VARCHAR(100) NOT NULL
);

--Create Geners Table
CREATE TABLE Genres
(
	ID INT PRIMARY KEY,
	Genre VARCHAR(100) NOT NULL
);

--Modify geners
--Introducing ALTER - change something about a table that is already in the db.
--VERB NOUN <NAME>, VERB <NAME> <TYPE> <Mods>
--ALTER TABLE Genres ADD Genre VARCHAR(100) NOT NULL;


--Remove/Delete
--TO DROP TABLE/COLUMNS 
--DROP TABLE [name of table];
--ALTER TABLE Genres DROP COLUMN Genre; (NO LONGER NEEDED)
--DROP TABLE Genres; (NO LONGER NEEDED)
 
--Modify a table to REMOVE the NOT  NULL property from a field.
ALTER TABLE Books ALTER COLUMN Pages INT;

--Create the Format-Price Table *Composite KEY!*
CREATE TABLE FormatPrice
(
	Title VARCHAR(250) NOT NULL,
	PrintFormat VARCHAR(50) NOT NULL,
	Price MONEY NOT NULL,
	PRIMARY KEY (Title, PrintFormat)
);


--Add primary key (nont realted to me this is in case you need to make a primary key)
--ALTER TABLE FormatPrint ADD PRIMARY KEY (Title, PrintFormat);

--Rename a table?
--ALTER TABLE Genres CHANGE COLUMN Genre TO Genre2;

--FORIEGN KEY as an ALTERATION
--Verb Noun <TableName> VERB NOUN <ColumnNAME> "REFERENCES" <FTable>(<FColumn>)
ALTER TABLE Books ADD FOREIGN KEY (Author) REFERENCES Authors(Author);

ALTER TABLE Books ADD FOREIGN KEY (GenreID) REFERENCES Genres(ID);

--DML Data Manipulation Language
--Insert - place data in a table
--When inserting, order matters. Add/INSERT data into your tables from the foreign key back.
--Any table that includes a foreign key to another table must have a valid target to reference before it can be inserted. 

--GENRES data 
INSERT Genres 
	(ID,Genre)
VALUES 
	(1,'Tutorial'),
	(2,'Popular Science');
--AUTHORS data 
INSERT Authors
	(Author, AuthorNationality)
VALUES
	('Chad Russell', 'American'),
	('E.F.Codd', 'British');
--BOOKS data
INSERT Books
	(Title, Author, Pages, Thickness, GenreID, PublisherID)
VALUES
	('Beginning MySQL Database Design and Optimization', 'Chad Russell', 520, 'Thick', 1, 1),
	('The Relational Model for Database Management: Version 2', 'E.F.Codd', 538, 'Thick', 2, 2),
	('Chads New Book', 'Chad Russell', 20, 'Thin', 2, 1);
--FORMATPRICE date
INSERT FormatPrice
	(Title, PrintFormat, Price)
VALUES
	('Beginning MySQL Database Design and Optimization', 'Hardcover', 49.99),
	('Beginning MySQL Database Design and Optimization',  'E-book',	22.34),
	('The Relational Model for Database Management: Version 2', 'E-book', 13.88),
	('The Relational Model for Database Management: Version 2', 'Paperback', 39.99);










