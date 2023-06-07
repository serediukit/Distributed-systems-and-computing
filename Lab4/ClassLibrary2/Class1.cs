using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Data;
using System.Data.OleDb;
using ClassLibrary1;
using System.Collections.Generic;


namespace ClassLibrary2
{



    public class RemoteDataLayer : MarshalByRefObject, IDataLayer
    {

        public void InsertData(string connectionString, string tableName, string parameters, string data)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string cmd = $"INSERT INTO {tableName} ({parameters}) VALUES ('{data}')";
                Console.WriteLine(cmd);
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteDataById(string connectionString, string tableName, string idColumnName, int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand($"DELETE FROM {tableName} WHERE {idColumnName} ={id}", connection);
                command.ExecuteNonQuery();
            }
        }

        public List<string> GetTables(string connectionString)
        {
            List<string> ls = new List<string>();
            ls.Clear();
            OleDbConnection cn = new OleDbConnection(ConStr);
            cn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM sys.tables", cn);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                ls.Add(r.GetString(0));
            }
            cn.Close();
            return ls;
        }
        public DataTable GetTable(string connectionString, string table)
        {
            OleDbConnection cn = new OleDbConnection(connectionString);
            cn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + table, cn);
            OleDbDataReader r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            cn.Close();
            return dt;
        }

        public DataTable FindDataByValue(string connectionString, string tableName, string columnName, string columnValue)
        {

            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = new OleDbCommand($"SELECT * FROM {tableName} WHERE {columnName} ={columnValue}", connection);
            DataTable dt = new DataTable();
            OleDbDataReader r = command.ExecuteReader();
            dt.Load(r);
            connection.Close();
            return dt;

        }

        public DataTable FindDataById(string connectionString, string tableName, string idColumnName, int idValue)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = new OleDbCommand($"SELECT * FROM {tableName} WHERE {idColumnName} = {idValue}", connection);
            DataTable dt = new DataTable();
            OleDbDataReader r = command.ExecuteReader();
            dt.Load(r);
            connection.Close();
            return dt;
        }
        public void EditDataById(string connectionString, string tableName, string idColumnName, int idValue, string parameters, string data)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand($"UPDATE {tableName} SET {parameters} = {data}  WHERE {idColumnName} ={idValue}", connection);
                command.ExecuteNonQuery();
            }
        }
        public DataTable FindData(string connectionString, string tableName, string filterExpression)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);

            connection.Open();
            OleDbCommand command = new OleDbCommand($"SELECT * FROM {tableName} WHERE {filterExpression}", connection);
            DataTable dt = new DataTable();
            OleDbDataReader r = command.ExecuteReader();
            dt.Load(r);
            connection.Close();
            return dt;

        }


        public DataTable employee_list(string connectionString)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);

            connection.Open();
            string commandText = $"SELECT \r\n    e.firstname, e.middlename, e.lastname, e.address,e.phone_number, \r\n    d.name, \r\n    p.name \r\nFROM \r\n    FOOD_DELIVERY_MAIN_OFFICE.dbo.employee AS e\r\n    INNER JOIN FOOD_DELIVERY_MAIN_OFFICE.dbo.department AS d ON e.id_department = d.id\r\n    INNER JOIN FOOD_DELIVERY_MAIN_OFFICE.dbo.position AS p ON e.id_position = p.id \r\n\tUNION\r\n\tSELECT \r\n    e.firstname, e.middlename, e.lastname, e.address, e.phone_number, \r\n    d.name, \r\n    p.name \r\nFROM \r\n    [PC-XIAOMIPRO15\\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.employee AS e\r\n    INNER JOIN [PC-XIAOMIPRO15\\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.department AS d ON e.id_department = d.id\r\n    INNER JOIN [PC-XIAOMIPRO15\\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.position AS p ON e.id_position = p.id;\r\n";
            OleDbCommand command = new OleDbCommand(commandText, connection);
            DataTable dt = new DataTable();
            OleDbDataReader r = command.ExecuteReader();
            dt.Load(r);
            connection.Close();
            return dt;

        }

        public DataTable order_list(string connectionString)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);

            connection.Open();
            string commandText = $"\tSELECT _order.id, _order.order_list, _order.destination_adress, act_of_order._date, act_of_order.payment_amoun, act_of_order.is_done\r\nFROM FOOD_DELIVERY_MAIN_OFFICE.dbo._order\r\nJOIN FOOD_DELIVERY_MAIN_OFFICE.dbo.act_of_order ON _order.id = act_of_order.id_order\r\n\tUNION\r\n\tSELECT _order.id, _order.order_list, _order.destination_adress, act_of_order._date, act_of_order.payment_amoun, act_of_order.is_done\r\nFROM [PC-XIAOMIPRO15\\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo._order\r\nJOIN [PC-XIAOMIPRO15\\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.act_of_order ON _order.id = act_of_order.id_order;";
            OleDbCommand command = new OleDbCommand(commandText, connection);
            DataTable dt = new DataTable();
            OleDbDataReader r = command.ExecuteReader();
            dt.Load(r);
            connection.Close();
            return dt;

        }
    }
}

