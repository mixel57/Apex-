
namespace Apex_
{
    partial class StaffInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.pictureBoxStaff = new System.Windows.Forms.PictureBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHiring = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDismissal = new System.Windows.Forms.MaskedTextBox();
            this.button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxBirthday = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaff)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxStaff
            // 
            this.pictureBoxStaff.Image = global::Apex_.Properties.Resources.Apexperson;
            this.pictureBoxStaff.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxStaff.Name = "pictureBoxStaff";
            this.pictureBoxStaff.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStaff.TabIndex = 0;
            this.pictureBoxStaff.TabStop = false;
            // 
            // buttonOpen
            // 
            this.buttonOpen.AutoSize = true;
            this.buttonOpen.BackColor = System.Drawing.Color.Wheat;
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpen.Location = new System.Drawing.Point(12, 146);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(128, 34);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Сменить аватар";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(150, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(150, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(150, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Вакансия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(20, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label6.Location = new System.Drawing.Point(20, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Номер телефона:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label7.Location = new System.Drawing.Point(20, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата трудоустройства:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label8.Location = new System.Drawing.Point(20, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата увольнения:";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textBoxFname.Location = new System.Drawing.Point(244, 17);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(228, 28);
            this.textBoxFname.TabIndex = 17;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textBoxLname.Location = new System.Drawing.Point(244, 62);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(228, 28);
            this.textBoxLname.TabIndex = 17;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textBoxPatronymic.Location = new System.Drawing.Point(244, 107);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(228, 28);
            this.textBoxPatronymic.TabIndex = 17;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textBoxAddress.Location = new System.Drawing.Point(91, 207);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(381, 28);
            this.textBoxAddress.TabIndex = 17;
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Font = new System.Drawing.Font("Tahoma", 13F);
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(180, 252);
            this.maskedTextBoxNumber.Mask = "00000000000";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(110, 28);
            this.maskedTextBoxNumber.TabIndex = 18;
            // 
            // maskedTextBoxHiring
            // 
            this.maskedTextBoxHiring.Font = new System.Drawing.Font("Tahoma", 13F);
            this.maskedTextBoxHiring.Location = new System.Drawing.Point(222, 342);
            this.maskedTextBoxHiring.Mask = "00-00-0000";
            this.maskedTextBoxHiring.Name = "maskedTextBoxHiring";
            this.maskedTextBoxHiring.Size = new System.Drawing.Size(250, 28);
            this.maskedTextBoxHiring.TabIndex = 18;
            // 
            // maskedTextBoxDismissal
            // 
            this.maskedTextBoxDismissal.Font = new System.Drawing.Font("Tahoma", 13F);
            this.maskedTextBoxDismissal.Location = new System.Drawing.Point(222, 387);
            this.maskedTextBoxDismissal.Mask = "00-00-0000";
            this.maskedTextBoxDismissal.Name = "maskedTextBoxDismissal";
            this.maskedTextBoxDismissal.Size = new System.Drawing.Size(250, 28);
            this.maskedTextBoxDismissal.TabIndex = 18;
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.BackColor = System.Drawing.Color.Wheat;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button.Location = new System.Drawing.Point(24, 441);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(448, 48);
            this.button.TabIndex = 19;
            this.button.Text = "Действие";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.Location = new System.Drawing.Point(20, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Дата рождения:";
            // 
            // maskedTextBoxBirthday
            // 
            this.maskedTextBoxBirthday.Font = new System.Drawing.Font("Tahoma", 13F);
            this.maskedTextBoxBirthday.Location = new System.Drawing.Point(222, 297);
            this.maskedTextBoxBirthday.Mask = "00-00-0000";
            this.maskedTextBoxBirthday.Name = "maskedTextBoxBirthday";
            this.maskedTextBoxBirthday.Size = new System.Drawing.Size(250, 28);
            this.maskedTextBoxBirthday.TabIndex = 18;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPost.Font = new System.Drawing.Font("Tahoma", 13F);
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "Кассир",
            "Продавец",
            "Гастрономист",
            "Администратор",
            "Контролёр",
            "Старший контролёр",
            "Заведующий магазина",
            "Товаровед",
            "Кладовщик",
            "Грузчик",
            "Оператор",
            "Пекарь"});
            this.comboBoxPost.Location = new System.Drawing.Point(244, 152);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(228, 29);
            this.comboBoxPost.TabIndex = 20;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textBoxPost.Location = new System.Drawing.Point(244, 153);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(228, 28);
            this.textBoxPost.TabIndex = 17;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Moccasin;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(356, 17);
            this.toolStripStatusLabel.Text = "Дата увольнения 31-12-9999 означает, что сотрудник не уволен";
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(484, 512);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.button);
            this.Controls.Add(this.maskedTextBoxDismissal);
            this.Controls.Add(this.maskedTextBoxBirthday);
            this.Controls.Add(this.maskedTextBoxHiring);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.pictureBoxStaff);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Апекс сотрудники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffInfo_FormClosed);
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaff)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStaff;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHiring;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDismissal;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthday;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}