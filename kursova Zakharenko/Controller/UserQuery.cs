using System.Data;
using System.Data.OleDb;

namespace kursova_Zakharenko.Controller
{
    class UserQuery
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public UserQuery(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateTable()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM [USERS_TABLE]", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(string login, string password, string name, string question, string answer)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO [USERS_TABLE]([Login],[Password], [User_Name], [SecretQuestion], [SecretAnswer]) VALUES (@login, @password, @name, @question, @answer)", connection);
            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("User_Name", name);
            command.Parameters.AddWithValue("SecretQuestion", question);
            command.Parameters.AddWithValue("SecretAnswer", answer);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void updateBalance(string login, int balance)
        {
            connection.Open();
            string query = $"UPDATE [USERS_TABLE] SET [Balance] = @balanc WHERE [Login]= @log";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@balanc", balance);
            command.Parameters.AddWithValue("@log", login);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM [USERS_TABLE] WHERE UserID = {ID}", connection);
            command.ExecuteNonQuery();
            command = new OleDbCommand($"DELETE FROM [Transactions]WHERE UserID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
       
        public User getUser(string log)
        {
            connection.Open();
            string query = $"SELECT * FROM [USERS_TABLE] WHERE [Login] = '"+log+"'";
            command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            User buffUser = new User();
            if (reader.HasRows)
            {
                buffUser = new User(int.Parse(reader[0].ToString()), reader.GetValue(1).ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(),reader[6].ToString());
            }
            reader.Close();
            connection.Close();
            return buffUser;
        }
        public int getBalance(string log)
        {
            int balance = 0;
            connection.Open();
            string query = $"SELECT [Balance] FROM [USERS_TABLE] WHERE [Login] = '" + log + "'";
            command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            balance = int.Parse(reader[0].ToString());
            reader.Close();
            connection.Close();
            return balance;
        }
        public bool checkSameLogin(string log)
        {
            bool flag=false;
            connection.Open();
            string query = $"SELECT [Login] FROM [USERS_TABLE] WHERE [Login] = '" + log + "'";
            command = new OleDbCommand(query, connection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                reader.Close();
            }
            catch 
            {
                flag = false;
            }
            connection.Close();
            return flag;
        }

    }
}
