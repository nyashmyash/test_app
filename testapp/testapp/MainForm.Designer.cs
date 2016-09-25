namespace testapp
{
    partial class MainForm
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
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.outbtn = new System.Windows.Forms.Button();
            this.cbFilterPosit = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btchbd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(650, 43);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(650, 73);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(100, 23);
            this.delbtn.TabIndex = 2;
            this.delbtn.Text = "Удалить";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // outbtn
            // 
            this.outbtn.Location = new System.Drawing.Point(650, 103);
            this.outbtn.Name = "outbtn";
            this.outbtn.Size = new System.Drawing.Size(100, 23);
            this.outbtn.TabIndex = 3;
            this.outbtn.Text = "Отчет";
            this.outbtn.UseVisualStyleBackColor = true;
            this.outbtn.Click += new System.EventHandler(this.outbtn_Click);
            // 
            // cbFilterPosit
            // 
            this.cbFilterPosit.FormattingEnabled = true;
            this.cbFilterPosit.Location = new System.Drawing.Point(196, 9);
            this.cbFilterPosit.Name = "cbFilterPosit";
            this.cbFilterPosit.Size = new System.Drawing.Size(184, 24);
            this.cbFilterPosit.TabIndex = 4;
            this.cbFilterPosit.SelectedIndexChanged += new System.EventHandler(this.cbFilterPosit_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(29, 12);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(152, 17);
            this.lbFilter.TabIndex = 5;
            this.lbFilter.Text = "фильтр по должности";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 356);
            this.dataGridView1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "data base files (*.mdf)|*.mdf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btchbd
            // 
            this.btchbd.Location = new System.Drawing.Point(650, 351);
            this.btchbd.Name = "btchbd";
            this.btchbd.Size = new System.Drawing.Size(100, 48);
            this.btchbd.TabIndex = 7;
            this.btchbd.Text = "Выбрать базу";
            this.btchbd.UseVisualStyleBackColor = true;
            this.btchbd.Click += new System.EventHandler(this.btchbd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 411);
            this.Controls.Add(this.btchbd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.cbFilterPosit);
            this.Controls.Add(this.outbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Name = "MainForm";
            this.Text = "test app";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button outbtn;
        private System.Windows.Forms.ComboBox cbFilterPosit;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btchbd;
    }
}

