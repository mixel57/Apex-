using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class UserControlNotes : UserControl
    {
        public string id, name, date, post, text;
        bool adminCheck;
        public UserControlNotes(string id, string name, string date, string post, string text, bool adminCheck)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.date = date;
            this.post = post;
            this.text = text;
            this.adminCheck = adminCheck;
        }

        private void UserControlNotes_Load(object sender, EventArgs e)
        {
            labelName.Text = name;
            labelPost.Text = post;
            labelDate.Text = date;
            labelNumber.Text = id;
            textBox.Text = text;
            if (adminCheck == false)
            {
                labelDeleteNotes.Visible = false;
            }
        }

        private void labelDeleteNotes_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Вы увернеы, что хотите удалить эту записку?", "", MessageBoxButtons.YesNo);
            switch (del)
            {
                case DialogResult.Yes:
                    string sql = "DELETE FROM notes WHERE id_notes = " + id + ";";
                    if (!DataBase.SqlRequest(sql)) return;
                    break;
                case DialogResult.No:
                    return;
            }
        }
    }
}
