using Cloudd.BL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class CityForm : Form
    {
        private CityArr cityArr = new CityArr();
        private readonly ClientArr clientArr = new ClientArr();
        private bool _mousedown = false;
        private Point _lastLocation;
        private bool _hasMadeChanges;

        public CityForm()
        {
            InitializeComponent();

            foreach (Control controls in Controls)
                Program.AddFont("PayPalSansBig-Regular", controls);

            ActiveControl = cityNameTextBox;

            Region = Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 40, 40));

            CityArrToForm();
            clientArr.Fill();
        }
        private void CityArrToForm(City city = null)
        {
            cityArr = new CityArr();
            cityArr.Fill();
            citiesListBox.DataSource = cityArr;
            citiesListBox.DisplayMember = "Name";
            citiesListBox.ValueMember = "Id";
            if (city != null)
                citiesListBox.SelectedValue = city.Id;
            citiesListBox.Update();
        }

        private void citiesListbox_DoubleClick(object sender, EventArgs e)
        {
            cityNameTextBox.Text = (citiesListBox.SelectedItem as City).Name;
            idNumberLabel.Text = "#" + (citiesListBox.SelectedItem as City).Id.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cityNameTextBox.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            City selectedCity = (City)citiesListBox.SelectedItem;

            if (selectedCity == null)
            {
                MessageBox.Show("City not selected", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clientArr.DoesExist(selectedCity))
            {
                MessageBox.Show("Can't delete a city that's related to a client",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete city number { selectedCity.Id }?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (selectedCity.Delete())
                {
                    CityArrToForm();

                    MessageBox.Show("Successfully deleted city", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearButton_Click(sender, e);
                    _hasMadeChanges = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete city", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            City selectedCity = (City)citiesListBox.SelectedItem;
            string name = cityNameTextBox.Text;

            if (name == string.Empty)
            {
                MessageBox.Show("In order to update you have to fill all fields correctly",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cityArr.IsContains(name))
            {
                MessageBox.Show("A city with that name already exists",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (selectedCity.Update(name))
            {
                MessageBox.Show("Successfully updated city", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CityArrToForm();
                _hasMadeChanges = true;
            }
            else
            {
                MessageBox.Show("Failed to update city", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!_hasMadeChanges)
            {
              DialogResult result = MessageBox.Show("Your progress won't be saved, Exit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cityNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCity_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            _lastLocation = e.Location;
        }
        private void FormCity_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }
        private void FormCity_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                Location = new Point(Location.X - _lastLocation.X + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void showCitiesButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($@"{Path.GetDirectoryName(Application.ExecutablePath)}\cities.csv");
        }

        private void textBox_cityname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
