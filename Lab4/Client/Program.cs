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
using System.Security.Cryptography;
using ClassLibrary1;
using ClassLibrary2;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace Client
{
    [ComImport, Guid("F53DD0D3-448C-43CD-B3C3-C115E6EFBAC5")]

    public partial class Form1 : Form
    {
        Type type;
        RemoteDataLayer serviceFromTcp;
        MethodInfo mi;
        string connection = @"Provider=SQLOLEDB;Data Source=PC-XIAOMIPRO15;Integrated Security=SSPI;Initial Catalog=FODD_DELIVERY_MAIN_OFFICE";

        public Form1()
        {
            InitializeComponent();
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);
            serviceFromTcp = (RemoteDataLayer)Activator.GetObject(typeof(RemoteDataLayer), "tcp://localhost:8099/Service");

        }



        public void button1_Click(object sender, EventArgs e)
        {
            List<string> tables = serviceFromTcp.GetTables(connection);

            DataTable table = new DataTable();
            table.Columns.Add("Table Name");

            foreach (string t in tables)
            {
                table.Rows.Add(t);
            }

            resultintable.DataSource = table;


        }
        public void get_table_by_name(object sender, EventArgs e)
        {
            string st = table_name.Text;
            DataTable table = serviceFromTcp.GetTable(connection, st);
            resultintable.DataSource = table;

        }
        private void insert_data_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string ps = parameters.Text;
            string ds = data.Text;
            serviceFromTcp.InsertData(connection, tn, ps, ds);
        }

        private void find_by_id_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string idc = "id";
            string id_string = table_id.Text;
            int id = int.Parse(id_string);
            DataTable table = serviceFromTcp.FindDataById(connection, tn, idc, id);
            resultintable.DataSource = table;
        }

        private void delete_by_id_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string idc = "id";
            string id_string = table_id.Text;
            int id = int.Parse(id_string);
            serviceFromTcp.DeleteDataById(connection, tn, idc, id);
        }

        private void find_by_value_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string cn = column_name.Text;
            string cv = table_value.Text;
            DataTable table = serviceFromTcp.FindDataByValue(connection, tn, cn, cv);
            resultintable.DataSource = table;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string idc = "id";
            string id_string = table_id.Text;
            int id = int.Parse(id_string);
            string ps = parameters.Text;
            string ds = data.Text;
            serviceFromTcp.EditDataById(connection, tn, idc, id, ps, ds);

        }

        private void find_by_filter_Click(object sender, EventArgs e)
        {
            string tn = table_name.Text;
            string ft = filter.Text;
            DataTable dt = serviceFromTcp.FindData(connection, tn, ft);
            resultintable.DataSource = dt;


        }
        private void employee_list_Click(object sender, EventArgs e)
        {
            DataTable dt = serviceFromTcp.employee_list(connection);
            resultintable.DataSource = dt;
        }


        private void order_list_Click(object sender, EventArgs e)
        {
            DataTable dt = serviceFromTcp.order_list(connection);
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
