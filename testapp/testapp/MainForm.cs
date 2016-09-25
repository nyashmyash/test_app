using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testapp
{
    public partial class MainForm : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public static String pathforbd;
        public String connectionString;
        public MainForm()
        {
            InitializeComponent();
            pathforbd = Application.StartupPath + "\\teatdb.mdf";
        }
        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                connectionString =
                    "Data Source=.\\SQLEXPRESS;AttachDbFilename="+
                     pathforbd 
                    + ";Integrated Security=True;Connect Timeout=30;User Instance=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        private void fillbox()
        {
            cbFilterPosit.Items.Clear();
            cbFilterPosit.Items.Add("Все должности");
            cbFilterPosit.SelectedIndex = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool incb = false;
                foreach (object o in cbFilterPosit.Items)
                    if (o.ToString() == row.Cells["Position"].Value.ToString())
                        incb = true;
                if (!incb)
                    cbFilterPosit.Items.Add(row.Cells["Position"].Value);
                row.Visible = true;
            }
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Worker");

            dataGridView1.Columns[0].Visible = false;

            fillbox();
       
  
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddWorker view = new AddWorker();
            view.ShowDialog();
            if (view.success)
            {
                int maxid = 0;
                foreach (DataGridViewRow rowq in dataGridView1.Rows)
                {
                    int val = Convert.ToInt32(rowq.Cells["ID"].Value);
                    if (val> maxid) maxid =val; 
                }
                DataTable tb = (DataTable)bindingSource1.DataSource;
                DataRow row = tb.NewRow();
                tb.Rows.Add(row);

                row[1] = view.worker.Name;
                row[2] = view.worker.Surname;
                row[3] = view.worker.Position;
                row[4] = view.worker.BirthOfYear;
                row[5] = view.worker.Salary;
               
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
                GetData("select * from Worker");
                fillbox();           
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {

            DataTable tb = (DataTable)bindingSource1.DataSource;
            using (var sc = new SqlConnection(connectionString))
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM Worker WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", tb.Rows[dataGridView1.CurrentRow.Index][0]);
                cmd.ExecuteNonQuery();
            }
          
            tb.Rows.Remove(tb.Rows[dataGridView1.CurrentRow.Index]);
            fillbox();
        }

        private void cbFilterPosit_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(cbFilterPosit.SelectedItem) == "Все должности")
                    row.Visible = true;
                else
                    if (Convert.ToString(row.Cells["Position"].Value) == Convert.ToString(cbFilterPosit.SelectedItem))
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
            }
        }
        
        private void outbtn_Click(object sender, EventArgs e)
        {
            Report rw = new Report();
            rw.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = (OpenFileDialog)sender;
            pathforbd = ofd.FileName;
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Worker");

            dataGridView1.Columns[0].Visible = false;

            fillbox();
        }

        private void btchbd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
