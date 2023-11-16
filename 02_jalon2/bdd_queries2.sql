


-- IRST SCRYPT:
-- ==============================================================================================================================================
CREATE TABLE materiel2 (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    serviceDat datetime,
    endGarantee datetime,
    hire_date DATE,
    salary FLOAT,
    proprietaireId bigint(20) unsigned,
    FOREIGN KEY (proprietaireId) REFERENCES users(id)
);

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
--===============================================================================================================================================
--SECOND SCRYPT
--================================================================================================================================================
--Creation of the material table materiel:
CREATE  TABLE materiel(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
name varchar(20),
   fk_refCat int,
   fk_idMat int,
    serviceDat datetime,
    endGarntee datetime
);
    --===================================================
    -- ADD COLUMN propriétaireId:
    ALTER TABLE materiel 
ADD  propriétaireId bigint(20) UNSIGNED;
--===================================================
ALTER TABLE filrouge.materiel ADD CONSTRAINT materiel_FK FOREIGN KEY (propriétaireId) REFERENCES filrouge.users(id);
--============================================================
--Création of the material categories CategoryMateriel table:
create table CategoryMateriel(
    refCat INT, 
    idMat INT 
);
--========================================
--Addition of the fk_materialId foreign key on categoryMateriel table:

ALTER TABLE CategoryMateriel
ADD constraint fk_materialId FOREIGN KEY (idMat) REFERENCES materiel(id);
--=============================================
--Addition of the fk_categoryReference foreign key on categoryMateriel table:
ALTER TABLE CategoryMateriel
ADD constraint fk_categoryReference FOREIGN KEY (refCat) REFERENCES category(ref);
--======================================================
-- TABLE MATERIEL:
  
CREATE TABLE materiel (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    serviceDat datetime,
    endGarantee datetime,
    hire_date DATE,
    salary FLOAT,
    proprietaireId bigint(20) unsigned,
    FOREIGN KEY (proprietaireId) REFERENCES users(id)
);
--=====================================================
--TABLE GATEGORY:
CREATE TABLE category (
    ref INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);
--=====================================================
-- TABLE CATEGORYMATERIEL:
 create table CategoryMateriel(
  refCat int,
  idMat int,
  FOREIGN KEY (refCat) REFERENCES category(ref),
  FOREIGN KEY (idMat) REFERENCES materiel(id)
 );
   --===========================================================================
   -- PEUPLEMENT DE LA TABLE MATERIEL AVEC 4 ELEMENTS:
   -- ===========================================================================
INSERT INTO materiel (name, serviceDat, endGarantee, propriétaireID) VALUES 
('Ordinateur portable', '2023-01-01', '2025-01-01', 1),
('Imprimante', '2022-05-15', '2024-05-15', 2),
('Projecteur', '2023-03-10', '2025-03-10', 3),
('Casque audio', '2023-07-20', '2025-07-20', 4),
('Écran LCD', '2022-12-10', '2024-12-10', 5);
-- 3eme SCRYPT:
-- ==============================================================================================================================================