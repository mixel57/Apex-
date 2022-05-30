
namespace Apex_
{
    partial class UserControlStaff
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
            this.labelFname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelChecDis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelFname.Location = new System.Drawing.Point(147, 10);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(36, 18);
            this.labelFname.TabIndex = 0;
            this.labelFname.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(147, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelLname.Location = new System.Drawing.Point(147, 35);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(68, 18);
            this.labelLname.TabIndex = 0;
            this.labelLname.Text = "Фамилия";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelPatronymic.Location = new System.Drawing.Point(147, 60);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(74, 18);
            this.labelPatronymic.TabIndex = 0;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelPost.Location = new System.Drawing.Point(147, 120);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(85, 18);
            this.labelPost.TabIndex = 0;
            this.labelPost.Text = "Должность";
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
            this.buttonUpdate.Location = new System.Drawing.Point(221, 174);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(217, 48);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.buttonOpen.Location = new System.Drawing.Point(3, 174);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(217, 48);
            this.buttonOpen.TabIndex = 14;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelChecDis
            // 
            this.labelChecDis.AutoSize = true;
            this.labelChecDis.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelChecDis.Location = new System.Drawing.Point(147, 90);
            this.labelChecDis.Name = "labelChecDis";
            this.labelChecDis.Size = new System.Drawing.Size(0, 18);
            this.labelChecDis.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apex_.Properties.Resources.Apexperson;
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelChecDis);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlStaff";
            this.Size = new System.Drawing.Size(441, 225);
            this.Load += new System.EventHandler(this.UserControlStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelChecDis;
    }
}
