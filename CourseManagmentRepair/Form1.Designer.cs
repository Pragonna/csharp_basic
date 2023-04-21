namespace CourseManagmentRepair
{
    partial class CourseManagment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_Managment = new DataGridView();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label_ID_S = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnUpdate_S = new Button();
            btnDelete_S = new Button();
            btnAdd_S = new Button();
            cmbCourse = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtSurname_S = new TextBox();
            txtName_S = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            labelID_S_Value = new Label();
            labelID_S = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Managment).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Managment
            // 
            dataGridView_Managment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Managment.Location = new Point(238, 12);
            dataGridView_Managment.Name = "dataGridView_Managment";
            dataGridView_Managment.RowTemplate.Height = 25;
            dataGridView_Managment.Size = new Size(1029, 495);
            dataGridView_Managment.TabIndex = 0;
            dataGridView_Managment.CellContentClick += dataGridView_Managment_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(232, 495);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label_ID_S);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnUpdate_S);
            tabPage2.Controls.Add(btnDelete_S);
            tabPage2.Controls.Add(btnAdd_S);
            tabPage2.Controls.Add(cmbCourse);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(txtSurname_S);
            tabPage2.Controls.Add(txtName_S);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(labelID_S_Value);
            tabPage2.Controls.Add(labelID_S);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(224, 467);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Student";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label_ID_S
            // 
            label_ID_S.AutoSize = true;
            label_ID_S.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_ID_S.Location = new Point(43, 23);
            label_ID_S.Name = "label_ID_S";
            label_ID_S.Size = new Size(15, 19);
            label_ID_S.TabIndex = 22;
            label_ID_S.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.AppWorkspace;
            label11.Location = new Point(-4, 38);
            label11.Name = "label11";
            label11.Size = new Size(232, 15);
            label11.TabIndex = 21;
            label11.Text = "_____________________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(6, 224);
            label10.Name = "label10";
            label10.Size = new Size(58, 17);
            label10.TabIndex = 20;
            label10.Text = "Course *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(6, 167);
            label9.Name = "label9";
            label9.Size = new Size(96, 17);
            label9.TabIndex = 19;
            label9.Text = "Date of Birth *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(6, 109);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 18;
            label8.Text = "Surname *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(6, 56);
            label7.Name = "label7";
            label7.Size = new Size(53, 17);
            label7.TabIndex = 17;
            label7.Text = "Name *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(8, 21);
            label6.Name = "label6";
            label6.Size = new Size(29, 17);
            label6.TabIndex = 16;
            label6.Text = "ID: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(7, 38);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 15;
            // 
            // btnUpdate_S
            // 
            btnUpdate_S.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate_S.Location = new Point(6, 316);
            btnUpdate_S.Name = "btnUpdate_S";
            btnUpdate_S.Size = new Size(210, 23);
            btnUpdate_S.TabIndex = 14;
            btnUpdate_S.Text = "UPDATE";
            btnUpdate_S.UseVisualStyleBackColor = true;
            btnUpdate_S.Click += btnUpdate_S_Click;
            // 
            // btnDelete_S
            // 
            btnDelete_S.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete_S.Location = new Point(6, 345);
            btnDelete_S.Name = "btnDelete_S";
            btnDelete_S.Size = new Size(210, 23);
            btnDelete_S.TabIndex = 13;
            btnDelete_S.Text = "DELETE";
            btnDelete_S.UseVisualStyleBackColor = true;
            btnDelete_S.Click += btnDelete_S_Click;
            // 
            // btnAdd_S
            // 
            btnAdd_S.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd_S.Location = new Point(6, 287);
            btnAdd_S.Name = "btnAdd_S";
            btnAdd_S.Size = new Size(210, 23);
            btnAdd_S.TabIndex = 12;
            btnAdd_S.Text = "ADD";
            btnAdd_S.UseVisualStyleBackColor = true;
            btnAdd_S.Click += btnAdd_S_Click;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(6, 242);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(210, 25);
            cmbCourse.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(6, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 25);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtSurname_S
            // 
            txtSurname_S.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname_S.Location = new Point(6, 129);
            txtSurname_S.Name = "txtSurname_S";
            txtSurname_S.Size = new Size(210, 25);
            txtSurname_S.TabIndex = 9;
            // 
            // txtName_S
            // 
            txtName_S.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName_S.Location = new Point(6, 74);
            txtName_S.Name = "txtName_S";
            txtName_S.Size = new Size(210, 25);
            txtName_S.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 224);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 169);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // labelID_S_Value
            // 
            labelID_S_Value.AutoSize = true;
            labelID_S_Value.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelID_S_Value.Location = new Point(40, 21);
            labelID_S_Value.Name = "labelID_S_Value";
            labelID_S_Value.Size = new Size(0, 19);
            labelID_S_Value.TabIndex = 1;
            // 
            // labelID_S
            // 
            labelID_S.AutoSize = true;
            labelID_S.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID_S.Location = new Point(8, 23);
            labelID_S.Name = "labelID_S";
            labelID_S.Size = new Size(0, 15);
            labelID_S.TabIndex = 0;
            // 
            // CourseManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 532);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView_Managment);
            Name = "CourseManagment";
            Text = "Form1";
            Load += CourseManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Managment).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Managment;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label5;
        private Button btnUpdate_S;
        private Button btnDelete_S;
        private Button btnAdd_S;
        private ComboBox cmbCourse;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSurname_S;
        private TextBox txtName_S;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label labelID_S_Value;
        private Label labelID_S;
        private Label label_ID_S;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}