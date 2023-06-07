using Lab3.ComSrv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;


namespace Lab3.client
{
    [ComImport, Guid("F53DD0D3-448C-43CD-B3C3-C115E6EFBAC5")]



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

    public partial class Form1 : Form
    {
        private IDataLayer comObject = new DBComSrv() as IDataLayer;
        Type type;
        Object ComSrv;

        MethodInfo mi;
        string connection = @"Provider=SQLOLEDB;Data Source=PC-XIAOMIPRO15;Integrated Security=SSPI;Initial Catalog=FOOD_DELIVARY_MAIN_OFFICE";

        public Form1()
        {
            InitializeComponent();

            type = Type.GetTypeFromProgID("Lab3.ComSrv.DBComSrv");
            if (type != null)
            {
                ComSrv = Activator.CreateInstance(type);
                if (ComSrv != null)
                {
                    MessageBox.Show("ComSrv is created");
                }
                else
                    MessageBox.Show("ComSrv is not created");
            }
            else
                MessageBox.Show("ComSrv type is not found");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            mi = type.GetMethod("GetTables");
            List<string> ls = (List<string>)mi.Invoke(ComSrv, new object[] { connection });
            DataTable dt = new DataTable();
            dt.Columns.Add("tables");


            foreach (string table in ls)
            {
                dt.Rows.Add(table);
            }


            resultintable.DataSource = dt;

            Console.Write(ls);

        }
        public void get_table_by_name(object sender, EventArgs e)
        {
            string tname = table_name.Text;
            mi = type.GetMethod("GetTable");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tname });
            resultintable.DataSource = dt;

        }
        private void insert_data_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string ps = parameters.Text;
            string ds = data.Text;
            mi = type.GetMethod("InsertData");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tn, ps, ds });
            resultintable.DataSource = dt;
        }

        private void find_by_id_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string idc = "id";
            string id_string = table_id.Text;
            int id = int.Parse(id_string);
            mi = type.GetMethod("FindDataById");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tn, idc, id });
            resultintable.DataSource = dt;
        }

        private void delete_by_id_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string idc = "id";
            string id_string = table_id.Text;
            int id = int.Parse(id_string);
            mi = type.GetMethod("DeleteDataById");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tn, idc, id });
            resultintable.DataSource = dt;

        }

        private void find_by_value_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string cn = column_name.Text;
            string cv = table_value.Text;
            mi = type.GetMethod("FindDataByValue");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tn, cn, cv });
            resultintable.DataSource = dt;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string idc = "id";
            string id_string = table_id.Text;
            int id = int.Parse(id_string);
            string ps = parameters.Text;
            string ds = data.Text;
            mi = type.GetMethod("EditDataById");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tn, idc, id, ps, ds });
            resultintable.DataSource = dt;

        }

        private void find_by_filter_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string ft = filter.Text;
            mi = type.GetMethod("FindData");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection, tn, ft });
            resultintable.DataSource = dt;


        }
        private void employee_list_Click(object sender, EventArgs e)
        {
            mi = type.GetMethod("employee_list");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection });
            resultintable.DataSource = dt;

        }


        private void order_list_Click(object sender, EventArgs e)
        {
            mi = type.GetMethod("order_list");
            DataTable dt = (DataTable)mi.Invoke(ComSrv, new object[] { connection });
            resultintable.DataSource = dt;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}
