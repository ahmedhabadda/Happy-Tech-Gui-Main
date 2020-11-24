using System.Data.SqlClient;
using System.Data;


namespace Happy_Tech_UI
{
    public class DatabaseConnection
    {
        public static DatabaseConnection _instance;
        private readonly string connectionStr;
        private SqlConnection ConnectionToDB;

        //Contstructor to set the connection 
        private DatabaseConnection()
        {
            connectionStr = Properties.Settings.Default.ConnectionString;
            ConnectionToDB = new SqlConnection(Properties.Settings.Default.ConnectionString); // making connection   
        }
        
        //Method to return database connection
        public static DatabaseConnection GetDatabaseConnection()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;
        }

        //Method to get the data set by the Sql Statement
        public DataSet GetDataSet(string sqlStatement)
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



        public bool IsValidUser(string username, string password)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM USERS WHERE username='" + username + "' AND password='" + password + "'", ConnectionToDB);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);

            //Database contains one row that has username and password?
            return dt.Rows[0][0].ToString() == "1";
        }
    }
}