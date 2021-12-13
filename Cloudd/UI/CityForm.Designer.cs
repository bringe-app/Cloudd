
namespace Cloudd
{
    partial class CityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            this.citiesListBox = new System.Windows.Forms.ListBox();
            this.cityNamePanel = new Cloudd.RoundedPanel(this.components);
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.saveButton = new Cloudd.RoundedButton(this.components);
            this.clearButton = new Cloudd.RoundedButton(this.components);
            this.deleteButton = new Cloudd.RoundedButton(this.components);
            this.showCitiesButton = new Cloudd.RoundedButton(this.components);
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.cityNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // citiesListBox
            // 
            this.citiesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.citiesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citiesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citiesListBox.FormattingEnabled = true;
            this.citiesListBox.IntegralHeight = false;
            this.citiesListBox.ItemHeight = 29;
            this.citiesListBox.Location = new System.Drawing.Point(48, 69);
            this.citiesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.citiesListBox.Name = "citiesListBox";
            this.citiesListBox.Size = new System.Drawing.Size(391, 551);
            this.citiesListBox.TabIndex = 0;
            this.citiesListBox.DoubleClick += new System.EventHandler(this.citiesListbox_DoubleClick);
            // 
            // cityNamePanel
            // 
            this.cityNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cityNamePanel.Controls.Add(this.cityNameTextBox);
            this.cityNamePanel.Location = new System.Drawing.Point(512, 355);
            this.cityNamePanel.Name = "cityNamePanel";
            this.cityNamePanel.Padding = new System.Windows.Forms.Padding(17, 20, 17, 17);
            this.cityNamePanel.Size = new System.Drawing.Size(642, 80);
            this.cityNamePanel.TabIndex = 33;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cityNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityNameTextBox.Location = new System.Drawing.Point(17, 20);
            this.cityNameTextBox.MaxLength = 48;
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(608, 46);
            this.cityNameTextBox.TabIndex = 15;
            this.cityNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityNameTextbox_KeyPress);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 2;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Black;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 70;
            this.minimizeButton.Location = new System.Drawing.Point(1006, 39);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(80, 54);
            this.minimizeButton.TabIndex = 35;
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
            this.exitButton.Location = new System.Drawing.Point(1092, 29);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(93, 74);
            this.exitButton.TabIndex = 34;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightPink;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.Location = new System.Drawing.Point(1006, 507);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 70);
            this.saveButton.TabIndex = 38;
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
            this.clearButton.Location = new System.Drawing.Point(761, 507);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 70);
            this.clearButton.TabIndex = 37;
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
            this.deleteButton.Location = new System.Drawing.Point(509, 507);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 70);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showCitiesButton
            // 
            this.showCitiesButton.BackColor = System.Drawing.Color.Silver;
            this.showCitiesButton.FlatAppearance.BorderSize = 0;
            this.showCitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCitiesButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCitiesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showCitiesButton.Location = new System.Drawing.Point(993, 609);
            this.showCitiesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showCitiesButton.Name = "showCitiesButton";
            this.showCitiesButton.Size = new System.Drawing.Size(216, 70);
            this.showCitiesButton.TabIndex = 39;
            this.showCitiesButton.Text = "Show Cities";
            this.showCitiesButton.UseVisualStyleBackColor = false;
            this.showCitiesButton.Click += new System.EventHandler(this.showCitiesButton_Click);
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityNameLabel.Location = new System.Drawing.Point(513, 315);
            this.cityNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(163, 37);
            this.cityNameLabel.TabIndex = 40;
            this.cityNameLabel.Text = "City name:";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idNumberLabel.Location = new System.Drawing.Point(573, 79);
            this.idNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(51, 37);
            this.idNumberLabel.TabIndex = 42;
            this.idNumberLabel.Text = "#0";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idLabel.Location = new System.Drawing.Point(513, 79);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(52, 37);
            this.idLabel.TabIndex = 41;
            this.idLabel.Text = "Id:";
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1220, 700);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cityNameLabel);
            this.Controls.Add(this.showCitiesButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cityNamePanel);
            this.Controls.Add(this.citiesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1220, 700);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1220, 700);
            this.Name = "CityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCity";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCity_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCity_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormCity_MouseUp);
            this.cityNamePanel.ResumeLayout(false);
            this.cityNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox citiesListBox;
        private RoundedPanel cityNamePanel;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private RoundedButton saveButton;
        private RoundedButton clearButton;
        private RoundedButton deleteButton;
        private RoundedButton showCitiesButton;
        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label idLabel;
    }
}