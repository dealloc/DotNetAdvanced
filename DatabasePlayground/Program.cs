using DatabasePlayground.Config;
using System.Data.SqlClient;

var config = ConfigManager.LoadConfiguration();
var connection = new SqlConnection(config.ConnectionString);
