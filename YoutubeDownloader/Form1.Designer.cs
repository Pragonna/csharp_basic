namespace YoutubeDownloader
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tabControl_download = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            lblProgressState = new Label();
            progressBar1 = new ProgressBar();
            groupBox_Details = new GroupBox();
            btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            txSaveTo = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            txTitle = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            btnStart = new Guna.UI2.WinForms.Guna2Button();
            txUrl = new Guna.UI2.WinForms.Guna2TextBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            tabControl_download.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox_Details.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_download
            // 
            tabControl_download.Controls.Add(tabPage1);
            tabControl_download.Controls.Add(tabPage2);
            tabControl_download.Location = new Point(1, 12);
            tabControl_download.Name = "tabControl_download";
            tabControl_download.SelectedIndex = 0;
            tabControl_download.Size = new Size(770, 322);
            tabControl_download.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 64, 64);
            tabPage1.Controls.Add(guna2Button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(lblProgressState);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(groupBox_Details);
            tabPage1.Controls.Add(btnStart);
            tabPage1.Controls.Add(txUrl);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(762, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Download";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(56, 26);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "URL:";
            // 
            // lblProgressState
            // 
            lblProgressState.AutoSize = true;
            lblProgressState.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProgressState.ForeColor = SystemColors.ButtonFace;
            lblProgressState.Location = new Point(306, 228);
            lblProgressState.Name = "lblProgressState";
            lblProgressState.Size = new Size(89, 15);
            lblProgressState.TabIndex = 6;
            lblProgressState.Text = "Processing...0%";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(25, 246);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(694, 23);
            progressBar1.TabIndex = 3;
            // 
            // groupBox_Details
            // 
            groupBox_Details.Controls.Add(btnBrowse);
            groupBox_Details.Controls.Add(txSaveTo);
            groupBox_Details.Controls.Add(label1);
            groupBox_Details.Controls.Add(txTitle);
            groupBox_Details.Controls.Add(lblTitle);
            groupBox_Details.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Details.ForeColor = SystemColors.ButtonHighlight;
            groupBox_Details.Location = new Point(25, 65);
            groupBox_Details.Name = "groupBox_Details";
            groupBox_Details.Size = new Size(694, 151);
            groupBox_Details.TabIndex = 2;
            groupBox_Details.TabStop = false;
            groupBox_Details.Text = "Details:";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Transparent;
            btnBrowse.BorderRadius = 15;
            btnBrowse.CustomizableEdges = customizableEdges3;
            btnBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse.FillColor = Color.LightSeaGreen;
            btnBrowse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(545, 86);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBrowse.Size = new Size(73, 41);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txSaveTo
            // 
            txSaveTo.BorderRadius = 8;
            txSaveTo.CustomizableEdges = customizableEdges5;
            txSaveTo.DefaultText = "";
            txSaveTo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txSaveTo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txSaveTo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txSaveTo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txSaveTo.FillColor = Color.WhiteSmoke;
            txSaveTo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txSaveTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txSaveTo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txSaveTo.Location = new Point(94, 86);
            txSaveTo.Name = "txSaveTo";
            txSaveTo.PasswordChar = '\0';
            txSaveTo.PlaceholderText = "";
            txSaveTo.SelectedText = "";
            txSaveTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txSaveTo.Size = new Size(445, 36);
            txSaveTo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 96);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 6;
            label1.Text = "Save To:";
            // 
            // txTitle
            // 
            txTitle.BorderRadius = 8;
            txTitle.CustomizableEdges = customizableEdges7;
            txTitle.DefaultText = "";
            txTitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txTitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txTitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txTitle.FillColor = Color.WhiteSmoke;
            txTitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txTitle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txTitle.Location = new Point(94, 31);
            txTitle.Name = "txTitle";
            txTitle.PasswordChar = '\0';
            txTitle.PlaceholderText = "";
            txTitle.SelectedText = "";
            txTitle.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txTitle.Size = new Size(445, 36);
            txTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(36, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 16);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // btnStart
            // 
            btnStart.BorderRadius = 15;
            btnStart.CustomizableEdges = customizableEdges9;
            btnStart.DisabledState.BorderColor = Color.DarkGray;
            btnStart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(570, 17);
            btnStart.Name = "btnStart";
            btnStart.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnStart.Size = new Size(97, 36);
            btnStart.TabIndex = 1;
            btnStart.Text = "Download";
            btnStart.Click += btnStart_Click;
            // 
            // txUrl
            // 
            txUrl.BorderRadius = 8;
            txUrl.CustomizableEdges = customizableEdges11;
            txUrl.DefaultText = "";
            txUrl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txUrl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txUrl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txUrl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txUrl.FillColor = Color.WhiteSmoke;
            txUrl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txUrl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txUrl.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txUrl.Location = new Point(119, 17);
            txUrl.Name = "txUrl";
            txUrl.PasswordChar = '\0';
            txUrl.PlaceholderText = "";
            txUrl.SelectedText = "";
            txUrl.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txUrl.Size = new Size(445, 36);
            txUrl.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 64, 64);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(762, 294);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Help";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(462, 91);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(192, 0, 0);
            guna2Button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(673, 17);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(81, 36);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "Cancel";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(763, 331);
            Controls.Add(tabControl_download);
            Name = "Form1";
            Text = "YoutubeDownloader";
            tabControl_download.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox_Details.ResumeLayout(false);
            groupBox_Details.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_download;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2TextBox txUrl;
        private GroupBox groupBox_Details;
        private Guna.UI2.WinForms.Guna2TextBox txTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2TextBox txSaveTo;
        private Label label1;
        private ProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Label lblProgressState;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}