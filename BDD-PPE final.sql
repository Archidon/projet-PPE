DROP DATABASE IF EXISTS BddPPE;
CREATE DATABASE BddPPE;
USE BddPPE;

CREATE TABLE Ville(
	idVille INT PRIMARY KEY,
    nomVille VARCHAR(25)
 
) ENGINE InnoDB;

CREATE TABLE Salle(
	idSalle INT PRIMARY KEY,
    nomSalle VARCHAR(10),
    prixSalle DECIMAL(4,2),
    idVille INT UNIQUE,
    
FOREIGN KEY (idVille) REFERENCES Ville(idVille)
) ENGINE InnoDB;

CREATE TABLE Utilisateur(
	idClient INT PRIMARY KEY,
    nom VARCHAR(15),
    prenom VARCHAR(20),
    photo BLOB,
    adresse VARCHAR(40),
    dateNaissance DATETIME,
    mailClient VARCHAR(20),
    telClient CHAR(10),
    mailConfirme BOOLEAN
) ENGINE InnoDB;

CREATE TABLE Credits(
	dateCredits DATETIME PRIMARY KEY,
    credit DECIMAL(4,2),
    idClient INT,
FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient)
) ENGINE InnoDB;

CREATE TABLE Notation(
	idSalle INT,
    dateHeure DATETIME,
    idClient INT,
    note SMALLINT,
     
FOREIGN KEY (idSalle) REFERENCES Salle(idSalle),
FOREIGN KEY (dateHeure) REFERENCES Credits(dateCredits),
FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient)
) ENGINE InnoDB;

CREATE TABLE Equipe(
	idEquipe INT PRIMARY KEY,
    nomEquipe VARCHAR(20)
) ENGINE InnoDB;

CREATE TABLE Composer(
	idEquipe INT PRIMARY KEY,
    idClient INT,
    
FOREIGN KEY (idEquipe) REFERENCES Equipe(idEquipe),
FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient)
) ENGINE InnoDB;

CREATE TABLE Parties(
	idPartie INT PRIMARY KEY,
    dateHeurePartie DATETIME,
    nombresEchecs INT,
    nbJoueur INT,
    nbObstacles INT,
    typeObstacle VARCHAR(10),
    positionObstacle VARCHAR(15),
    nbElement INT,
    typeElement VARCHAR(10),
    emplacementElement VARCHAR(15),
    idSalle INT,
    idEquipe INT,
    
FOREIGN KEY (idSalle) REFERENCES Salle(idSalle),
FOREIGN KEY (idEquipe) REFERENCES Equipe(idEquipe)
) ENGINE InnoDB;

CREATE TABLE Jouer(
	idClient INT PRIMARY KEY,
    idPartie INT,
    paiement DECIMAL(4,2),

FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient),
FOREIGN KEY (idPartie) REFERENCES Parties(idPartie) 
) ENGINE InnoDB;

CREATE TABLE Media(
	idMedia INT PRIMARY KEY,
    photo BLOB,
	video BLOB,
    commentaires TEXT,
    idClient INT,
    
FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient)
) ENGINE InnoDB;