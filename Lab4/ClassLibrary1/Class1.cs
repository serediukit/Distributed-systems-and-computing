using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary1
{

    [Guid("F53DD0D3-448C-43CD-B3C3-C115E6EFBAC5")]
    public interface IDataLayer
    {
        DataTable GetTable(string ConStr, string Table);
        List<string> GetTables(string ConStr);
        void InsertData(string connectionString, string tableName, string parameters, string data);
        void DeleteDataById(string connectionString, string tableName, string idColumnName, int id);
        DataTable FindDataByValue(string connectionString, string tableName, string columnName, string columnValue);
        DataTable FindDataById(string connectionString, string tableName, string idColumnName, int idValue);
        void EditDataById(string connectionString, string tableName, string idColumnName, int idValue, string parameters, string data);
        DataTable FindData(string connectionString, string tableName, string filterExpression);
        DataTable employee_list(string connectionString);
        DataTable order_list(string connectionString);
    }
}
