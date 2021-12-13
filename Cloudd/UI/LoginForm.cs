using Cloudd.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class LoginForm : Form
    {
        private bool _isMouseDown;
        private Point _formLocation;

        public LoginForm()
        {
            InitializeComponent();

            foreach (Control controls in Controls)
                Program.AddFont("PayPalSansBig-Regular", controls);

            ActiveControl = usernameTextbox;

            Region = Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 40, 40));
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string passText = passwordTextbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passText))
            {
                MessageBox.Show("One or more of the fields is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string encryptedPass = Program.GetSha2Hash(passText);

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            foreach (Client client in clientArr)
            {
                if (client._username == username)
                {
                    if (client._password != encryptedPass)
                    {
                        MessageBox.Show("The password that you've entered is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Successfully signed in to your account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Hide();
                        new ClientsForm().ShowDialog();
                        Close();
                    }
                }
            }

            MessageBox.Show($"User: {username} doesn't exist\nYou maybe typed it wrong, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            new SignUpForm().ShowDialog();
            Close();
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextbox.Focus();

            if (showPasswordButton.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                showPasswordButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            else
                showPasswordButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

            passwordTextbox.UseSystemPasswordChar = !passwordTextbox.UseSystemPasswordChar;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SignInForm_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _formLocation = e.Location;
        }
        private void SignInForm_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }
        private void SignInForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                Location = new Point(Location.X - _formLocation.X + e.X, (Location.Y - _formLocation.Y) + e.Y);
                Update();
            }
        }
    }
}
