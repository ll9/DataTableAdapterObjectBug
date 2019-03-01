using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableAdapterObjectBug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var connection = GetConnection())
            using (var command = new SQLiteCommand("SELECT * FROM TESTTABLE", connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                var table = new DataTable();
                adapter.Fill(table);
                var annonymousObject = table.Columns.Cast<DataColumn>().Select(c => new { c.ColumnName, c.DataType });
            }
        }

        public SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection("Data Source=Db\\db.sqlite");
            connection.Open();
            return connection;
        }
    }
}
