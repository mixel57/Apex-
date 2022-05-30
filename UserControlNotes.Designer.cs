
namespace Apex_
{
    partial class UserControlNotes
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDeleteNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelName.Location = new System.Drawing.Point(10, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя фамилия";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelDate.Location = new System.Drawing.Point(470, 27);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 19);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Время";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPost.Location = new System.Drawing.Point(10, 59);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(91, 19);
            this.labelPost.TabIndex = 0;
            this.labelPost.Text = "Должность";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox.Location = new System.Drawing.Point(7, 93);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(620, 211);
            this.textBox.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(604, 74);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(0, 16);
            this.labelNumber.TabIndex = 2;
            // 
            // labelDeleteNotes
            // 
            this.labelDeleteNotes.AutoSize = true;
            this.labelDeleteNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDeleteNotes.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelDeleteNotes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDeleteNotes.Location = new System.Drawing.Point(675, 0);
            this.labelDeleteNotes.Name = "labelDeleteNotes";
            this.labelDeleteNotes.Size = new System.Drawing.Size(20, 24);
            this.labelDeleteNotes.TabIndex = 3;
            this.labelDeleteNotes.Text = "х";
            this.labelDeleteNotes.Click += new System.EventHandler(this.labelDeleteNotes_Click);
            // 
            // UserControlNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.Controls.Add(this.labelDeleteNotes);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlNotes";
            this.Size = new System.Drawing.Size(695, 310);
            this.Load += new System.EventHandler(this.UserControlNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDeleteNotes;
    }
}
