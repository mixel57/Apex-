using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex_
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        string fname, lname, name;
        private void Schedule_Load(object sender, EventArgs e)
        {
            for (int n = DataBase.ds.Tables["Пользователи"].Rows.Count - 1; n > -1; n--)
            {
                fname = DataBase.ds.Tables["Пользователи"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Пользователи"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                comboBoxStaff.Items.Add(name);
            }
        }
        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        int num;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStaff.Text == "") { MessageBox.Show("Пользователь не выбран", ""); return; }
            if (maskedTextBoxHours.Text == "  :   -   :") { MessageBox.Show("Рабочие часы не введены", ""); return; }
            string comboBoxString = comboBoxStaff.Text;
            string[] words = comboBoxString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            fname = words[0]; lname = words[1];

            string sql = "SELECT MAX(id_sch) as \"Номер\" FROM schedule";
            DataBase.dsTable_Fill("Наибольшее значение id_sch", sql);
            if (Convert.IsDBNull(DataBase.ds.Tables["Наибольшее значение id_sch"].Rows[0]["Номер"])) 
            {
                num = 1;
            }
            else
            {
                num = 1 + Convert.ToInt32(DataBase.ds.Tables["Наибольшее значение id_sch"].Rows[0]["Номер"]);
            }
            sql = "SELECT id_staff as \"Код сотрудника\" from staff WHERE first_name = '" + fname + "' AND last_name = '" + lname + "';";
            DataBase.dsTable_Fill("Пользователи", sql);
            string staffid = DataBase.ds.Tables["Пользователи"].Rows[0]["Код сотрудника"].ToString();

            sql = "SELECT * FROM schedule LIMIT 1";
            DataBase.dsTable_Fill("Расписание полная", sql);

            sql = "INSERT INTO schedule VALUES(" + num + ", '" + dateTimePicker.Value + "', '" + maskedTextBoxHours.Text + "', " + staffid + ");";
            if (!DataBase.SqlRequest(sql)) return;
            DataBase.ds.Tables["Расписание полная"].Rows.Add(new object[] {
                num, dateTimePicker.Value, maskedTextBoxHours.Text, staffid
                });
            MessageBox.Show("Расписание успешно добавлено", "");
        }
    }
}
