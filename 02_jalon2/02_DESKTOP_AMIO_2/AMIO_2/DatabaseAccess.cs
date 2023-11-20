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
        /// <summary>
        /// Asynchronously retrieves the list of materials from the database.
        /// </summary>
        /// <returns>An asynchronous task that returns a collection of Materiel objects.</returns>
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
        /// <summary>
        /// Adds a new material entry to the database with specified details.
        /// </summary>
        /// <param name="name">The name of the material.</param>
        /// <param name="serviceDat">The service date of the material.</param>
        /// <param name="endGarantee">The end guarantee date of the material.</param>
        /// <param name="ownerName">The name of the owner for the material.</param>
        /// <returns>An asynchronous task returning the ID of the newly inserted material.</returns>
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
        /// <summary>
        /// Asynchronously deletes a material from the database based on its name and ID.
        /// </summary>
        /// <param name="oldName">The current name of the material.</param>
        /// <param name="oldServiceDat">The current service date of the material.</param>
        /// <param name="oldEndGarantee">The current end guarantee date of the material.</param>
        /// <param name="oldProprietaireId">The current owner ID of the material.</param>
        /// <param name="newName">The new name to be updated.</param>
        /// <param name="newServiceDat">The new service date to be updated.</param>
        /// <param name="newEndGarantee">The new end guarantee date to be updated.</param>
        /// <param name="newProprietaireId">The new owner ID to be updated.</param>
        /// <returns>The number of rows affected by the update operation.</returns>
        #region CRUD-update
        public int updateMaterial(string oldName, DateTime oldServiceDat, DateTime oldEndGarantee, string newName, DateTime newServiceDat, DateTime newEndGarantee)
        {
            try
            {
                _dbconnection.Open();
                var updateQuery = "UPDATE materiel SET name = @newName," +
                    "serviceDat= @newServiceDat,endGarntee=@newEndGarantee, propriétaireId=@propriétaireId WHERE id = @oldProprietaireId where id=oldProprietaireId;";
                return _dbconnection.Execute(updateQuery, new { newName, newServiceDat, newEndGarantee });

            }
            finally
            {
                _dbconnection.Close();
            }

        }
        #endregion

        #region CRUD-delete
        //TO DO: DELETE for the crud:
        /// <summary>
        /// Asynchronously deletes a material from the database based on its name and ID.
        /// </summary>
        /// <param name="name">The name of the material to be deleted.</param>
        /// <param name="id">The ID of the material to be deleted.</param>
        /// <returns>An asynchronous task that returns an integer representing the number of affected rows.</returns>
        public async Task<int> DeleteMaterielAsync(string name, int id)
        {
            //Variable contenant la requête pour la suppression de l'article:
            var deleteQuery = "delete from materiel were id = @id";
            // Affichage de la boîte de dialogue pour confirmation:

            try
            {
                await _dbconnection.OpenAsync();
                var res = await _dbconnection.ExecuteAsync(deleteQuery, new { name, id });
                return res;
            }
            finally { await _dbconnection.CloseAsync(); }



            #endregion

        }
        // Function to retrive all the categories to be integrated into the combobox choice. 
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            try
            {
                await _dbconnection.OpenAsync();
                string selectAllCategoryQuery = "select name from category";
                return await _dbconnection.QueryAsync<Category>(selectAllCategoryQuery);

            }

            finally
            {
                _dbconnection.Close();
            }
        }
    }
}

