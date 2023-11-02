CREATE TABLE materiel (
  serialNumber INT auto_increment PRIMARY KEY,
  acquisitionDate DATETIME,
  location varchar(50));
-- ================================================================================
--  Cette instruction sql crée une table appelée materiel avec les colonnes et contraintes suivantes :

-- serialNumber : un entier qui est un identifiant unique auto incrémenté pour chaque matériel.
-- acquisitionDate : une date et une heure qui stockent une date.
-- location : une chaîne de caractères qui stocke l'emplacement  de l'équipement.
-- idUser : un entier qui est une clé étrangère qui référence la colonne id de la table User. 
--
--Création de la table category referençant le différentes catégogies de matériels avec un identifiant de catégorie not null auto incrémenté et un nom(varchar) not null.
-- La contrainte de clef primaire est placé sur l'identifiant des atégories.

CREATE TABLE category (
  categoryID INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  PRIMARY KEY (categoryID)
);
-- ================================================================================
--Création dela table de liaison userMateriel comportant un id   incrémenté en clef primaire etdeux clefs étrangères , une pointant ver l'id de la table user, et une autre pointant vers le numéro de série de la table matériel.

CREATE TABLE userMateriel (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT,
  materiel_serialNumber INT,
  -- FOREIGN KEY (user_id) REFERENCES users (id),
  FOREIGN KEY (materiel_serialNumber) REFERENCES materiel(serialNumber)
  );
-- ================================================================================
-- Ajut de la contrainte de clef étrangère pointant ver l'id de la table users
 ALTER TABLE userMateriel
ADD CONSTRAINT fk_userMateriel_userID
FOREIGN KEY (user_id)
REFERENCES user (id)
ON DELETE CASCADE;

-- ON DELETE CASCADE : Cette clause indique que les lignes de la table userMateriel 
-- qui font référence à une ligne supprimée de la table user 
-- seront également supprimées.

--Requete invalide pour la création de la table CategoryMateriel :
CREATE TABLE categoryMateriel (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idMat INT,
    FOREIGN KEY (idMat) REFERENCES Materiel(serialNumber)
);
-- La requête est donnée cmme invalide pour une mauvaise déclaration de clef étrangère mais la syntaxe et les type sembles bons.