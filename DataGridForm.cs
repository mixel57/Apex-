using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class DataGridForm : Form
    {
        bool adminCheck;
        string btn;
        public DataGridForm(bool adminCheck, string btn)
        {
            InitializeComponent();
            this.adminCheck = adminCheck;
            this.btn = btn;
        }
        string fname, lname, name;
        private void DataGridForm_Load(object sender, EventArgs e)
        {
            if (adminCheck == false) { buttonReport.Visible = false; }
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string sql = "SELECT staff.id_staff, staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", migrations.date_dismissal FROM staff "
                + "INNER JOIN migrations ON migrations.staff_id_staff = staff.id_staff WHERE migrations.date_dismissal = '9999-12-31';";

            DataBase.dsTable_Fill("Пользователи", sql);

            for (int n = DataBase.ds.Tables["Пользователи"].Rows.Count - 1; n > -1; n--)
            {
                fname = DataBase.ds.Tables["Пользователи"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Пользователи"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                comboBoxStaff.Items.Add(name);
            }

            dateTimePicker.Value = DateTime.Now;

            radioButtonAll.Checked = true;
            if (btn == "расписание")
            {
                labelMain.Text = "Рабочий график";
                radioButtonAll.Text = "Всё расписание";
                radioButtonDate.Text = "Расписание на выбранную дату";
                radioButtonStaff.Text = "Расписание выбранного сотрудника";
                buttonLeft.Text = "Удалить";
                buttonRight.Text = "Добавить";
                if (adminCheck == false) { buttonRight.Enabled = false; buttonLeft.Enabled = false; }
            }

            if (btn == "отметки")
            {
                buttonReport.Visible = false;
                labelMain.Text = "Отметки";
                radioButtonAll.Text = "Все отметки";
                radioButtonDate.Text = "Отметки на выбранную дату";
                radioButtonStaff.Text = "Отметки выбранного сотрудника";
                buttonLeft.Text = "Удалить";
                buttonRight.Text = "Закрыть";
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked == true)
            {
                if (btn == "отметки")
                {
                    string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\","
                        + "chec.chec as \"Дата отметки\" FROM chec INNER JOIN staff ON staff.id_staff = chec.staff_id_staff ORDER BY chec DESC;";
                    DataBase.dsTable_Fill("Отметки загрузка", sql);

                    dataGridView.DataSource = DataBase.ds.Tables["Отметки загрузка"];
                }

                if (btn == "расписание")
                {
                    string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\","
                        + "schedule.date_work as \"Дата смены\", schedule.opening_hours as \"Часы работы\" FROM schedule INNER JOIN staff ON staff.id_staff = "
                        + "schedule.staff_id_staff ORDER BY date_work DESC;";
                    DataBase.dsTable_Fill("Расписание загрузка", sql);

                    dataGridView.DataSource = DataBase.ds.Tables["Расписание загрузка"];
                }
            }
        }

        private void radioButtonStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStaff.Checked == true)
            {
                if (comboBoxStaff.Text == "") { MessageBox.Show("Пожалуйста, выберите сотрудника", ""); radioButtonAll.Checked = true; return; }
                if (btn == "отметки")
                {
                    string comboBoxString = comboBoxStaff.Text;
                    string[] words = comboBoxString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fname = words[0]; lname = words[1];

                    string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\","
                        + "chec.chec as \"Дата отметки\" FROM chec INNER JOIN staff ON staff.id_staff = chec.staff_id_staff WHERE first_name = '" + fname + "' AND last_name = '" + lname + "';";
                    DataBase.dsTable_Fill("Отметки по сотруднику", sql);

                    dataGridView.DataSource = DataBase.ds.Tables["Отметки по сотруднику"];
                    radioButtonStaff.Checked = false;
                }

                if (btn == "расписание")
                {
                    string comboBoxString = comboBoxStaff.Text;
                    string[] words = comboBoxString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fname = words[0]; lname = words[1];

                    string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\","
                        + "schedule.date_work as \"Дата смены\", schedule.opening_hours as \"Часы работы\" FROM schedule INNER JOIN staff ON staff.id_staff = schedule.staff_id_staff WHERE first_name = '" + fname + "' AND last_name = '" + lname + "';";
                    DataBase.dsTable_Fill("Расписание по сотруднику", sql);

                    dataGridView.DataSource = DataBase.ds.Tables["Расписание по сотруднику"];
                    radioButtonStaff.Checked = false;

                }
            }
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked == true)
            {
                if (btn == "отметки")
                {
                    string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\","
                        + "chec.chec as \"Дата отметки\" FROM chec INNER JOIN staff ON staff.id_staff = chec.staff_id_staff WHERE chec::date = '" + dateTimePicker.Value + "';";
                    DataBase.dsTable_Fill("Отметки по дате", sql);

                    dataGridView.DataSource = DataBase.ds.Tables["Отметки по дате"];
                    radioButtonDate.Checked = false;
                }

                if (btn == "расписание")
                {
                    string sql = "SELECT staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.patronymic as \"Отчество\", staff.post as \"Должность\","
                        + "schedule.date_work as \"Дата смены\", schedule.opening_hours as \"Часы работы\" FROM schedule INNER JOIN staff ON staff.id_staff = schedule.staff_id_staff WHERE schedule.date_work = '" + dateTimePicker.Value + "';";
                    DataBase.dsTable_Fill("Расписание по дате", sql);

                    dataGridView.DataSource = DataBase.ds.Tables["Расписание по дате"];
                    radioButtonDate.Checked = false;
                }
            }
        }

        private void DataGridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DataGridForm_Activated(object sender, EventArgs e)
        {
            radioButtonAll.Checked = false; radioButtonAll.Checked = true;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.ShowDialog();
            this.Show();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) { MessageBox.Show("Строка не выбрана", ""); return; }
            if (btn == "отметки")
            {
                DialogResult del = MessageBox.Show("Вы увернеы, что хотите удалить эту отметку?", "", MessageBoxButtons.YesNo);
                switch (del)
                {
                    case DialogResult.Yes:
                        string sql = "DELETE FROM chec WHERE chec = '" + dataGridView.CurrentRow.Cells[4].Value.ToString() + "';";
                        if (!DataBase.SqlRequest(sql)) return;
                        MessageBox.Show("Удаление успешно проведено", "");
                        radioButtonAll.Checked = true;
                        break;
                    case DialogResult.No:
                        return;
                }
            }

            if (btn == "расписание")
            {
                if (dataGridView.CurrentRow == null) { MessageBox.Show("Строка не выбрана", ""); return; }
                DialogResult del = MessageBox.Show("Вы увернеы, что хотите удалить это расписание?", "", MessageBoxButtons.YesNo);
                switch (del)
                {
                    case DialogResult.Yes:
                        string sql = "SELECT id_staff as \"Код сотрудника\" FROM staff WHERE first_name = '" + dataGridView.CurrentRow.Cells[0].Value.ToString() + "' AND"
                            + " last_name = '" + dataGridView.CurrentRow.Cells[1].Value.ToString() + "' AND patronymic = '" + dataGridView.CurrentRow.Cells[2].Value.ToString() + "';";
                        DataBase.dsTable_Fill("Код по имени", sql);
                        string staffid = DataBase.ds.Tables["Код по имени"].Rows[0]["Код сотрудника"].ToString();

                        sql = "DELETE FROM schedule WHERE date_work = '" + dataGridView.CurrentRow.Cells[4].Value.ToString() + "' AND opening_hours = '" + dataGridView.CurrentRow.Cells[5].Value.ToString() + "' "
                            + "AND staff_id_staff = " + staffid + ";";
                        if (!DataBase.SqlRequest(sql)) return;
                        MessageBox.Show("Удаление успешно проведено", "");
                        radioButtonAll.Checked = true;
                        break;
                    case DialogResult.No:
                        return;
                }
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (btn == "отметки")
            {
                this.DialogResult = DialogResult.OK;
            }

            if (btn == "расписание")
            {
                Schedule schedule = new Schedule();
                schedule.ShowDialog();
            }
        }
    }
}
