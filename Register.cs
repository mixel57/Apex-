using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Boolean adminCheck;
        int num;
        string fname, lname, name, staffid;
        private void Register_Load(object sender, EventArgs e)
        {
            string sql = "SELECT staff.id_staff, staff.first_name as \"Имя\", staff.last_name as \"Фамилия\", migrations.date_dismissal FROM staff "
                + "INNER JOIN migrations ON migrations.staff_id_staff = staff.id_staff WHERE migrations.date_dismissal = '9999-12-31';";

            DataBase.dsTable_Fill("Пользователи", sql);

            for (int n = DataBase.ds.Tables["Пользователи"].Rows.Count - 1; n > -1; n--)
            {
                fname = DataBase.ds.Tables["Пользователи"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Пользователи"].Rows[n]["Фамилия"].ToString();
                name = fname + " " + lname;
                comboBoxUsers.Items.Add(name);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.Text == "") { MessageBox.Show("Пользователь не выбран", ""); return; }
            string comboBoxString = comboBoxUsers.Text;
            string[] words = comboBoxString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            fname = words[0]; lname = words[1];
            if (checkBoxAdmin.Checked == true) adminCheck = true; else adminCheck = false;

            string sql = "SELECT users.id_user as \"Код пользователя\", users.staff_id_staff as \"Код сотрудника\", users.login as \"Логин\", users.password as \"Пароль\", staff.first_name as \"Имя\", staff.last_name as \"Фамилия\" FROM users "
                + "INNER JOIN staff ON users.staff_id_staff = staff.id_staff WHERE staff.first_name = '" + fname + "' AND staff.last_name = '" + lname + "';";

            DataBase.dsTable_Fill("Пользователи", sql);

            if (DataBase.ds.Tables["Пользователи"].Rows.Count == 1)
            {
                MessageBox.Show("У пользователя " + fname + " " + lname + " уже есть аккаунт", "");
            }
            else
            {
                if (textBoxLogin.Text == "") { MessageBox.Show("Введите логин", ""); return; }
                if (textBoxPassword.Text == "") { MessageBox.Show("Введите пароль", ""); return; }
                if (textBoxPassword2.Text == "") { MessageBox.Show("Повторите пароль", ""); return; }
                if (textBoxPassword.Text != textBoxPassword2.Text) { MessageBox.Show("Пароли не совпадают", ""); return; }
                sql = "SELECT MAX(id_user) as \"Номер\" FROM users";
                DataBase.dsTable_Fill("Наибольшее значение id_users", sql);
                num = 1 + Convert.ToInt32(DataBase.ds.Tables["Наибольшее значение id_users"].Rows[0]["Номер"]);

                sql = "SELECT id_staff as \"Код сотрудника\" from staff WHERE first_name = '" + fname + "' AND last_name = '" + lname + "';";
                DataBase.dsTable_Fill("Пользователи", sql);
                staffid = DataBase.ds.Tables["Пользователи"].Rows[0]["Код сотрудника"].ToString();

                sql = "SELECT login FROM users WHERE login = '" + textBoxLogin.Text + "';";
                DataBase.dsTable_Fill("Пользователи Проверка", sql);
                if (DataBase.ds.Tables["Пользователи Проверка"].Rows.Count == 1) { MessageBox.Show("Пользователь с таким логином уже существует", ""); return; }

                sql = "SELECT * FROM users LIMIT 1";
                DataBase.dsTable_Fill("Пользователи Регистрация", sql);

                sql = "INSERT INTO users VALUES(" + num + ", '" + textBoxLogin.Text + "', '" + textBoxPassword.Text + "', " + staffid + ", '" + adminCheck + "');";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Пользователи Регистрация"].Rows.Add(new object[] {
                num, textBoxLogin.Text, textBoxPassword.Text, staffid, adminCheck
                });
                MessageBox.Show("Пользователь успешно зарегистрирован", "");
            }

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
