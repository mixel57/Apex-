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
    public partial class Accounts : Form
    {   string iduser, login, password, admin, btn;
        public Accounts(string iduser, string login, string password, string admin, string btn)
        {
            InitializeComponent();
            this.iduser = iduser; this.login = login;
            this.password = password; this.admin = admin;
            this.btn = btn;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            if (btn == "open")
            {
                textBoxLogin.ReadOnly = true;
                textBoxPassword.ReadOnly = true;
                textBoxAdmin.ReadOnly = true;
                button.Text = "Закрыть";
                comboBoxAdmin.Visible = false;
                textBoxLogin.Text = login;
                textBoxPassword.Text = password;
                if (admin == "True")
                {
                    textBoxAdmin.Text = "Да";
                } 
                else
                {
                    textBoxAdmin.Text = "Нет";
                }
            }

            if (btn == "update")
            {
                button.Text = "Сохранить";
                textBoxAdmin.Visible = false;
                textBoxLogin.Text = login;
                textBoxPassword.Text = password;
                if(admin == "True")
                {
                    comboBoxAdmin.Text = "Да";
                }
                else
                {
                    comboBoxAdmin.Text = "Нет";
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (btn == "open")
            {
                this.DialogResult = DialogResult.OK;
            }

            if (btn == "update")
            {
                bool adminb;
                if (comboBoxAdmin.Text == "Да") adminb = true; else adminb = false;
                
                string sql = "UPDATE users SET id_user = '" + iduser + "', login = '" + textBoxLogin.Text + "', password = '" + textBoxPassword.Text + "', admin = " + adminb + " WHERE id_user = " + Convert.ToInt32(iduser) + ";";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Аккаунты полная"].Rows.Add(new object[] {
                iduser, textBoxLogin.Text, textBoxPassword.Text, adminb
                });

                MessageBox.Show("Данные успешно обновлены", "");
            }
        }

        private void Accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
