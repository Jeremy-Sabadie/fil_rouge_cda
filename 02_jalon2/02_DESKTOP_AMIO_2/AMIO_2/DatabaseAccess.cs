using Dapper;
using MySql.Data.MySqlClient;

namespace AMIO_2
{
    internal class DatabaseAccess
    {
        private MySqlConnection _dbconnection;
        public DatabaseAccess()
        {

            _dbconnection = new("Server=lab005.2isa.org;Port=33005;Database=filrouge;UID=root;PWD=1365lab005");
        }
        #region CRUD-read 
        //READ  of the CRUD:
        public async Task<IEnumerable<Materiel>> GetMaterialsAsync()
        {
            try
            {
                await _dbconnection.OpenAsync();
                string selectAllQuery = "select * from materiel";
                return await _dbconnection.QueryAsync<Materiel>(selectAllQuery);

            }

            finally
            {
                _dbconnection.Close();
            }
        }
        #endregion
        #region CRUD-create
        //CREATE of the CRUD:
        public async Task<int> AddMaterialAsync(string name, DateTime serviceDat, DateTime endGarantee, string ownerName)
        {
            try
            {
                await _dbconnection.OpenAsync();
                var insertQuery = "INSERT INTO article (name, serviceDat , endGarntee,propriétaireId) VALUES (@name, @endGarntee,@propriétaireId); SELECT LAST_INSERT_ID() ";
                var result = _dbconnection.Query<int>(insertQuery, new { name });
                return result.Single();
            }
            finally
            {
                _dbconnection.Close();
            }
        }
        #endregion
        //UPDATE of the CRUD:
        #region CRUD-update
        public int updateMaterial(string oldName, DateTime oldServiceDat, DateTime oldEndGarantee, int oldProprietaireId, string newName, DateTime newServiceDat, DateTime newEndGarantee, int newProprietaireId)
        {
            try
            {
                _dbconnection.Open();
                var updateQuery = "UPDATE materiel SET name = @newName," +
                    "serviceDat= @newServiceDat,endGarntee=@newEndGarantee, propriétaireId=@propriétaireId WHERE id = @oldProprietaireId where id=oldProprietaireId;";
                return _dbconnection.Execute(updateQuery, new { newName, newServiceDat, newEndGarantee, newProprietaireId });

            }
            finally
            {
                _dbconnection.Close();
            }

        }
        #endregion
        #region CRUD delete
        //TO DO: DELETE for the crud:
        async Task<int> DeleteMaterielAsync(string name, int id)
        {
            //Variable contenant la requête pour la suppression de l'article:
            var deleteQuery = "delete from materiel were id = @id";
            // Affichage de la boîte de dialogue pour confirmation:
            var confirmResult = MessageBox.Show($"Confirmez-vous la suppression du matériel: {name} ?", "confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _dbconnection.OpenAsync();
                    var res = await _dbconnection.ExecuteAsync(deleteQuery, new { name, id });
                    return res;
                }
                finally { await _dbconnection.CloseAsync(); }

            }

            #endregion
        }
    }
}

