DROP DATABASE IF EXISTS BddPPE;
CREATE DATABASE BddPPE;
USE BddPPE;

CREATE TABLE Medias(
	idMedia INT NOT NULL AUTO_INCREMENT,
    photos BLOB,
    video BLOB,
	commentaire TEXT,

PRIMARY KEY (idMedia)
) ENGINE InnoDB;

CREATE TABLE Utilisateur(
	idClient INT NOT NULL AUTO_INCREMENT,
    nomClient VARCHAR(30),
    prenomClient VARCHAR(30),
    photoIdentite BLOB,
    adresse VARCHAR(50),
    dateNaissance DATE,
    mailClient VARCHAR(30),
    telephoneClient VARCHAR(10),
    mailConfirmation TEXT,
    media INT,
    
PRIMARY KEY (idClient),
FOREIGN KEY (media) REFERENCES Medias(idMedia)
) ENGINE InnoDB;

CREATE TABLE Equipe(
	idEquipe INT NOT NULL AUTO_INCREMENT,
    nomEquipe VARCHAR(25),
    joueur INT,

PRIMARY KEY (idEquipe)
) ENGINE InnoDB;

CREATE TABLE Reservation(
	idResa INT NOT NULL AUTO_INCREMENT,
	horaireDebut TIME,
    horaireFin TIME,
    nbJoueur INT,
    nbElement INT,
    typeElement VARCHAR(10),
    emplacementElement VARCHAR(15),
    equipe INT,
    
PRIMARY KEY (idResa),
FOREIGN KEY (equipe) REFERENCES Equipe(idEquipe)
) ENGINE InnoDB;

CREATE TABLE Finances(
	idFinances INT NOT NULL AUTO_INCREMENT,
    cotisations INT,
    suivisAchatDepense INT,
    inscription DATETIME,
    utilisateur INT,
    reservation INT,
    
PRIMARY KEY (idFinances),
FOREIGN KEY (utilisateur) REFERENCES Utilisateur(idClient),
FOREIGN KEY (reservation) REFERENCES Reservation(idResa)
) ENGINE InnoDB;

CREATE TABLE DonnéesPartie(
	idPartie INT NOT NULL AUTO_INCREMENT,
    datePartie DATETIME,
    nbObstacles INT,
    typeObstacle VARCHAR(10),
    positionObstacle VARCHAR(15),
    tempPassgeObstacle INT,
    nombresEchecs INT,
    media INT,

PRIMARY KEY (idPartie),
FOREIGN KEY (media) REFERENCES Medias(idMedia)
) ENGINE InnoDB;
