using DatabasePlayground.Config;
using System.Data.SqlClient;

static int Insert(SqlConnection connection, SqlTransaction transaction)
{
    using var insertCommand = connection.CreateCommand();
    insertCommand.Transaction = transaction;
    insertCommand.CommandText = "INSERT INTO [Students] ([FirstName], [LastName]) VALUES ('Wannes', 'Gennar'); SELECT SCOPE_IDENTITY()";
    using var insertReader = insertCommand.ExecuteReader();
    insertReader.Read();
    return (int)insertReader.GetDecimal(0);
}

static void Update(SqlConnection connection, SqlTransaction transaction, int id)
{
    using var updateCommand = connection.CreateCommand();
    updateCommand.Transaction = transaction;
    updateCommand.CommandText = "UPDATE [Students] [CreatedOn] = GETDATE(), [ModifiedOn] = GETDATE() WHERE [Id] = @Id";
    updateCommand.Parameters.AddWithValue("@Id", id);

    updateCommand.ExecuteNonQuery();
}

var config = ConfigManager.LoadConfiguration();
var connection = new SqlConnection(config.ConnectionString);
connection.Open();

using var transation = connection.BeginTransaction();

try
{
    int id = Insert(connection, transation);
    Update(connection, transation, id);
    transation.Commit();
}
catch (Exception)
{
    transation.Rollback();
}