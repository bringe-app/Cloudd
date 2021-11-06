using Cloudd.BL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class ClientsForm : Form
    {
        private bool _mousedown;
        private Point _lastLocation;
        private ClientArr clientArr = new ClientArr();
        private bool _madeChanges = false;

        public ClientsForm()
        {
            InitializeComponent();

            foreach (Control controls in Controls)
                Program.AddFont("PayPalSansBig-Regular", controls);

            ActiveControl = firstnameTextbox;

            Region = Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 40, 40));

            clientArr.Fill();
            clientsListbox.DataSource = clientArr;
            clientsListbox.DisplayMember = string.Empty;
        }

        private void ClientToForm(Client client)
        {
            idNumberLabel.Text = "#" + client._id.ToString();
            usernameTextbox.Text = client._username;
            firstnameTextbox.Text = client._firstname;
            lastnameTextbox.Text = client._lastname;
            emailTextbox.Text = client._email;
        }

        private void listBoxClients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm((Client)clientsListbox.SelectedItem);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Client selectedClient = (Client)clientsListbox.SelectedItem;

            if (selectedClient == null)
            {
                MessageBox.Show("Select a clien first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show($"Delete client #{selectedClient._id}? {selectedClient._username}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (selectedClient.Delete())
                {
                    clientArr = new ClientArr();
                    clientArr.Fill();
                    clientsListbox.DataSource = clientArr;
                    clientsListbox.Update();
                    MessageBox.Show($"Client #{selectedClient._id}? {selectedClient._username} has been deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearButton_Click(sender, e);
                    _madeChanges = true;
                }
                else
                    MessageBox.Show($"Client #{selectedClient._id}? {selectedClient._username} hasn't been deleted succesfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstnameTextbox.Text = string.Empty;
            lastnameTextbox.Text = string.Empty;
            usernameTextbox.Text = string.Empty;
            emailTextbox.Text = string.Empty;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string errorMsg = "In order to update you have to fill all fields correctly";
            Client selectedClient = (Client)clientsListbox.SelectedItem;
            string firstname = firstnameTextbox.Text;

            if (firstname == string.Empty)
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string lastname = lastnameTextbox.Text;
            if (lastname == string.Empty)
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string username = usernameTextbox.Text;
            if (username == string.Empty)
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string email = emailTextbox.Text;
            if (email == string.Empty || !Program.IsEmailAddrValid(email))
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (selectedClient.Update(firstname, lastname, username, email))
            {
                MessageBox.Show("Successfully updated client", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientArr = new ClientArr();
                clientArr.Fill();
                clientsListbox.DataSource = clientArr;
                clientsListbox.Update();
                _madeChanges = true;
            }
            else
            {
                MessageBox.Show("Failed to update client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }
        private void showClientsButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($@"{Path.GetDirectoryName(Application.ExecutablePath)}\clients.csv");
        }

        private void ListBoxFilter()
        {
            int id = 0;

            if (filterIdTextbox.Text != string.Empty)
                id = int.Parse(filterIdTextbox.Text);

            clientsListbox.DataSource = clientArr.Filter(id, filterFirstnameTextbox.Text, filterLastnameTextbox.Text);

            clientsListbox.Update();
        }
        private void filterIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void filterTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            ListBoxFilter();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IsInputValid(e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!_madeChanges)
            {
                DialogResult result = MessageBox.Show("Youre chhanges haven't been saved", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Close();
            }
            else
                Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ClientsForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            _lastLocation = e.Location;
        }
        private void ClientsForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }
        private void ClientsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                Location = new Point(
                 (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);
                Update();
            }
        }
    }
}
