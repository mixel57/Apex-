
namespace Apex_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccounts = new System.Windows.Forms.Label();
            this.labelCheck = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelBadge = new System.Windows.Forms.Label();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRefrersh = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddNotes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelAccounts);
            this.panel1.Controls.Add(this.labelCheck);
            this.panel1.Controls.Add(this.labelStaff);
            this.panel1.Controls.Add(this.labelBadge);
            this.panel1.Controls.Add(this.labelSchedule);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 557);
            this.panel1.TabIndex = 0;
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAccounts.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelAccounts.Location = new System.Drawing.Point(7, 305);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(173, 24);
            this.labelAccounts.TabIndex = 5;
            this.labelAccounts.Text = "Список аккаунтов";
            this.labelAccounts.Click += new System.EventHandler(this.labelAccounts_Click);
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCheck.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelCheck.Location = new System.Drawing.Point(7, 345);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(154, 24);
            this.labelCheck.TabIndex = 5;
            this.labelCheck.Text = "Список отметок";
            this.labelCheck.Click += new System.EventHandler(this.labelCheck_Click);
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStaff.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelStaff.Location = new System.Drawing.Point(7, 265);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(194, 24);
            this.labelStaff.TabIndex = 5;
            this.labelStaff.Text = "Список сотрудников";
            this.labelStaff.Click += new System.EventHandler(this.labelStaff_Click);
            // 
            // labelBadge
            // 
            this.labelBadge.AutoSize = true;
            this.labelBadge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBadge.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelBadge.Location = new System.Drawing.Point(7, 225);
            this.labelBadge.Name = "labelBadge";
            this.labelBadge.Size = new System.Drawing.Size(152, 24);
            this.labelBadge.TabIndex = 5;
            this.labelBadge.Text = "Печать бейджа";
            this.labelBadge.Click += new System.EventHandler(this.labelBadge_Click);
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSchedule.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelSchedule.Location = new System.Drawing.Point(7, 185);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(116, 24);
            this.labelSchedule.TabIndex = 4;
            this.labelSchedule.Text = "Расписание";
            this.labelSchedule.Click += new System.EventHandler(this.labelSchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(0, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пожалуйста, не забывайте\r\nотмечаться\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCheck
            // 
            this.buttonCheck.AutoSize = true;
            this.buttonCheck.BackColor = System.Drawing.Color.Wheat;
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCheck.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCheck.Location = new System.Drawing.Point(0, 507);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(210, 48);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Отметиться";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apex_.Properties.Resources.logo_apeks;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRefrersh);
            this.panel2.Controls.Add(this.buttonAddUser);
            this.panel2.Controls.Add(this.labelHello);
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 48);
            this.panel2.TabIndex = 1;
            // 
            // buttonRefrersh
            // 
            this.buttonRefrersh.AutoSize = true;
            this.buttonRefrersh.BackColor = System.Drawing.Color.Wheat;
            this.buttonRefrersh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefrersh.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefrersh.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonRefrersh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonRefrersh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefrersh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefrersh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefrersh.Image")));
            this.buttonRefrersh.Location = new System.Drawing.Point(452, 0);
            this.buttonRefrersh.Name = "buttonRefrersh";
            this.buttonRefrersh.Size = new System.Drawing.Size(48, 48);
            this.buttonRefrersh.TabIndex = 3;
            this.buttonRefrersh.UseVisualStyleBackColor = false;
            this.buttonRefrersh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.AutoSize = true;
            this.buttonAddUser.BackColor = System.Drawing.Color.Wheat;
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddUser.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddUser.Location = new System.Drawing.Point(500, 0);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(111, 48);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Создать";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Underline);
            this.labelHello.Location = new System.Drawing.Point(160, 14);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(36, 18);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Имя";
            // 
            // buttonLogout
            // 
            this.buttonLogout.AutoSize = true;
            this.buttonLogout.BackColor = System.Drawing.Color.Wheat;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogout.Location = new System.Drawing.Point(611, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(111, 48);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Выйти";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вы авторизованы как";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonAddNotes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxNotes);
            this.panel3.Controls.Add(this.flowLayoutPanelMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(212, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 509);
            this.panel3.TabIndex = 2;
            // 
            // buttonAddNotes
            // 
            this.buttonAddNotes.AutoSize = true;
            this.buttonAddNotes.BackColor = System.Drawing.Color.Wheat;
            this.buttonAddNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNotes.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonAddNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonAddNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonAddNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddNotes.Location = new System.Drawing.Point(631, 373);
            this.buttonAddNotes.Name = "buttonAddNotes";
            this.buttonAddNotes.Size = new System.Drawing.Size(87, 109);
            this.buttonAddNotes.TabIndex = 3;
            this.buttonAddNotes.Text = "Добавить";
            this.buttonAddNotes.UseVisualStyleBackColor = false;
            this.buttonAddNotes.Click += new System.EventHandler(this.buttonAddNotes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(7, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавить заметку:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBoxNotes.Location = new System.Drawing.Point(7, 373);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(620, 109);
            this.textBoxNotes.TabIndex = 1;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(721, 327);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Moccasin;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(212, 535);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(722, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(275, 17);
            this.toolStripStatusLabel.Text = "Не забывайте обновлять списки после удаления";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(934, 557);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Апекс сотрудники";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelBadge;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonAddNotes;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        public System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonRefrersh;
        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

