using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class MainForm : Form
    {
        string helloName, staffid;
        bool adminCheck;
        int num;
        public MainForm(string helloName, string staffid, bool adminCheck)
        {
            InitializeComponent();
            this.helloName = helloName;
            this.adminCheck = adminCheck;
            this.staffid = staffid;
        }

        string id, name, date, post, lname, fname, text;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (adminCheck == false)
            {
                statusStrip.Visible = false;
                buttonAddUser.Visible = false;
                labelCheck.Visible = false;
                labelStaff.Visible = false;
                labelAccounts.Visible = false; 
                buttonRefrersh.Visible = false;
            }

            labelHello.Text = helloName;

            string sql = "SELECT notes.id_notes as \"Номер заметки\", notes.date_notes as \"Дата и время\", notes.text_notes as \"Текст\", "
                + "staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.post as \"Должность\" FROM notes INNER JOIN users ON notes.users_id_user = users.id_user "
                + "INNER JOIN staff ON staff.id_staff = users.staff_id_staff;";

            DataBase.dsTable_Fill("Заметки", sql);

            for (int n = DataBase.ds.Tables["Заметки"].Rows.Count - 1; n > -1; n--)
            {
                id = DataBase.ds.Tables["Заметки"].Rows[n]["Номер заметки"].ToString();
                fname = DataBase.ds.Tables["Заметки"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Заметки"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                text = DataBase.ds.Tables["Заметки"].Rows[n]["Текст"].ToString();
                date = DataBase.ds.Tables["Заметки"].Rows[n]["Дата и время"].ToString();
                post = DataBase.ds.Tables["Заметки"].Rows[n]["Должность"].ToString();
                UserControlNotes userControlNotes = new UserControlNotes(id, name, date, post, text, adminCheck);
                flowLayoutPanelMain.Controls.Add(userControlNotes);
            }
        }
        string btn;
        private void labelSchedule_Click(object sender, EventArgs e)
        {
            btn = "расписание";
            this.Hide();
            DataGridForm dataGridForm = new DataGridForm(adminCheck, btn);
            dataGridForm.ShowDialog();
            this.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT notes.id_notes as \"Номер заметки\", notes.date_notes as \"Дата и время\", notes.text_notes as \"Текст\", "
                + "staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.post as \"Должность\" FROM notes INNER JOIN users ON notes.users_id_user = users.id_user "
                + "INNER JOIN staff ON staff.id_staff = users.staff_id_staff;";

            DataBase.dsTable_Fill("Заметки", sql);

            flowLayoutPanelMain.Controls.Clear();
            for (int n = DataBase.ds.Tables["Заметки"].Rows.Count - 1; n > -1; n--)
            {
                id = DataBase.ds.Tables["Заметки"].Rows[n]["Номер заметки"].ToString();
                fname = DataBase.ds.Tables["Заметки"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Заметки"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                text = DataBase.ds.Tables["Заметки"].Rows[n]["Текст"].ToString();
                date = DataBase.ds.Tables["Заметки"].Rows[n]["Дата и время"].ToString();
                post = DataBase.ds.Tables["Заметки"].Rows[n]["Должность"].ToString();
                UserControlNotes userControlNotes = new UserControlNotes(id, name, date, post, text, adminCheck);
                flowLayoutPanelMain.Controls.Add(userControlNotes);
            }
        }

        private void labelBadge_Click(object sender, EventArgs e)
        {
            Program.openExcel();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();
        }

        string lbl;
        private void labelStaff_Click(object sender, EventArgs e)
        {
            lbl = "сотрудники";
            this.Hide();
            Staff staff = new Staff(lbl);
            staff.ShowDialog();
            this.Show();
        }

        private void labelAccounts_Click(object sender, EventArgs e)
        {
            lbl = "аккаунты";
            this.Hide();
            Staff staff = new Staff(lbl);
            staff.ShowDialog();
            this.Show();
        }

        private void labelCheck_Click(object sender, EventArgs e)
        {
            btn = "отметки";
            this.Hide();
            DataGridForm dataGridForm = new DataGridForm(adminCheck, btn);
            dataGridForm.ShowDialog();
            this.Show();
        }
        private void buttonAddNotes_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(id_notes) as \"Номер\" FROM notes";
            DataBase.dsTable_Fill("Наибольшее значение id_notes", sql);
            if (Convert.IsDBNull(DataBase.ds.Tables["Наибольшее значение id_notes"].Rows[0]["Номер"]))
            {
                num = 1;
            }
            else
            {
                num = 1 + Convert.ToInt32(DataBase.ds.Tables["Наибольшее значение id_notes"].Rows[0]["Номер"]);
            }

            sql = "INSERT INTO notes VALUES(" + num + ", '" + DateTime.Now + "', '" + textBoxNotes.Text + "', " + staffid + ");";
            if (!DataBase.SqlRequest(sql)) return;
            DataBase.ds.Tables["Заметки"].Rows.Add(new object[] {
                num, DateTime.Now, textBoxNotes.Text, staffid
            });

            flowLayoutPanelMain.Controls.Clear();
            sql = "SELECT notes.id_notes as \"Номер заметки\", notes.date_notes as \"Дата и время\", notes.text_notes as \"Текст\", "
                + "staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", staff.post as \"Должность\" FROM notes INNER JOIN users ON notes.users_id_user = users.id_user "
                + "INNER JOIN staff ON staff.id_staff = users.staff_id_staff;";

            DataBase.dsTable_Fill("Заметки", sql);

            for (int n = DataBase.ds.Tables["Заметки"].Rows.Count - 1; n > -1; n--)
            {
                id = DataBase.ds.Tables["Заметки"].Rows[n]["Номер заметки"].ToString();
                fname = DataBase.ds.Tables["Заметки"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Заметки"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                text = DataBase.ds.Tables["Заметки"].Rows[n]["Текст"].ToString();
                date = DataBase.ds.Tables["Заметки"].Rows[n]["Дата и время"].ToString();
                post = DataBase.ds.Tables["Заметки"].Rows[n]["Должность"].ToString();
                UserControlNotes userControlNotes = new UserControlNotes(id, name, date, post, text, adminCheck);
                flowLayoutPanelMain.Controls.Add(userControlNotes);
            }
            textBoxNotes.Text = "";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(id_chec) as \"Номер\" FROM chec";
            DataBase.dsTable_Fill("Наибольшее значение id_chec", sql);
            if (Convert.IsDBNull(DataBase.ds.Tables["Наибольшее значение id_chec"].Rows[0]["Номер"]))
            {
                num = 1;
            }
            else
            {
                num = 1 + Convert.ToInt32(DataBase.ds.Tables["Наибольшее значение id_chec"].Rows[0]["Номер"]);
            }

            sql = "SELECT * FROM chec WHERE chec::date = '" + DateTime.Today.ToShortDateString() + "' AND staff_id_staff = " + staffid + ";";
            DataBase.dsTable_Fill("Выборка отметок", sql);

            if (DataBase.ds.Tables["Выборка отметок"].Rows.Count == 0)
            {
                sql = "INSERT INTO chec VALUES(" + num + ", '" + DateTime.Now + "', " + staffid + ");";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Выборка отметок"].Rows.Add(new object[] {
                num, DateTime.Now, staffid
                });
                MessageBox.Show("Отметка успешно засчитана", "");
            }
            else
            {
                MessageBox.Show("Вы сегодня уже отмечались", "");
            }
        }
    }
}
