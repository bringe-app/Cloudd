
namespace Cloudd
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.emailLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.seePasswordButton = new FontAwesome.Sharp.IconButton();
            this.genderPanel = new Cloudd.RoundedPanel(this.components);
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.passwordPanel = new Cloudd.RoundedPanel(this.components);
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernamePanel = new Cloudd.RoundedPanel(this.components);
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.lastnamePanel = new Cloudd.RoundedPanel(this.components);
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.firstnamePanel = new Cloudd.RoundedPanel(this.components);
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.emailPanel = new Cloudd.RoundedPanel(this.components);
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.signUpButton = new Cloudd.RoundedButton(this.components);
            this.genderPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.lastnamePanel.SuspendLayout();
            this.firstnamePanel.SuspendLayout();
            this.emailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(13, 110);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(126, 48);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email:";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 2;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Black;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 70;
            this.minimizeButton.Location = new System.Drawing.Point(864, 49);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(80, 54);
            this.minimizeButton.TabIndex = 26;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 94;
            this.exitButton.Location = new System.Drawing.Point(950, 39);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(93, 74);
            this.exitButton.TabIndex = 25;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFirstname.Location = new System.Drawing.Point(13, 257);
            this.labelFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(218, 48);
            this.labelFirstname.TabIndex = 27;
            this.labelFirstname.Text = "First Name:";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLastname.Location = new System.Drawing.Point(13, 400);
            this.labelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(212, 48);
            this.labelLastname.TabIndex = 29;
            this.labelLastname.Text = "Last Name:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUsername.Location = new System.Drawing.Point(13, 543);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(204, 48);
            this.labelUsername.TabIndex = 30;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassword.Location = new System.Drawing.Point(12, 692);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(196, 48);
            this.labelPassword.TabIndex = 31;
            this.labelPassword.Text = "Password:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderLabel.Location = new System.Drawing.Point(12, 833);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(156, 48);
            this.genderLabel.TabIndex = 32;
            this.genderLabel.Text = "Gender:";
            // 
            // seePasswordButton
            // 
            this.seePasswordButton.FlatAppearance.BorderSize = 0;
            this.seePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePasswordButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.seePasswordButton.IconColor = System.Drawing.Color.Black;
            this.seePasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.seePasswordButton.IconSize = 70;
            this.seePasswordButton.Location = new System.Drawing.Point(990, 755);
            this.seePasswordButton.Name = "seePasswordButton";
            this.seePasswordButton.Size = new System.Drawing.Size(75, 72);
            this.seePasswordButton.TabIndex = 20;
            this.seePasswordButton.UseVisualStyleBackColor = true;
            this.seePasswordButton.Click += new System.EventHandler(this.seePasswordButton_Click);
            // 
            // genderPanel
            // 
            this.genderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.genderPanel.Controls.Add(this.genderComboBox);
            this.genderPanel.Location = new System.Drawing.Point(12, 874);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Padding = new System.Windows.Forms.Padding(30, 15, 30, 3);
            this.genderPanel.Size = new System.Drawing.Size(450, 77);
            this.genderPanel.TabIndex = 32;
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female ",
            "Other"});
            this.genderComboBox.Location = new System.Drawing.Point(30, 15);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(390, 41);
            this.genderComboBox.TabIndex = 6;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.passwordPanel.Controls.Add(this.passwordTextbox);
            this.passwordPanel.Location = new System.Drawing.Point(12, 738);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.passwordPanel.Size = new System.Drawing.Size(972, 89);
            this.passwordPanel.TabIndex = 31;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.Location = new System.Drawing.Point(17, 20);
            this.passwordTextbox.MaxLength = 64;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(938, 46);
            this.passwordTextbox.TabIndex = 15;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.usernamePanel.Controls.Add(this.usernameTextbox);
            this.usernamePanel.Location = new System.Drawing.Point(12, 590);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.usernamePanel.Size = new System.Drawing.Size(1034, 89);
            this.usernamePanel.TabIndex = 30;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextbox.Location = new System.Drawing.Point(17, 20);
            this.usernameTextbox.MaxLength = 32;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(1000, 46);
            this.usernameTextbox.TabIndex = 15;
            // 
            // lastnamePanel
            // 
            this.lastnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lastnamePanel.Controls.Add(this.lastnameTextbox);
            this.lastnamePanel.Location = new System.Drawing.Point(12, 442);
            this.lastnamePanel.Name = "lastnamePanel";
            this.lastnamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.lastnamePanel.Size = new System.Drawing.Size(1041, 89);
            this.lastnamePanel.TabIndex = 29;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lastnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastnameTextbox.Location = new System.Drawing.Point(17, 20);
            this.lastnameTextbox.MaxLength = 32;
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(1007, 46);
            this.lastnameTextbox.TabIndex = 15;
            this.lastnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastnameTextbox_KeyPress);
            // 
            // firstnamePanel
            // 
            this.firstnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.firstnamePanel.Controls.Add(this.firstnameTextbox);
            this.firstnamePanel.Location = new System.Drawing.Point(12, 308);
            this.firstnamePanel.Name = "firstnamePanel";
            this.firstnamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.firstnamePanel.Size = new System.Drawing.Size(1041, 89);
            this.firstnamePanel.TabIndex = 28;
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.firstnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstnameTextbox.Location = new System.Drawing.Point(17, 20);
            this.firstnameTextbox.MaxLength = 32;
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(1007, 46);
            this.firstnameTextbox.TabIndex = 15;
            this.firstnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnameTextbox_KeyPress);
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emailPanel.Controls.Add(this.emailTextbox);
            this.emailPanel.Location = new System.Drawing.Point(12, 161);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.emailPanel.Size = new System.Drawing.Size(1041, 89);
            this.emailPanel.TabIndex = 24;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextbox.Location = new System.Drawing.Point(17, 20);
            this.emailTextbox.MaxLength = 64;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(1007, 46);
            this.emailTextbox.TabIndex = 15;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signUpButton.Location = new System.Drawing.Point(736, 851);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(316, 100);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1091, 1055);
            this.Controls.Add(this.seePasswordButton);
            this.Controls.Add(this.genderPanel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lastnamePanel);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.firstnamePanel);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.signUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1091, 1055);
            this.MinimumSize = new System.Drawing.Size(1091, 1055);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignUpForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignUpForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SignUpForm_MouseUp);
            this.genderPanel.ResumeLayout(false);
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.lastnamePanel.ResumeLayout(false);
            this.lastnamePanel.PerformLayout();
            this.firstnamePanel.ResumeLayout(false);
            this.firstnamePanel.PerformLayout();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton signUpButton;
        private System.Windows.Forms.Label emailLabel;
        private RoundedPanel emailPanel;
        private System.Windows.Forms.TextBox emailTextbox;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private System.Windows.Forms.Label labelFirstname;
        private RoundedPanel firstnamePanel;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.Label labelLastname;
        private RoundedPanel lastnamePanel;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Label labelUsername;
        private RoundedPanel usernamePanel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label labelPassword;
        private RoundedPanel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label genderLabel;
        private RoundedPanel genderPanel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private FontAwesome.Sharp.IconButton seePasswordButton;
    }
}