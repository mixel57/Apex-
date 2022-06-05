using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class Staff : Form
    {
        string lbl;
        public Staff(string lbl)
        {
            InitializeComponent();
            this.lbl = lbl;
        }

        string idstaff, idmig, fname, lname, patronymic, post, address, number, hiring, dismissal, btn, birthday,
            iduser, login, password, admin;
        private void Staff_Load(object sender, EventArgs e)
        {
            if (lbl == "сотрудники")
            {
                statusStrip.Visible = false;
                label.Text = "Список сотрудников";
                buttonAdd.Text = "Добавить сотрудника";
                buttonRefrersh.Visible = false;
                buttonAdd.Text = "Добавить";
            }
            if (lbl == "аккаунты")
            {
                label.Text = "Список аккаунтов";
                buttonAdd.Text = "Закрыть";
            }
        }

        private void Staff_Activated(object sender, EventArgs e)
        {
            if (lbl == "сотрудники")
            {
                flowLayoutStaff.Controls.Clear();
                string sql = "SELECT id_staff as \"Номер сотрудника\", first_name as \"Имя\", last_name as \"Фамилия\", patronymic as \"Отчество\","
                    + " post as \"Должность\", home_address as \"Домашний адрес\", phone_number as \"Номер телефона\", birthday as \"Дата рождения\" FROM staff ORDER BY id_staff;";
                DataBase.dsTable_Fill("Сотрудники полная", sql);

                sql = "SELECT id_mig as \"Номер миграции\", date_hiring as \"Дата приёма\", date_dismissal as \"Дата увольнения\", staff_id_staff as \"Номер сотрудника миграции\" FROM migrations ORDER by staff_id_staff;";
                DataBase.dsTable_Fill("Миграции полная", sql);

                for (int n = DataBase.ds.Tables["Сотрудники полная"].Rows.Count - 1; n > -1; n--)
                {
                    idstaff = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Номер сотрудника"].ToString();
                    fname = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Имя"].ToString();
                    lname = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Фамилия"].ToString();
                    patronymic = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Отчество"].ToString();
                    post = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Должность"].ToString();
                    address = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Домашний адрес"].ToString();
                    number = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Номер телефона"].ToString();
                    birthday = DataBase.ds.Tables["Сотрудники полная"].Rows[n]["Дата рождения"].ToString();
                    hiring = DataBase.ds.Tables["Миграции полная"].Rows[n]["Дата приёма"].ToString();
                    dismissal = DataBase.ds.Tables["Миграции полная"].Rows[n]["Дата увольнения"].ToString();
                    idmig = DataBase.ds.Tables["Миграции полная"].Rows[n]["Номер миграции"].ToString();

                    UserControlStaff userControlStaff = new UserControlStaff(idstaff, fname, lname, patronymic, post, address, number, birthday, hiring, dismissal, idmig);
                    flowLayoutStaff.Controls.Add(userControlStaff);
                }
            }
            if (lbl == "аккаунты")
            {
                flowLayoutStaff.Controls.Clear();
                string sql = "SELECT id_staff as \"Номер сотрудника\", first_name as \"Имя\", last_name as \"Фамилия\", patronymic as \"Отчество\""
                    + "FROM staff ORDER BY id_staff;";
                DataBase.dsTable_Fill("Сотрудники частичная", sql);

                sql = "SELECT id_user as \"Номер аккаунта\", login as \"Логин\", password as \"Пароль\", admin as \"Админ\" FROM users ORDER BY staff_id_staff;";
                DataBase.dsTable_Fill("Аккаунты полная", sql);

                for (int n = DataBase.ds.Tables["Аккаунты полная"].Rows.Count - 1; n > -1; n--)
                {
                    fname = DataBase.ds.Tables["Сотрудники частичная"].Rows[n]["Имя"].ToString();
                    lname = DataBase.ds.Tables["Сотрудники частичная"].Rows[n]["Фамилия"].ToString();
                    patronymic = DataBase.ds.Tables["Сотрудники частичная"].Rows[n]["Отчество"].ToString();
                    iduser = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Номер аккаунта"].ToString();
                    login = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Логин"].ToString();
                    password = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Пароль"].ToString();
                    admin = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Админ"].ToString();

                    UserControlAccount userControlAccount = new UserControlAccount(fname, lname, patronymic, iduser, login, password, admin);
                    flowLayoutStaff.Controls.Add(userControlAccount);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (lbl == "сотрудники")
            {
                btn = "add";
                StaffInfo staffInfo = new StaffInfo(idstaff, fname, lname, patronymic, post, address, number, birthday, hiring, dismissal, idmig, btn);
                staffInfo.ShowDialog();
            }
            if (lbl == "аккаунты")
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonRefrersh_Click(object sender, EventArgs e)
        {
            flowLayoutStaff.Controls.Clear();
            string sql = "SELECT id_staff as \"Номер сотрудника\", first_name as \"Имя\", last_name as \"Фамилия\", patronymic as \"Отчество\""
                + "FROM staff ORDER BY id_staff;";
            DataBase.dsTable_Fill("Сотрудники частичная", sql);

            sql = "SELECT id_user as \"Номер аккаунта\", login as \"Логин\", password as \"Пароль\", admin as \"Админ\" FROM users ORDER BY staff_id_staff;";
            DataBase.dsTable_Fill("Аккаунты полная", sql);

            for (int n = DataBase.ds.Tables["Аккаунты полная"].Rows.Count - 1; n > -1; n--)
            {
                fname = DataBase.ds.Tables["Сотрудники частичная"].Rows[n]["Имя"].ToString();
                lname = DataBase.ds.Tables["Сотрудники частичная"].Rows[n]["Фамилия"].ToString();
                patronymic = DataBase.ds.Tables["Сотрудники частичная"].Rows[n]["Отчество"].ToString();
                iduser = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Номер аккаунта"].ToString();
                login = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Логин"].ToString();
                password = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Пароль"].ToString();
                admin = DataBase.ds.Tables["Аккаунты полная"].Rows[n]["Админ"].ToString();

                UserControlAccount userControlAccount = new UserControlAccount(fname, lname, patronymic, iduser, login, password, admin);
                flowLayoutStaff.Controls.Add(userControlAccount);
            }
        }
    }
}
