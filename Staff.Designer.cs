
namespace Apex_
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.flowLayoutStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRefrersh = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutStaff
            // 
            this.flowLayoutStaff.AutoScroll = true;
            this.flowLayoutStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutStaff.Location = new System.Drawing.Point(5, 53);
            this.flowLayoutStaff.Name = "flowLayoutStaff";
            this.flowLayoutStaff.Size = new System.Drawing.Size(474, 395);
            this.flowLayoutStaff.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 17F);
            this.label.Location = new System.Drawing.Point(127, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 28);
            this.label.TabIndex = 1;
            this.label.Text = "Список";
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.Wheat;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(16, 454);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(448, 48);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefrersh
            // 
            this.buttonRefrersh.AutoSize = true;
            this.buttonRefrersh.BackColor = System.Drawing.Color.Wheat;
            this.buttonRefrersh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefrersh.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonRefrersh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonRefrersh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefrersh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefrersh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefrersh.Image")));
            this.buttonRefrersh.Location = new System.Drawing.Point(431, 3);
            this.buttonRefrersh.Name = "buttonRefrersh";
            this.buttonRefrersh.Size = new System.Drawing.Size(48, 48);
            this.buttonRefrersh.TabIndex = 21;
            this.buttonRefrersh.UseVisualStyleBackColor = false;
            this.buttonRefrersh.Click += new System.EventHandler(this.buttonRefrersh_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Moccasin;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 503);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(275, 17);
            this.toolStripStatusLabel.Text = "Не забывайте обновлять список после удаления";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(484, 525);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonRefrersh);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label);
            this.Controls.Add(this.flowLayoutStaff);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Апекс сотрудники";
            this.Activated += new System.EventHandler(this.Staff_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_FormClosed);
            this.Load += new System.EventHandler(this.Staff_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStaff;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefrersh;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}