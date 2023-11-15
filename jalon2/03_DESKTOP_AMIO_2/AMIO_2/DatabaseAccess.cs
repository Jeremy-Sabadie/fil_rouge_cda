using Dapper;
using MySql.Data.MySqlClient;

namespace AMIO_2
{
    internal class DatabaseAccess
    {
        private MySqlConnection _dbconnection;
        public DatabaseAccess()
        {

            _dbconnection = new("Server=lab005.2isa.org;Port=33005;Database=dbWinForm;UID=root;PWD=1365lab005");
        }
        //READ  of the CRUD:
        public IEnumerable<Materiel> GetAllMaterials()
        {
            try
            {
                _dbconnection.Open();
                string selectAllQuery = "select * from materiel";
                return _dbconnection.Query<Materiel>(selectAllQuery);

            }

            finally
            {
                _dbconnection.Close();
            }
        }
        //CREATE of the CRUD:
        public int AddMaterial(string name)
        {
            try
            {
                _dbconnection.Open();
                var insertQuery = "INSERT INTO article (name, serviceDat , endGarntee,propriétaireId) VALUES (@name, @endGarntee,@propriétaireId); SELECT LAST_INSERT_ID() ";
                var result = _dbconnection.Query<int>(insertQuery, new { name });
                return result.Single();
            }
            finally
            {
                _dbconnection.Close();
            }
        }
        //UPDATE of the CRUD:
        public int updateMaterial(string name)
        {
            try
            {
                _dbconnection.Open();
                var updateQuery = "UPDATE materiel SET name = @name," +
                    "serviceDat= @serviceDat,endGarntee=@endGarntee, propriétaireId=@propriétaireId WHERE id = @id ;";
                return _dbconnection.Execute(updateQuery, new { name });

            }
            finally
            {
                _dbconnection.Close();
            }

        }
    }
}
