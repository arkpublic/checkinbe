using MySqlConnector;
using RestaurantModels.SetupModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProvider
{
    public class Connection
    {
        private string _databaseConnectionModel;

        public Connection(DatabaseConnectionModel databaseConnectionModel)
        {
            this._databaseConnectionModel = BuildConnectionString(databaseConnectionModel);
        }

        private string BuildConnectionString(DatabaseConnectionModel databaseConnectionModel)
        {
            return "server=" + databaseConnectionModel.Server
                + ";user=" + databaseConnectionModel.User
                + ";password=" + databaseConnectionModel.Password
                + ";database=" + databaseConnectionModel.Database;
        }

        public async Task RunQueryAsync() {
            using var connection = new MySqlConnection(this._databaseConnectionModel);
            await connection.OpenAsync();

            using var command = new MySqlCommand("SELECT * FROM user;", connection);
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var value = reader.GetValue(0);
                // do something with 'value'
            }
        }
    }
}
