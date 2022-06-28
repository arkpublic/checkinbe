using NUnit.Framework;
using RestaurantModels.SetupModels;
using System.Threading.Tasks;

namespace RestaurantProvider.Test
{
    public class ConnectionTesting
    {
        private Connection _sut;
        private DatabaseConnectionModel _connectionModel;

        [SetUp]
        public void Setup()
        {
            //72.167.55.217
            //N0m3l0s3!
            //su 
            //CREATE USER 'checkinguser'@'localhost' IDENTIFIED BY 'Checking321!';
            //mysql> CREATE USER 'checkinguser'@'%' IDENTIFIED BY 'N0m3l0s3!';
//            Query OK, 0 rows affected(0.01 sec)

//mysql > GRANT ALL PRIVILEGES ON database.checkingdb TO 'checkinguser'@'%';
//            Query OK, 0 rows affected(0.00 sec)

//mysql > flush privileges;
//and remove 0.0.0.0 from mysqld.conf
            this._connectionModel = new DatabaseConnectionModel();
            this._connectionModel.Database = "checkindb";
            this._connectionModel.Server = "72.167.55.217";
            this._connectionModel.User = "checkinguser";
            this._connectionModel.Password = "N0m3l0s3!";
            this._sut = new Connection(this._connectionModel);
        }

        [Test]
        public async Task ShouldConnect()
        {
            await _sut.RunQueryAsync();
            Assert.IsTrue(true);
        }
    }
}