namespace WinFormsApp5
{
    partial class FormLog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            CheckPass = new CheckBox();
            TxtUser = new Guna.UI2.WinForms.Guna2TextBox();
            TxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CheckPass
            // 
            CheckPass.AutoSize = true;
            CheckPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckPass.Location = new Point(235, 154);
            CheckPass.Name = "CheckPass";
            CheckPass.Size = new Size(112, 19);
            CheckPass.TabIndex = 1;
            CheckPass.Text = "Show Password";
            CheckPass.UseVisualStyleBackColor = true;
            CheckPass.CheckedChanged += CheckPass_CheckedChanged;
            // 
            // TxtUser
            // 
            TxtUser.BorderColor = Color.Gray;
            TxtUser.BorderRadius = 10;
            TxtUser.CustomizableEdges = customizableEdges1;
            TxtUser.DefaultText = "";
            TxtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUser.ForeColor = Color.Black;
            TxtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtUser.Location = new Point(235, 40);
            TxtUser.Name = "TxtUser";
            TxtUser.PasswordChar = '\0';
            TxtUser.PlaceholderText = "USERNAME";
            TxtUser.SelectedText = "";
            TxtUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxtUser.Size = new Size(248, 51);
            TxtUser.TabIndex = 2;
            // 
            // TxtPass
            // 
            TxtPass.BorderColor = Color.Gray;
            TxtPass.BorderRadius = 10;
            TxtPass.CustomizableEdges = customizableEdges3;
            TxtPass.DefaultText = "";
            TxtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPass.ForeColor = Color.Black;
            TxtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtPass.Location = new Point(235, 97);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '\0';
            TxtPass.PlaceholderText = "PASSWORD";
            TxtPass.SelectedText = "";
            TxtPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxtPass.Size = new Size(248, 51);
            TxtPass.TabIndex = 3;
            // 
            // BtnLogin
            // 
            BtnLogin.BorderColor = Color.Gray;
            BtnLogin.BorderRadius = 10;
            BtnLogin.CustomizableEdges = customizableEdges5;
            BtnLogin.DisabledState.BorderColor = Color.DarkGray;
            BtnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnLogin.FillColor = Color.Green;
            BtnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(235, 179);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnLogin.Size = new Size(248, 51);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "LOGIN";
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(235, 12);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(490, 241);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPass);
            Controls.Add(TxtUser);
            Controls.Add(CheckPass);
            Name = "FormLog";
            Text = "LOGIN";
            Load += FormLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox CheckPass;
        private Guna.UI2.WinForms.Guna2TextBox TxtUser;
        private Guna.UI2.WinForms.Guna2TextBox TxtPass;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
