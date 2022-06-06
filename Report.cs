using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apex_
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        string fname, lname, name;
        private void Report_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            for (int n = DataBase.ds.Tables["Пользователи"].Rows.Count - 1; n > -1; n--)
            {
                fname = DataBase.ds.Tables["Пользователи"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Пользователи"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                comboBoxStaff.Items.Add(name);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStaff.Text == "") { MessageBox.Show("Выберите сотрудника", ""); return; }
            listBox.Items.Add(comboBoxStaff.Text);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\", "
                        + "schedule.date_work as \"Дата смены\", schedule.opening_hours as \"Часы работы\" FROM schedule INNER JOIN staff ON staff.id_staff = "
                        + "schedule.staff_id_staff WHERE (date_work, date_work) OVERLAPS ('" + dateTimePicker1.Value + "'::DATE, "
                        + "'" + dateTimePicker2.Value.AddDays(1) + "'::DATE) ORDER BY staff.id_staff;";
                DataBase.dsTable_Fill("Расписание по диапазону", sql);

                dataGridView.DataSource = DataBase.ds.Tables["Расписание по диапазону"];
                buttonExcel.Enabled = true;
            }
            else
            {
                if (listBox.Items.Count == 0) { MessageBox.Show("Сотрудники не выбраны", ""); return; }

                string namestring = "", listBoxString;
                string[] words;
                listBoxString = listBox.Items[0].ToString();
                words = listBoxString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                fname = words[0]; lname = words[1];
                namestring = "first_name = '" + fname + "' AND last_name = '" + lname + "' ";

                if (listBox.Items.Count > 1)
                {
                    int num = listBox.Items.Count;
                    for (int i = 1; i <= num - 1; i++)
                    {
                        listBoxString = listBox.Items[i].ToString();
                        words = listBoxString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        fname = words[0]; lname = words[1];

                        namestring += " OR first_name = '" + fname + "' AND last_name = '" + lname + "' ";
                    }
                }

                string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\", "
                        + "schedule.date_work as \"Дата смены\", schedule.opening_hours as \"Часы работы\" FROM schedule INNER JOIN staff ON staff.id_staff = "
                        + "schedule.staff_id_staff WHERE (date_work, date_work) OVERLAPS ('" + dateTimePicker1.Value + "'::DATE, "
                        + "'" + dateTimePicker2.Value.AddDays(1) + "'::DATE) AND " + namestring + "ORDER BY staff.id_staff;";
                DataBase.dsTable_Fill("Расписание по диапазону", sql);
                dataGridView.DataSource = DataBase.ds.Tables["Расписание по диапазону"];

                buttonExcel.Enabled = true;
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j+1] = dataGridView.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = dataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0) { MessageBox.Show("В списке нет объектов", ""); return; }
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }
    }
}
