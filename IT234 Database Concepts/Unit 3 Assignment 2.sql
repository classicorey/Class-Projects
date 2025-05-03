/* Create the second database for SQL only manipulation */
CREATE DATABASE Movies_2;

/* Create the director table with the 3 attributes */
CREATE TABLE Movies_2.dbo.Director (
    DirectorID int NOT NULL PRIMARY KEY,
    Director_FirstName varchar(15),
    Director_LastName varchar(25) NOT NULL,
);

/* Create the Genre table with 2 attributes */
CREATE TABLE Movies_2.dbo.Genre (
    GenreID int NOT NULL PRIMARY KEY,
    Genre varchar(15) NOT NULL,
);

/* Create the Star table with 3 attributes */
CREATE TABLE Movies_2.dbo.Star (
    StarID int NOT NULL PRIMARY KEY,
    Star_FirstName varchar(15),
	Star_LastName varchar(25) NOT NULL,
);

/* Create the Producer table with 3 attributes */
CREATE TABLE Movies_2.dbo.Producer (
    ProducerID int Identity(1,1) NOT NULL PRIMARY KEY,
    Producer_FirstName varchar(15),
    Producer_LastName varchar(35) NOT NULL,
);

/* Alter the Producer table to include a column for where the producer lives as well as what accolades they have received */
ALTER TABLE Movies_2.dbo.Producer
ADD Residence_Country varchar(64),
    Accolades varchar(255);

/* Alter the Producer table to remove the column listing where the live */
ALTER TABLE Movies_2.dbo.Producer
DROP COLUMN Residence_Country;

/* Create the Movies table with 6 attributes with foreign keys to complete relationships to the rest of the tables */
CREATE TABLE Movies_2.dbo.Movies (
    MovieID int NOT NULL PRIMARY KEY,
    Title varchar(35) NOT NULL,
    DirectorID int FOREIGN KEY REFERENCES Movies_2.dbo.Director(DirectorID) NOT NULL,
	StarID int FOREIGN KEY REFERENCES Movies_2.dbo.Star(StarID) NOT NULL,
	GenreID int FOREIGN KEY REFERENCES Movies_2.dbo.Genre(GenreID) NOT NULL,
	Rating numeric(3, 1) NOT NULL,
);

/* Alter the Movies table to include a foreign key for the ProducerID from the producers table */
ALTER TABLE Movies_2.dbo.Movies
ADD	ProducerID int FOREIGN KEY REFERENCES Movies_2.dbo.Producer(ProducerID) NOT NULL;

/* Alter the Genre table to include a description attribute for context */
ALTER TABLE Movies_2.dbo.Genre
ADD Genre_Description varchar(255);

/* Alter the Star table to describe any accolades they've received */
ALTER TABLE Movies_2.dbo.Star
ADD Accolades varchar(255);

/* Alter the Director table to describe any accolades they've received */
ALTER TABLE Movies_2.dbo.Director
ADD Accolades varchar(255);