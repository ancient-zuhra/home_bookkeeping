using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace kursova_Zakharenko.Controller
{
    class TransactionQuery
    {
        
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataAdapter dataAdapter;
            DataTable bufferTable;

            public TransactionQuery(string Conn)
            {
                connection = new OleDbConnection(Conn);
                bufferTable = new DataTable();
            }

            public DataTable UpdateTable(int idUser)
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT [TransactionID], [Category], [TransactionValue], [TransactionDate] FROM [Transactions] WHERE [UserID] = '" + idUser+"' ORDER BY [TransactionDate]DESC, [TransactionID] DESC", connection); 
                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
                connection.Close();
                return bufferTable;
            }
        public void Add(string categor, double value, int iduser)
            {
                connection.Open();
                DateTime today = DateTime.Today;
                command = new OleDbCommand($"INSERT INTO [Transactions]([Category],[TransactionValue], [UserID], [TransactionDate]) VALUES (@categor, @value, @iduser, @today)", connection);
                command.Parameters.AddWithValue("Category", categor);
                command.Parameters.AddWithValue("TransactionValue", value);
                command.Parameters.AddWithValue("UserID", iduser);
                command.Parameters.AddWithValue("TransactionDate", today);
                command.ExecuteNonQuery();
                connection.Close();
            }
        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM [Transactions] WHERE TransactionID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditCat(int id, string category )
        {
            connection.Open();
            string query = $"UPDATE [Transactions] SET [Category] = @categor WHERE [TransactionID] = @ID";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("categor", category);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditDate(int id, string date)
        {
            connection.Open();
            string query = $"UPDATE [Transactions] SET [TransactionDate] = @date WHERE [TransactionID] = @ID";
            command = new OleDbCommand(query, connection);
            DateTime date1 = new DateTime();
            int[] intDate = { int.Parse(date.Split('.')[0]), int.Parse(date.Split('.')[1]), int.Parse(date.Split('.')[2]) };
            date1 = new DateTime(intDate[2], intDate[1], intDate[0]);
            command.Parameters.AddWithValue("date", date1);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditValue(int id, double value)
        {
            connection.Open();
            string query = $"UPDATE [Transactions] SET [TransactionValue] = @val WHERE [TransactionID] = @ID";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("val", value);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<double> getListBalances(int id, string datefrom, string datetill)
            {
                List<double> balances= new List<double>();
                string query = $"SELECT [LastBalance] FROM [Transactions] WHERE [UserID]=@ID AND [TransactionDate] BETWEEN @dateFrom AND @dateTill ORDER BY [TransactionDate] ASC, [TransactionID] ASC";
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("ID", id);
            command.Parameters.AddWithValue("dateFrom",datefrom );
            command.Parameters.AddWithValue("dateTill", datetill);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                balances.Add(double.Parse(reader[0].ToString()));
            connection.Close();
            return balances;   
            }

        public List<Transaction> getListOfTransactions(int userid, string datefrom, string datetill)
        {
            List<Transaction> transactions = new List<Transaction>();
            string query = $"SELECT [Category], [TransactionValue] FROM [Transactions] WHERE [UserID] = @userId AND [TransactionDate] BETWEEN @dateFrom AND @dateTill";
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("userId", userid);
            command.Parameters.AddWithValue("dateFrom", datefrom);
            command.Parameters.AddWithValue("dateTill", datetill);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Transaction tr = new Transaction();
                tr.setCategory(reader[0].ToString());
                tr.setValue(double.Parse(reader[1].ToString()));
                transactions.Add(tr);
            }
            connection.Close();
            return transactions;
        }
        public void calculateAllBalances()
        {
            connection.Open();
            string firstQuery = $"SELECT [TransactionID], [TransactionValue], [UserID] FROM [Transactions] ORDER BY  [UserID] ASC, [TransactionID] ASC";
            string secondQuery = $"UPDATE [Transactions] SET[LastBalance] =[@lastBal] WHERE((([TransactionID]) =[@trID]))";
            OleDbCommand command1 = new OleDbCommand(firstQuery, connection);
            OleDbDataReader reader = command1.ExecuteReader();
            double lastBal = 0;
            int userid = 13;
            while (reader.Read())
            {
                if (userid == int.Parse(reader[2].ToString()))
                {
                    lastBal += double.Parse(reader[1].ToString());
                }
                else
                {
                    userid++;
                    lastBal = double.Parse(reader[1].ToString());
                }
                OleDbCommand command2 = new OleDbCommand(secondQuery, connection);
                command2.Parameters.AddWithValue("lastBal", lastBal);
                command2.Parameters.AddWithValue("trID", int.Parse(reader[0].ToString()));
                command2.ExecuteNonQuery();
            }
            reader.Close();
            connection.Close();
        }
            public int calculateBalance(int ID)
            {
            int balance = 0;
            connection.Open();
            string query = $"SELECT [TransactionValue] FROM [Transactions] WHERE [UserID] = '" + ID + "'";
            command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            while(reader.Read())
            balance += int.Parse(reader[0].ToString());
            reader.Close();
            connection.Close();
            return balance;
            }
            
        public Transaction getTransactionById(int id)
        {
            Transaction tr = new Transaction();
            connection.Open();
            string query = $"SELECT * FROM [Transactions] WHERE [TransactionId]=@Id";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("Id",id);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            tr=new Transaction(int.Parse(reader[0].ToString()), reader[1].ToString(), double.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), reader[4].ToString(),double.Parse(reader[5].ToString()));
            reader.Close();
            connection.Close();
            return tr;
        }

        
    }
}
