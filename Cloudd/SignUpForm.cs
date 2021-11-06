using Cloudd.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class SignUpForm : Form
    {
        private Point m_lastLocation;
        private bool m_mousedown;

        public SignUpForm()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                Program.AddFont("PayPalSansBig-Regular", control);

            ActiveControl = emailTextbox;

            Region = Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 40, 40));

            IWin32Window h = FromHandle(Handle);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Your progress won't be saved, Exit anyway?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private bool nameAlreadyUsed(string username)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            foreach (Client client in clientArr)
            {
                if (client.m_username == username)
                {
                    return true;
                }
            }
            return false;
        }
        private string CheckForm()
        {
            // returns a string representing the error in the form or an empty string if success
            if (firstnameTextbox.Text.Length < 2)
                return "Your first name must be at least 2 characters long!";
            if (lastnameTextbox.Text.Length < 2)
                return "Your last name must be at least 2 characters long!";
            if (usernameTextbox.Text.Length < 2)
                return "Your username must be at least 2 characters long!";
            if (nameAlreadyUsed(usernameTextbox.Text))
                return $"Username \"{usernameTextbox.Text}\" is already used!";
            if (passwordTextbox.Text.Length < 8)
                return "Password must be at least 8 characters long!";
            if (!Program.IsEmailAddrValid(emailTextbox.Text))
                return "Email address is not valid!";
            if (genderComboBox.SelectedItem == null)
                return "Gender not selected";
            return string.Empty;

        }
        private string firstcharCapital(string text)
        {
            string firstchar = text.Substring(0, 1);
            firstchar.ToUpper();
            return firstchar + text.Substring(1);
        }
        private Client FormToClient()
        {
            string firstname = firstcharCapital(firstnameTextbox.Text);
            string lastname = firstcharCapital(lastnameTextbox.Text);
            string username = usernameTextbox.Text;
            string password = Program.GetSha2Hash(passwordTextbox.Text);
            string email = emailTextbox.Text;
            string gender = (string)genderComboBox.SelectedItem;
            return new Client(firstname, lastname, username, password, email, gender);

        }
        private void firstnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
                MessageBox.Show("First name should contain only characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void lastnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
                MessageBox.Show("Last name should contain only characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SignUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_mousedown = true;
            m_lastLocation = e.Location;
        }
        private void SignUpForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_mousedown = false;
        }
        private void SignUpForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_mousedown)
            {
                Location = new Point(
                 (Location.X - m_lastLocation.X) + e.X, (Location.Y - m_lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string errorMessage = CheckForm();
            if (errorMessage != string.Empty)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Client client = FormToClient();
            if (client.Insert())
            {
                MessageBox.Show("Successfully signed up, moving to clients page", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to sign up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hide();
            new ClientsForm().ShowDialog();
            Close();
        }

        private void seePasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextbox.Focus();

            if (seePasswordButton.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                seePasswordButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            else
                seePasswordButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

            passwordTextbox.UseSystemPasswordChar = !passwordTextbox.UseSystemPasswordChar;
        }
    }
}
