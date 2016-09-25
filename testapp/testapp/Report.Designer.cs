namespace testapp
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.WorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teatdbDataSet = new testapp.teatdbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WorkerTableAdapter = new testapp.teatdbDataSetTableAdapters.WorkerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkerBindingSource
            // 
            this.WorkerBindingSource.DataMember = "Worker";
            this.WorkerBindingSource.DataSource = this.teatdbDataSet;
            // 
            // teatdbDataSet
            // 
            this.teatdbDataSet.DataSetName = "teatdbDataSet";
            this.teatdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.WorkerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "testapp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1022, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // WorkerTableAdapter
            // 
            this.WorkerTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Report_FormClosed);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WorkerBindingSource;
        private teatdbDataSet teatdbDataSet;
        private teatdbDataSetTableAdapters.WorkerTableAdapter WorkerTableAdapter;
    }
}