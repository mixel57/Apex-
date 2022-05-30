using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class StaffInfo : Form
    {
        string idstaff, idmig, fname, lname, patronymic, post, address, number, birthday, hiring, dismissal, btn;
        public StaffInfo(string idstaff, string fname, string lname, string patronymic, string post, string address, string number, string birthday, string hiring, string dismissal, string idmig, string btn)
        {
            InitializeComponent();
            this.fname = fname; this.idstaff = idstaff;
            this.lname = lname; this.address = address;
            this.patronymic = patronymic; this.number = number;
            this.post = post; this.hiring = hiring;
            this.dismissal = dismissal; this.btn = btn;
            this.idmig = idmig; this.birthday = birthday;
        }
        private void StaffInfo_Load(object sender, EventArgs e)
        {

            if (btn == "open")
            {
                comboBoxPost.Visible = false;
                textBoxFname.ReadOnly = true; textBoxFname.Text = fname;
                textBoxLname.ReadOnly = true; textBoxLname.Text = lname;
                textBoxPatronymic.ReadOnly = true; textBoxPatronymic.Text = patronymic;
                textBoxPost.ReadOnly = true; textBoxPost.Text = post;
                textBoxAddress.ReadOnly = true; textBoxAddress.Text = address;
                maskedTextBoxNumber.ReadOnly = true; maskedTextBoxNumber.Text = number;
                maskedTextBoxBirthday.ReadOnly = true; maskedTextBoxBirthday.Text = birthday;
                maskedTextBoxHiring.ReadOnly = true; maskedTextBoxHiring.Text = hiring;
                maskedTextBoxDismissal.ReadOnly = true;
                if (dismissal == "")
                {
                    maskedTextBoxDismissal.Text = "";
                }
                else
                {
                    maskedTextBoxDismissal.Text = dismissal;
                }
            }

            if (btn == "update")
            {
                textBoxPost.Visible = false;
                button.Text = "Сохранить";
                textBoxFname.Text = fname;
                textBoxLname.Text = lname;
                textBoxPatronymic.Text = patronymic;
                comboBoxPost.Text = post;
                textBoxAddress.Text = address;
                maskedTextBoxNumber.Text = number;
                maskedTextBoxBirthday.Text = birthday;
                maskedTextBoxHiring.Text = hiring;
                if (dismissal == "")
                {
                    maskedTextBoxDismissal.Text = "";
                }
                else
                {
                    maskedTextBoxDismissal.Text = dismissal;
                }
            }

            if (btn == "add")
            {
                textBoxPost.Visible = false;
                maskedTextBoxDismissal.ReadOnly = true;
                button.Text = "Добавить";
                textBoxFname.Text = "";
                textBoxLname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxPost.Text = "";
                textBoxAddress.Text = "";
                maskedTextBoxNumber.Text = "";
                maskedTextBoxBirthday.Text = "";
                maskedTextBoxHiring.Text = "";
                maskedTextBoxDismissal.Text = "31-12-9999";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(id_staff) as \"Номер пользователя\", MAX(id_mig) as \"Номер миграции\" FROM staff, migrations;";
            DataBase.dsTable_Fill("Наибольшее значение id", sql);
            int numstaff = 1 + Convert.ToInt32(DataBase.ds.Tables["Наибольшее значение id"].Rows[0]["Номер пользователя"]);
            int nummig = 1 + Convert.ToInt32(DataBase.ds.Tables["Наибольшее значение id"].Rows[0]["Номер миграции"]);

            if (btn == "open") this.DialogResult = DialogResult.OK;
            if (btn == "update")
            {
                sql = "UPDATE staff SET id_staff = " + Convert.ToInt32(idstaff) + ", first_name = '" + textBoxFname.Text + "', last_name = '" + textBoxLname.Text + "', patronymic = '" + textBoxPatronymic.Text + "', post = '"
                    + comboBoxPost.Text + "', home_address = '" + textBoxAddress.Text + "', phone_number = '" + maskedTextBoxNumber.Text + "', birthday = '" + maskedTextBoxBirthday.Text + "' WHERE id_staff = " + Convert.ToInt32(idstaff) + ";";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Сотрудники полная"].Rows.Add(new object[] {
                idstaff, textBoxFname.Text, textBoxLname.Text, textBoxPatronymic.Text, textBoxAddress.Text, maskedTextBoxNumber.Text, maskedTextBoxBirthday.Text
                });

                sql = "UPDATE migrations SET id_mig = " + Convert.ToInt32(idmig) + ", date_hiring = '" + maskedTextBoxHiring.Text + "', date_dismissal = '" + maskedTextBoxDismissal.Text + "', staff_id_staff = " + Convert.ToInt32(idstaff) + " "
                    + "WHERE staff_id_staff = " + Convert.ToInt32(idstaff) + ";";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Миграции полная"].Rows.Add(new object[] {
                idmig, maskedTextBoxHiring.Text, maskedTextBoxDismissal.Text, idstaff
                });

                MessageBox.Show("Данные успешно обновлены", "");
            }

            if (btn == "add")
            {
                sql = "SELECT * FROM staff WHERE first_name = '" + textBoxFname.Text + "' AND last_name = '" + textBoxLname.Text + "' AND patronymic = '" + textBoxPatronymic.Text + "';";
                DataBase.dsTable_Fill("Сотрудник проверка", sql);
                if (DataBase.ds.Tables["Сотрудник проверка"].Rows.Count == 1) { MessageBox.Show("Сотрудник с таким ФИО уже зарегистрирован", ""); return; }

                sql = "INSERT INTO staff VALUES(" + numstaff + ", '" + textBoxFname.Text + "', '" + textBoxLname.Text + "', '" + textBoxPatronymic.Text + "', '" + comboBoxPost.Text + "', '" + textBoxAddress.Text + "', '" + maskedTextBoxNumber.Text + "', '" + maskedTextBoxBirthday.Text + "');";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Сотрудники полная"].Rows.Add(new object[] {
                numstaff, textBoxFname.Text, textBoxLname.Text, textBoxPatronymic.Text, textBoxAddress.Text, maskedTextBoxNumber.Text, maskedTextBoxBirthday.Text
                });

                sql = "INSERT INTO migrations VALUES(" + nummig + ", '" + maskedTextBoxHiring.Text + "', '" + maskedTextBoxDismissal.Text + "', " + nummig + ");";
                if (!DataBase.SqlRequest(sql)) return;
                DataBase.ds.Tables["Миграции полная"].Rows.Add(new object[] {
                nummig, maskedTextBoxHiring.Text, maskedTextBoxDismissal.Text
                });

                MessageBox.Show("Данные успешно добавлены", "");
            }
        }
    }
}
