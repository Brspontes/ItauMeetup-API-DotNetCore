CREATE DATABASE DBMetupITAU;
USE DBMetupItau;

CREATE TABLE Heroes 
(
	ID VARCHAR(255) NOT NULL,
    FIRSTNAME VARCHAR(100) NOT NULL,
    LASTNAME VARCHAR(100) NOT NULL,
    IMAGE VARCHAR(1000) NOT NULL,
    DESCRIPTION TEXT,
    PRIMARY KEY(ID)
);

SELECT * FROM HEROES