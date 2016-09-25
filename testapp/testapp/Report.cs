using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace testapp
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        
        private void Report_Load(object sender, EventArgs e)
        {
            String connectionString =
                   "Data Source=.\\SQLEXPRESS;AttachDbFilename=" +
                   MainForm.pathforbd
                   + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
 
            dataAdapter = new SqlDataAdapter("select * from Worker", connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(
                        "DataSet1", table));   
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "testapp.Report1.rdlc";

            this.reportViewer1.LocalReport.Refresh();
           // this.teatdbDataSet = new testapp.teatdbDataSet();
           
            //his.WorkerTableAdapter.Fill(this.teatdbDataSet.Worker);
     
  
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.RefreshReport();    
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
