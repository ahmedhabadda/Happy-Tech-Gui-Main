using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Happy_Tech_Gui_Main.Classes
{
    class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static string connectionStr;
        private SqlConnection ConnectionToDB;

        //Contstructor to set the connection 
        private DatabaseConnection()
        {
            connectionStr = Properties.Settings.Default.UserConnection;
        }
        
        //Method to return database connection
        public static DatabaseConnection GetDatabaseConnection()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;
        }

        //Method to get the data set by the Sql Statement
        public DataSet GetDataSet(String sqlStatement)
        {
            DataSet dataSet = new DataSet();
            using (ConnectionToDB = new SqlConnection(connectionStr))
            {

                ConnectionToDB.Open();
                //creation of the obj dataAdapter to manipulate a table from the database.
                //It is specify by ConnectionToDB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, ConnectionToDB);
                dataAdapter.Fill(dataSet);
                ConnectionToDB.Close();
            }
            return dataSet;
        }
    }
}