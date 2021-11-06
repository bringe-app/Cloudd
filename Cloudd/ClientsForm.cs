using Cloudd.BL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class ClientsForm : Form
    {
        private Point m_lastLocation;
        private bool m_mousedown;

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

        private ClientArr clientArr = new ClientArr();
        private bool m_made_changes = false;

        private void ClientToForm(Client client)
        {
            idNumberLabel.Text = "#" + client.m_id.ToString();
            usernameTextbox.Text = client.m_username;
            firstnameTextbox.Text = client.m_firstname;
            lastnameTextbox.Text = client.m_lastname;
            emailTextbox.Text = client.m_email;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Client selectedClient = (Client)clientsListbox.SelectedItem;
            if (selectedClient == null)
            {
                MessageBox.Show("Client not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show($"Are you sure you want to delete client number {selectedClient.m_id}?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (selectedClient.Delete())
                {
                    clientArr = new ClientArr();
                    clientArr.Fill();
                    clientsListbox.DataSource = clientArr;
                    clientsListbox.Update();
                    MessageBox.Show("Successfully deleted client", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearButton_Click(sender, e);
                    m_made_changes = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstnameTextbox.Text = string.Empty;
            lastnameTextbox.Text = string.Empty;
            usernameTextbox.Text = string.Empty;
            emailTextbox.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!m_made_changes)
            {
                var result = MessageBox.Show("Your progress won't be saved, Exit anyway?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
                Close();
        }

        private void ListBoxFilter()
        {
            int id = 0;
            if (filterIdTextbox.Text != string.Empty)
                id = int.Parse(filterIdTextbox.Text);
            clientsListbox.DataSource = clientArr.Filter
                (id, filterFirstnameTextbox.Text, filterLastnameTextbox.Text);
            clientsListbox.Update();
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
                m_made_changes = true;
            }
            else
            {
                MessageBox.Show("Failed to update client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
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

        private void listBoxClients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm((Client)clientsListbox.SelectedItem);
        }

        private void showClientsButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($@"{Path.GetDirectoryName(Application.ExecutablePath)}\clients.csv");
        }

        private void ClientsForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_mousedown = true;
            m_lastLocation = e.Location;
        }
        private void ClientsForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_mousedown = false;
        }
        private void ClientsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_mousedown)
            {
                Location = new Point(
                 (Location.X - m_lastLocation.X) + e.X, (Location.Y - m_lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
