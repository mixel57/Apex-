
namespace Apex_
{
    partial class DataGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMain = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 42);
            this.panel1.TabIndex = 0;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelMain.Location = new System.Drawing.Point(416, 8);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(104, 24);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Заголовок";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 201);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(910, 279);
            this.dataGridView.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonReport);
            this.groupBox.Controls.Add(this.dateTimePicker);
            this.groupBox.Controls.Add(this.comboBoxStaff);
            this.groupBox.Controls.Add(this.radioButtonStaff);
            this.groupBox.Controls.Add(this.radioButtonDate);
            this.groupBox.Controls.Add(this.radioButtonAll);
            this.groupBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox.Location = new System.Drawing.Point(12, 48);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(910, 147);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Запросы к данным";
            // 
            // buttonReport
            // 
            this.buttonReport.AutoSize = true;
            this.buttonReport.BackColor = System.Drawing.Color.Wheat;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReport.Location = new System.Drawing.Point(744, 99);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(160, 48);
            this.buttonReport.TabIndex = 21;
            this.buttonReport.Text = "Сформировать отчёт";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(307, 114);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(176, 25);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(307, 76);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(176, 26);
            this.comboBoxStaff.TabIndex = 1;
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonStaff.Location = new System.Drawing.Point(22, 77);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(127, 22);
            this.radioButtonStaff.TabIndex = 0;
            this.radioButtonStaff.TabStop = true;
            this.radioButtonStaff.Text = "По сотруднику";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            this.radioButtonStaff.CheckedChanged += new System.EventHandler(this.radioButtonStaff_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonDate.Location = new System.Drawing.Point(22, 117);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(81, 22);
            this.radioButtonDate.TabIndex = 0;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "По дате";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAll.Location = new System.Drawing.Point(22, 37);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(50, 22);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Все";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // buttonLeft
            // 
            this.buttonLeft.AutoSize = true;
            this.buttonLeft.BackColor = System.Drawing.Color.Wheat;
            this.buttonLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLeft.Location = new System.Drawing.Point(12, 486);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(454, 48);
            this.buttonLeft.TabIndex = 21;
            this.buttonLeft.Text = "Удалить";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.AutoSize = true;
            this.buttonRight.BackColor = System.Drawing.Color.Wheat;
            this.buttonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.buttonRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.buttonRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRight.Location = new System.Drawing.Point(468, 486);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(454, 48);
            this.buttonRight.TabIndex = 21;
            this.buttonRight.Text = "Добавить/закрыть";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(934, 537);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DataGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Апекс сотрудники";
            this.Activated += new System.EventHandler(this.DataGridForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataGridForm_FormClosed);
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.RadioButton radioButtonStaff;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonReport;
    }
}