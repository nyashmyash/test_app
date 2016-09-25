namespace testapp
{
    partial class AddWorker
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
            this.btok = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurn = new System.Windows.Forms.Label();
            this.lbPosit = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbSal = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurn = new System.Windows.Forms.TextBox();
            this.textPos = new System.Windows.Forms.TextBox();
            this.textBirth = new System.Windows.Forms.TextBox();
            this.textSalar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(375, 13);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(100, 32);
            this.btok.TabIndex = 0;
            this.btok.Text = "Применить";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя";
            // 
            // lbSurn
            // 
            this.lbSurn.AutoSize = true;
            this.lbSurn.Location = new System.Drawing.Point(13, 43);
            this.lbSurn.Name = "lbSurn";
            this.lbSurn.Size = new System.Drawing.Size(70, 17);
            this.lbSurn.TabIndex = 2;
            this.lbSurn.Text = "Фамилия";
            // 
            // lbPosit
            // 
            this.lbPosit.AutoSize = true;
            this.lbPosit.Location = new System.Drawing.Point(13, 73);
            this.lbPosit.Name = "lbPosit";
            this.lbPosit.Size = new System.Drawing.Size(81, 17);
            this.lbPosit.TabIndex = 3;
            this.lbPosit.Text = "Должность";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(13, 103);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(101, 17);
            this.lbBirth.TabIndex = 4;
            this.lbBirth.Text = "Год рождения";
            // 
            // lbSal
            // 
            this.lbSal.AutoSize = true;
            this.lbSal.Location = new System.Drawing.Point(13, 133);
            this.lbSal.Name = "lbSal";
            this.lbSal.Size = new System.Drawing.Size(72, 17);
            this.lbSal.TabIndex = 5;
            this.lbSal.Text = "Зарплата";
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(375, 52);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(100, 32);
            this.btcancel.TabIndex = 6;
            this.btcancel.Text = "Отмена";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(163, 13);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(176, 22);
            this.textName.TabIndex = 7;
            // 
            // textSurn
            // 
            this.textSurn.Location = new System.Drawing.Point(163, 43);
            this.textSurn.Name = "textSurn";
            this.textSurn.Size = new System.Drawing.Size(176, 22);
            this.textSurn.TabIndex = 8;
            // 
            // textPos
            // 
            this.textPos.Location = new System.Drawing.Point(163, 73);
            this.textPos.Name = "textPos";
            this.textPos.Size = new System.Drawing.Size(176, 22);
            this.textPos.TabIndex = 9;
            // 
            // textBirth
            // 
            this.textBirth.Location = new System.Drawing.Point(163, 103);
            this.textBirth.Name = "textBirth";
            this.textBirth.Size = new System.Drawing.Size(176, 22);
            this.textBirth.TabIndex = 10;
            // 
            // textSalar
            // 
            this.textSalar.Location = new System.Drawing.Point(163, 133);
            this.textSalar.Name = "textSalar";
            this.textSalar.Size = new System.Drawing.Size(176, 22);
            this.textSalar.TabIndex = 11;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 170);
            this.Controls.Add(this.textSalar);
            this.Controls.Add(this.textBirth);
            this.Controls.Add(this.textPos);
            this.Controls.Add(this.textSurn);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.lbSal);
            this.Controls.Add(this.lbBirth);
            this.Controls.Add(this.lbPosit);
            this.Controls.Add(this.lbSurn);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btok);
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurn;
        private System.Windows.Forms.Label lbPosit;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbSal;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurn;
        private System.Windows.Forms.TextBox textPos;
        private System.Windows.Forms.TextBox textBirth;
        private System.Windows.Forms.TextBox textSalar;
    }
}