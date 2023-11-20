



    USE filrouge;
      --===========================================================================
   -- CREATION OF THE :
   -- ===========================================================================
-- TABLE MATERIEL:
  
CREATE TABLE IF NOT EXISTS materiel (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    serviceDat datetime,
    endGarantee datetime,

    proprietaireId bigint(20) unsigned,
    FOREIGN KEY (proprietaireId) REFERENCES users(id)
);
--=====================================================
--TABLE GATEGORY:
CREATE TABLE IF NOT EXISTS  category (
    ref INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);
--=====================================================
-- TABLE CATEGORYMATERIEL:
 create TABLE IF NOT EXISTS  CategoryMateriel(
  refCat int,
  idMat int,
  FOREIGN KEY (refCat) REFERENCES category(ref),
  FOREIGN KEY (idMat) REFERENCES materiel(id)
 );
  --===========================================================================
 ALTER TABLE filrouge.category CHANGE `ref` reference int(11) NOT NULL;

  
      --===========================================================================
   -- PEUPLEMENT DE LA TABLE MATERIEL AVEC 4 ELEMENTS:
   -- ===========================================================================
INSERT INTO materiel (name, serviceDat, endGarantee, proprietaireId) 
VALUES 
('Ordinateur portable', '2023-01-15', '2025-01-15', 1),
('Imprimante', '2023-02-20', '2024-02-20', 2),
('Projecteur', '2023-03-10', '2025-03-10', 1),
('Écran LCD', '2023-04-05', '2024-04-05', 3);
    --===========================================================================
   -- PEUPLEMENT DE LA TABLE CATEGORY AVEC 4 ELEMENTS:
   -- ===========================================================================
INSERT INTO category (ref, name)
VALUES 
(1, 'Électronique'),
(2, 'Mobilier'),
(3, 'Outils'),
(4, 'Accessoires');