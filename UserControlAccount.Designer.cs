
namespace Apex_
{
    partial class UserControlAccount
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelPatr = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelDeleteUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonOpen.Location = new System.Drawing.Point(3, 116);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(217, 48);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.BackColor = System.Drawing.Color.Wheat;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdate.Location = new System.Drawing.Point(221, 116);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(217, 48);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelName.Location = new System.Drawing.Point(115, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 19);
            this.labelName.TabIndex = 17;
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelSecondName.Location = new System.Drawing.Point(115, 45);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(0, 19);
            this.labelSecondName.TabIndex = 17;
            // 
            // labelPatr
            // 
            this.labelPatr.AutoSize = true;
            this.labelPatr.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPatr.Location = new System.Drawing.Point(115, 75);
            this.labelPatr.Name = "labelPatr";
            this.labelPatr.Size = new System.Drawing.Size(0, 19);
            this.labelPatr.TabIndex = 17;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelLogin.Location = new System.Drawing.Point(304, 45);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 19);
            this.labelLogin.TabIndex = 17;
            // 
            // labelDeleteUser
            // 
            this.labelDeleteUser.AutoSize = true;
            this.labelDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDeleteUser.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelDeleteUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDeleteUser.Location = new System.Drawing.Point(421, 0);
            this.labelDeleteUser.Name = "labelDeleteUser";
            this.labelDeleteUser.Size = new System.Drawing.Size(20, 24);
            this.labelDeleteUser.TabIndex = 18;
            this.labelDeleteUser.Text = "х";
            this.labelDeleteUser.Click += new System.EventHandler(this.labelDeleteUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(305, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Логин:";
            // 
            // UserControlAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDeleteUser);
            this.Controls.Add(this.labelPatr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonUpdate);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlAccount";
            this.Size = new System.Drawing.Size(441, 166);
            this.Load += new System.EventHandler(this.UserControlAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelPatr;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelDeleteUser;
        private System.Windows.Forms.Label label4;
    }
}
