using System;
using System.Windows.Forms;

namespace Apex_
{
    public partial class UserControlStaff : UserControl
    {
        string idstaff, idmig, fname, lname, patronymic, post, address, number, hiring, dismissal, btn, birthday;
        public UserControlStaff(string idstaff, string fname, string lname, string patronymic, string post, string address, string number, string birthday, string hiring, string dismissal, string idmig)
        {
            InitializeComponent();
            this.fname = fname; this.idstaff = idstaff;
            this.lname = lname; this.address = address;
            this.patronymic = patronymic; this.number = number;
            this.post = post; this.hiring = hiring;
            this.dismissal = dismissal;
            this.idmig = idmig; this.birthday = birthday;
        }

        private void UserControlStaff_Load(object sender, EventArgs e)
        {
            labelFname.Text = fname;
            labelLname.Text = lname;
            labelPatronymic.Text = patronymic;
            labelPost.Text = post;
            if (dismissal != "31.12.9999 0:00:00") labelChecDis.Text = "Уволен";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            btn = "update";
            StaffInfo staffInfo = new StaffInfo(idstaff, fname, lname, patronymic, post, address, number, birthday, hiring, dismissal, idmig, btn);
            staffInfo.ShowDialog();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            btn = "open";
            StaffInfo staffInfo = new StaffInfo(idstaff, fname, lname, patronymic, post, address, number, birthday, hiring,  dismissal, idmig, btn);
            staffInfo.ShowDialog();
        }
    }
}
