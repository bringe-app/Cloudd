using Cloudd.BL;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class SignUpForm : Form
    {
        private bool _mousedown;
        private Point _lastLocation;

        public SignUpForm()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                Program.AddFont("PayPalSansBig-Regular", control);

            ActiveControl = emailTextbox;

            Region = Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 40, 40));
        }

        private bool nameAlreadyUsed(string username)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            foreach (Client client in clientArr)
                if (client._username == username)
                    return true;

            return false;
        }
        private string CheckForm()
        {
            if (firstnameTextbox.Text.Length < 2)
                return "Your first name must be at least 2 characters long!";

            if (lastnameTextbox.Text.Length < 2)
                return "Your last name must be at least 2 characters long!";

            if (usernameTextbox.Text.Length < 2)
                return "Your username must be at least 2 characters long!";

            if (nameAlreadyUsed(usernameTextbox.Text))
                return $"{usernameTextbox.Text} is not available";

            if (new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})").IsMatch(passwordTextbox.Text))
                return "Password must be at least eight characters long with one lowercase letter, one uppercase letter and one digit.";
            
            if (!Program.IsEmailAddrValid(emailTextbox.Text))
                return "Email address is not valid!";

            if (genderComboBox.SelectedItem == null)
                return "Gender isn't selected";

            return string.Empty;

        }

        private string capitalizeInput(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
        private Client FormToClient()
        {
            string firstname = capitalizeInput(firstnameTextbox.Text);
            string lastname = capitalizeInput(lastnameTextbox.Text);
            string username = usernameTextbox.Text;
            string password = Program.GetSha2Hash(passwordTextbox.Text);
            string email = emailTextbox.Text;
            string gender = genderComboBox.SelectedItem.ToString();

            return new Client(firstname, lastname, username, password, email, gender);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string msg = CheckForm();

            if (msg != string.Empty)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = FormToClient();

            if (client.Insert())
                MessageBox.Show("Account's been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Account's hasn't been created succesfully, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Hide();
            new ClientsForm().ShowDialog();
            Close();
        }

        private void firstnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IsInputValid(e);
        }
        private void lastnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IsInputValid(e);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You account hasn't been saved", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SignUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            _lastLocation = e.Location;
        }
        private void SignUpForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }
        private void SignUpForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                Location = new Point(Location.X - _lastLocation.X + e.X, Location.Y - _lastLocation.Y + e.Y);
                Update();
            }
        }
    }
}
