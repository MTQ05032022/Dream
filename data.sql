-- Create database
CREATE DATABASE football;

-- Use database
USE football;

-- Create table `teams`
go
CREATE TABLE teams (
  id INT NOT NULL IDENTITY,
  name VARCHAR(255) NOT NULL,
  country VARCHAR(255) NOT NULL,
  number int,
  PRIMARY KEY (id)
);
go


-- Create table `players`
CREATE TABLE players (
  id INT NOT NULL IDENTITY,
  name VARCHAR(255) NOT NULL,
  position VARCHAR(255) NOT NULL,
  age INT NOT NULL,
  team INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (team) REFERENCES teams (id)
);

-- Insert data into table `teams`
INSERT INTO teams (name, country, number)
VALUES ('Manchester United', 'England', 20);

-- Insert data into table `players`
INSERT INTO players (name, position, age, team)
VALUES ('Cristiano Ronaldo', 'Forward', 37, 1);

select * from dbo.players