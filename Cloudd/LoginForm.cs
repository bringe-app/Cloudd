using Cloudd.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cloudd
{

    public partial class LoginForm : Form
    {
        private bool m_mousedown = false;
        private Point m_lastLocation;
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
            if (username == string.Empty || passText == string.Empty)
            {
                MessageBox.Show("Fill all mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string encryptedPass = Program.GetSha2Hash(passText);
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            foreach (Client client in clientArr)
            {
                if (client.m_username == username)
                {
                    if (client.m_password != encryptedPass)
                    {
                        MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Successfully logged in, moving to clients page", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        new ClientsForm().ShowDialog();
                        Close();
                    }
                }
            }
            MessageBox.Show($"Failed to find user \"{username}\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ActiveControl = signUpButton; // it'll focus on the first textbox by default otherwise
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_mousedown = true;
            m_lastLocation = e.Location;
        }
        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_mousedown = false;
        }
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
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
            Hide();
            new SignUpForm().ShowDialog();
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
