--========================================
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

    