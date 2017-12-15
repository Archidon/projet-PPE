DROP DATABASE IF EXISTS BddPPE;
CREATE DATABASE BddPPE;
USE BddPPE;

CREATE TABLE Ville(
	idVille INT PRIMARY KEY,
    nomVille VARCHAR(25)
 
) ENGINE InnoDB;

CREATE TABLE Salle(
	idSalle INT PRIMARY KEY,
    nomSalle VARCHAR(15),
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
	dateCredits DATETIME,
    credit DECIMAL(4,2),
    idClient INT,
    
PRIMARY KEY (dateCredits, idClient),
FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient)
) ENGINE InnoDB;

CREATE TABLE Notation(
	idSalle INT,
    dateHeure DATETIME,
    idClient INT,
    note SMALLINT,
     
PRIMARY KEY (idSalle, dateHeure, idClient),
FOREIGN KEY (idSalle) REFERENCES Salle(idSalle),
FOREIGN KEY (dateHeure) REFERENCES Credits(dateCredits),
FOREIGN KEY (idClient) REFERENCES Utilisateur(idClient)
) ENGINE InnoDB;

CREATE TABLE Equipe(
	idEquipe INT PRIMARY KEY,
    nomEquipe VARCHAR(20)
) ENGINE InnoDB;

CREATE TABLE Composer(
	idEquipe INT,
    idClient INT,

PRIMARY KEY (idEquipe, idClient),
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
	idClient INT,
    idPartie INT,
    paiement DECIMAL(4,2),

PRIMARY KEY (idClient, idPartie),
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

INSERT INTO Ville (idVille, nomVille)
	VALUES (1, 'Annecy');
    
INSERT INTO Salle (idSalle, nomSalle, prixSalle, idVille)
	VALUES (1, 'Salle Rouge', 10.5, 1);
    
INSERT INTO Utilisateur (idClient, nom, prenom, photo, adresse, dateNaissance, mailClient, telClient, mailConfirme)
	VALUES (1, 'André', 'Mucrulu', null, 'Rue des fougères', '01-01-01 00:00:00', 'loul@lol.fr', 0660066006, true);
    
INSERT INTO Credits (dateCredits, credit, idClient)
	VALUES ('01-01-01 00:00:00', 25.02, 1);
    
INSERT INTO Notation (idSalle, dateHeure, idClient, note)
	VALUES (1, '01-01-01 00:00:00', 1, 15);
    
INSERT INTO Equipe (idEquipe, nomEquipe)
	VALUES (1, 'Les bg du 74');
    
INSERT INTO Composer (idEquipe, idClient)
	VALUES (1, 1);
    
INSERT INTO Parties (idPartie, dateHeurePartie, nombresEchecs, nbJoueur, nbObstacles, typeObstacle, positionObstacle, nbElement, typeElement, emplacementElement, idSalle, idEquipe)
	VALUES (1, '01-01-01 00:00:00', 0, 0, 0, 'Piège', 'Centre', 0, 'Armes', 'Par terre', 1, 1);
    
INSERT INTO Jouer (idClient, idPartie, paiement)
	VALUES (1, 1, 10.55);
    
INSERT INTO Media (idMedia, photo, video, commentaires, idClient)
	VALUES (1, null, null, null, 1);