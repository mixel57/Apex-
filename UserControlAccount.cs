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
    public partial class UserControlAccount : UserControl
    {
        string idstaff, fname, lname, patronymic, iduser, login, password, admin, btn;
        public UserControlAccount(string idstaff, string fname, string lname, string patronymic, string iduser, string login, string password, string admin)
        {
            InitializeComponent();
            this.idstaff = idstaff; this.fname = fname;
            this.lname = lname; this.patronymic = patronymic;
            this.iduser = iduser; this.login = login;
            this.password = password; this.admin = admin;
        }

        private void UserControlAccount_Load(object sender, EventArgs e)
        {
            labelLogin.Text = login;
            labelName.Text = fname;
            labelSecondName.Text = lname;
            labelPatr.Text = patronymic;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            btn = "update";
            Accounts accounts = new Accounts(iduser, login, password, admin, btn);
            accounts.ShowDialog();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            btn = "open";
            Accounts accounts = new Accounts(iduser, login, password, admin, btn);
            accounts.ShowDialog();
        }
        private void labelDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Вместе с этим аккаунтом удалятся все его заметки. Вы увернеы, что хотите удалить этот аккаунт?", "Внимание!", MessageBoxButtons.YesNo);
            switch (del)
            {
                case DialogResult.Yes:
                    string sql = "DELETE FROM notes WHERE users_id_user = " + iduser + ";";
                    if (!DataBase.SqlRequest(sql)) return;

                    sql = "DELETE FROM users WHERE id_user = " + iduser + ";";
                    if (!DataBase.SqlRequest(sql)) return;
                    break;
                case DialogResult.No:
                    return;
            }
        }
    }
}
