using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string helloName, fname, lname, staffid;
        bool admincheck;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLogin.Text;
            string passUser = textBoxPassword.Text;

            string sql = "SELECT users.login as \"Логин\", users.password as \"Пароль\", users.admin as \"Админ\", users.staff_id_staff as \"Номер сотрудника\", staff.first_name as \"Имя\", staff.last_name as \"Фамилия\" " +
                "FROM users INNER JOIN staff ON users.staff_id_staff = staff.id_staff WHERE users.login = '" + loginUser + "' AND users.password = '" + passUser + "';";

            DataBase.dsTable_Fill("Пользователи", sql);
            if (DataBase.ds.Tables["Пользователи"].Rows.Count == 1)
            {
                fname = DataBase.ds.Tables["Пользователи"].Rows[0]["Имя"].ToString();
                lname = DataBase.ds.Tables["Пользователи"].Rows[0]["Фамилия"].ToString();
                admincheck = Convert.ToBoolean(DataBase.ds.Tables["Пользователи"].Rows[0]["Админ"]);
                staffid = DataBase.ds.Tables["Пользователи"].Rows[0]["Номер сотрудника"].ToString();
                helloName = fname + " " + lname;
                this.Hide();
                MainForm mainForm = new MainForm(helloName, staffid, admincheck);
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Пожалуйтса, проверьте введённые данные", "Ошибка авторизации");
            }

            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ActiveControl = textBoxLogin;

            textBoxLogin.Text = "admin";
            textBoxPassword.Text = "admin";
        }
    }
}
