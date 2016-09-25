using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testapp
{
    public partial class AddWorker : Form
    {
        public bool success = false;
        public Worker worker;
        

        public AddWorker()
        {
            InitializeComponent();
        }
        private string testStr(String text, String str)
        {
            if (text == "")
                MessageBox.Show("Задайте " + str);
            return text;
        }
        private int testBirth(String birthyear)
        {
            int res = 0;
            Int32.TryParse(birthyear,out res);
            if (res <= 1900 || res >= 2010)
            {
                MessageBox.Show("Неправильно задан год рождения");
                res = -1;
            }
            return res;
        }
        private int testSalary(String salary)
        {
            int res = 0;
            Int32.TryParse(salary, out res);
            if (res <= 0)
            {
                MessageBox.Show("Неправильно задан оклад");
                res = -1;
            }
            return res;
        }
        private void btok_Click(object sender, EventArgs e)
        {
            worker = new Worker();
            worker.Name = testStr(textName.Text,"имя");
            worker.Surname = testStr(textSurn.Text, "фамилию");
            worker.Position = testStr(textPos.Text, "должность");
            worker.BirthOfYear = testBirth(textBirth.Text);
            worker.Salary = testSalary(textSalar.Text);
            if (worker.Name == "" || worker.Surname == "" || worker.Position == "" || worker.BirthOfYear == -1 || worker.Salary == -1)
                Close();
            else
                success = true;
            Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
