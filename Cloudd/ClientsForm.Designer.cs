namespace Cloudd
{
    partial class ClientsForm
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
            this.clientsListbox = new System.Windows.Forms.ListBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.filterLastnameLabel = new System.Windows.Forms.Label();
            this.filterFirstnameLabel = new System.Windows.Forms.Label();
            this.filterIdLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.filterIdPanel = new Cloudd.RoundedPanel(this.components);
            this.filterIdTextbox = new System.Windows.Forms.TextBox();
            this.filterFirstnamePanel = new Cloudd.RoundedPanel(this.components);
            this.filterFirstnameTextbox = new System.Windows.Forms.TextBox();
            this.filterLastnamePanel = new Cloudd.RoundedPanel(this.components);
            this.filterLastnameTextbox = new System.Windows.Forms.TextBox();
            this.emailPanel = new Cloudd.RoundedPanel(this.components);
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.usernamePanel = new Cloudd.RoundedPanel(this.components);
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.lastnamePanel = new Cloudd.RoundedPanel(this.components);
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.firstnamePanel = new Cloudd.RoundedPanel(this.components);
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.showClientsButton = new Cloudd.RoundedButton(this.components);
            this.saveButton = new Cloudd.RoundedButton(this.components);
            this.clearButton = new Cloudd.RoundedButton(this.components);
            this.deleteButton = new Cloudd.RoundedButton(this.components);
            this.filterIdPanel.SuspendLayout();
            this.filterFirstnamePanel.SuspendLayout();
            this.filterLastnamePanel.SuspendLayout();
            this.emailPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.lastnamePanel.SuspendLayout();
            this.firstnamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsListbox
            // 
            this.clientsListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.clientsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientsListbox.FormattingEnabled = true;
            this.clientsListbox.HorizontalScrollbar = true;
            this.clientsListbox.ItemHeight = 29;
            this.clientsListbox.Location = new System.Drawing.Point(27, 335);
            this.clientsListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientsListbox.Name = "clientsListbox";
            this.clientsListbox.Size = new System.Drawing.Size(407, 553);
            this.clientsListbox.TabIndex = 9;
            this.clientsListbox.DoubleClick += new System.EventHandler(this.listBoxClients_DoubleClick);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idLabel.Location = new System.Drawing.Point(493, 92);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(52, 37);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Id:";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idNumberLabel.Location = new System.Drawing.Point(553, 92);
            this.idNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(51, 37);
            this.idNumberLabel.TabIndex = 2;
            this.idNumberLabel.Text = "#0";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(505, 559);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(99, 37);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastnameLabel.Location = new System.Drawing.Point(493, 287);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(165, 37);
            this.lastnameLabel.TabIndex = 7;
            this.lastnameLabel.Text = "Last name:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstnameLabel.Location = new System.Drawing.Point(493, 160);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(169, 37);
            this.firstnameLabel.TabIndex = 8;
            this.firstnameLabel.Text = "First name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameLabel.Location = new System.Drawing.Point(493, 423);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(164, 37);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Username:";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterLabel.Location = new System.Drawing.Point(13, 26);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Padding = new System.Windows.Forms.Padding(10);
            this.filterLabel.Size = new System.Drawing.Size(185, 57);
            this.filterLabel.TabIndex = 18;
            this.filterLabel.Text = "     Filter     ";
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.separatorPanel.Location = new System.Drawing.Point(456, 2);
            this.separatorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(10, 918);
            this.separatorPanel.TabIndex = 19;
            // 
            // filterLastnameLabel
            // 
            this.filterLastnameLabel.AutoSize = true;
            this.filterLastnameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLastnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterLastnameLabel.Location = new System.Drawing.Point(3, 281);
            this.filterLastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLastnameLabel.Name = "filterLastnameLabel";
            this.filterLastnameLabel.Size = new System.Drawing.Size(129, 31);
            this.filterLastnameLabel.TabIndex = 21;
            this.filterLastnameLabel.Text = "Lastname:";
            // 
            // filterFirstnameLabel
            // 
            this.filterFirstnameLabel.AutoSize = true;
            this.filterFirstnameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFirstnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterFirstnameLabel.Location = new System.Drawing.Point(-2, 207);
            this.filterFirstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterFirstnameLabel.Name = "filterFirstnameLabel";
            this.filterFirstnameLabel.Size = new System.Drawing.Size(133, 31);
            this.filterFirstnameLabel.TabIndex = 22;
            this.filterFirstnameLabel.Text = "Firstname:";
            // 
            // filterIdLabel
            // 
            this.filterIdLabel.AutoSize = true;
            this.filterIdLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterIdLabel.Location = new System.Drawing.Point(3, 136);
            this.filterIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterIdLabel.Name = "filterIdLabel";
            this.filterIdLabel.Size = new System.Drawing.Size(44, 31);
            this.filterIdLabel.TabIndex = 23;
            this.filterIdLabel.Text = "Id:";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 2;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Black;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 70;
            this.minimizeButton.Location = new System.Drawing.Point(1009, 26);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(80, 54);
            this.minimizeButton.TabIndex = 34;
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
            this.exitButton.Location = new System.Drawing.Point(1095, 16);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(93, 74);
            this.exitButton.TabIndex = 33;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // filterIdPanel
            // 
            this.filterIdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.filterIdPanel.Controls.Add(this.filterIdTextbox);
            this.filterIdPanel.Location = new System.Drawing.Point(54, 110);
            this.filterIdPanel.Name = "filterIdPanel";
            this.filterIdPanel.Padding = new System.Windows.Forms.Padding(15);
            this.filterIdPanel.Size = new System.Drawing.Size(144, 57);
            this.filterIdPanel.TabIndex = 32;
            // 
            // filterIdTextbox
            // 
            this.filterIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.filterIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterIdTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterIdTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterIdTextbox.Location = new System.Drawing.Point(15, 15);
            this.filterIdTextbox.MaxLength = 48;
            this.filterIdTextbox.Name = "filterIdTextbox";
            this.filterIdTextbox.Size = new System.Drawing.Size(114, 28);
            this.filterIdTextbox.TabIndex = 15;
            this.filterIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterIdTextbox_KeyPress);
            this.filterIdTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterTextbox_KeyUp);
            // 
            // filterFirstnamePanel
            // 
            this.filterFirstnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.filterFirstnamePanel.Controls.Add(this.filterFirstnameTextbox);
            this.filterFirstnamePanel.Location = new System.Drawing.Point(135, 181);
            this.filterFirstnamePanel.Name = "filterFirstnamePanel";
            this.filterFirstnamePanel.Padding = new System.Windows.Forms.Padding(15);
            this.filterFirstnamePanel.Size = new System.Drawing.Size(314, 57);
            this.filterFirstnamePanel.TabIndex = 31;
            // 
            // filterFirstnameTextbox
            // 
            this.filterFirstnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.filterFirstnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterFirstnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterFirstnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFirstnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterFirstnameTextbox.Location = new System.Drawing.Point(15, 15);
            this.filterFirstnameTextbox.MaxLength = 48;
            this.filterFirstnameTextbox.Name = "filterFirstnameTextbox";
            this.filterFirstnameTextbox.Size = new System.Drawing.Size(284, 28);
            this.filterFirstnameTextbox.TabIndex = 15;
            this.filterFirstnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.filterFirstnameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterTextbox_KeyUp);
            // 
            // filterLastnamePanel
            // 
            this.filterLastnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.filterLastnamePanel.Controls.Add(this.filterLastnameTextbox);
            this.filterLastnamePanel.Location = new System.Drawing.Point(135, 255);
            this.filterLastnamePanel.Name = "filterLastnamePanel";
            this.filterLastnamePanel.Padding = new System.Windows.Forms.Padding(15);
            this.filterLastnamePanel.Size = new System.Drawing.Size(314, 57);
            this.filterLastnamePanel.TabIndex = 30;
            // 
            // filterLastnameTextbox
            // 
            this.filterLastnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.filterLastnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterLastnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterLastnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLastnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterLastnameTextbox.Location = new System.Drawing.Point(15, 15);
            this.filterLastnameTextbox.MaxLength = 48;
            this.filterLastnameTextbox.Name = "filterLastnameTextbox";
            this.filterLastnameTextbox.Size = new System.Drawing.Size(284, 28);
            this.filterLastnameTextbox.TabIndex = 15;
            this.filterLastnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.filterLastnameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterTextbox_KeyUp);
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emailPanel.Controls.Add(this.emailTextbox);
            this.emailPanel.Location = new System.Drawing.Point(500, 599);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.emailPanel.Size = new System.Drawing.Size(642, 80);
            this.emailPanel.TabIndex = 32;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextbox.Location = new System.Drawing.Point(17, 20);
            this.emailTextbox.MaxLength = 48;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(608, 46);
            this.emailTextbox.TabIndex = 15;
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.usernamePanel.Controls.Add(this.usernameTextbox);
            this.usernamePanel.Location = new System.Drawing.Point(495, 463);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.usernamePanel.Size = new System.Drawing.Size(642, 80);
            this.usernamePanel.TabIndex = 31;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextbox.Location = new System.Drawing.Point(17, 20);
            this.usernameTextbox.MaxLength = 48;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(608, 46);
            this.usernameTextbox.TabIndex = 15;
            // 
            // lastnamePanel
            // 
            this.lastnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lastnamePanel.Controls.Add(this.lastnameTextbox);
            this.lastnamePanel.Location = new System.Drawing.Point(495, 327);
            this.lastnamePanel.Name = "lastnamePanel";
            this.lastnamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.lastnamePanel.Size = new System.Drawing.Size(647, 80);
            this.lastnamePanel.TabIndex = 30;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lastnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastnameTextbox.Location = new System.Drawing.Point(17, 20);
            this.lastnameTextbox.MaxLength = 48;
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(613, 46);
            this.lastnameTextbox.TabIndex = 15;
            this.lastnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // firstnamePanel
            // 
            this.firstnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.firstnamePanel.Controls.Add(this.firstnameTextbox);
            this.firstnamePanel.Location = new System.Drawing.Point(495, 200);
            this.firstnamePanel.Name = "firstnamePanel";
            this.firstnamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.firstnamePanel.Size = new System.Drawing.Size(647, 80);
            this.firstnamePanel.TabIndex = 29;
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.firstnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstnameTextbox.Location = new System.Drawing.Point(17, 20);
            this.firstnameTextbox.MaxLength = 48;
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(613, 46);
            this.firstnameTextbox.TabIndex = 15;
            this.firstnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // showClientsButton
            // 
            this.showClientsButton.BackColor = System.Drawing.Color.Silver;
            this.showClientsButton.FlatAppearance.BorderSize = 0;
            this.showClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showClientsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showClientsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showClientsButton.Location = new System.Drawing.Point(971, 821);
            this.showClientsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showClientsButton.Name = "showClientsButton";
            this.showClientsButton.Size = new System.Drawing.Size(216, 70);
            this.showClientsButton.TabIndex = 27;
            this.showClientsButton.Text = "Show Clients";
            this.showClientsButton.UseVisualStyleBackColor = false;
            this.showClientsButton.Click += new System.EventHandler(this.showClientsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightPink;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.Location = new System.Drawing.Point(992, 709);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 70);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.Location = new System.Drawing.Point(747, 709);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 70);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.Location = new System.Drawing.Point(495, 709);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 70);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1200, 905);
            this.Controls.Add(this.filterIdPanel);
            this.Controls.Add(this.filterFirstnamePanel);
            this.Controls.Add(this.filterLastnamePanel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.lastnamePanel);
            this.Controls.Add(this.firstnamePanel);
            this.Controls.Add(this.showClientsButton);
            this.Controls.Add(this.filterIdLabel);
            this.Controls.Add(this.filterFirstnameLabel);
            this.Controls.Add(this.filterLastnameLabel);
            this.Controls.Add(this.separatorPanel);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.clientsListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 905);
            this.MinimumSize = new System.Drawing.Size(1200, 905);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientsForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientsForm_MouseUp);
            this.filterIdPanel.ResumeLayout(false);
            this.filterIdPanel.PerformLayout();
            this.filterFirstnamePanel.ResumeLayout(false);
            this.filterFirstnamePanel.PerformLayout();
            this.filterLastnamePanel.ResumeLayout(false);
            this.filterLastnamePanel.PerformLayout();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.lastnamePanel.ResumeLayout(false);
            this.lastnamePanel.PerformLayout();
            this.firstnamePanel.ResumeLayout(false);
            this.firstnamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientsListbox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private RoundedButton deleteButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Panel separatorPanel;
        private System.Windows.Forms.Label filterLastnameLabel;
        private System.Windows.Forms.Label filterFirstnameLabel;
        private System.Windows.Forms.Label filterIdLabel;
        private RoundedButton showClientsButton;
        private RoundedPanel firstnamePanel;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private RoundedButton clearButton;
        private RoundedButton saveButton;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private RoundedPanel lastnamePanel;
        private RoundedPanel usernamePanel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private RoundedPanel emailPanel;
        private System.Windows.Forms.TextBox emailTextbox;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private RoundedPanel filterLastnamePanel;
        private System.Windows.Forms.TextBox filterLastnameTextbox;
        private RoundedPanel filterFirstnamePanel;
        private System.Windows.Forms.TextBox filterFirstnameTextbox;
        private RoundedPanel filterIdPanel;
        private System.Windows.Forms.TextBox filterIdTextbox;
    }
}