using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // List to Hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();



        public Form1()
        {
            InitializeComponent();
        }


        // The GetPhoneData method
        // as an argument It assigns the Data enetered by the 
        // user to the objects properties
        private void GetPhoneData(CellPhone)
        {
            // Temporary variable
            decimal price;

            // Get the phone's brand.
            phone.Brand = brandTextBox.Text;

            // get the phone's model.
            phone.Model = modelTextBox.Text;

            // Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // display an error message.
                MessageBox.Show("Invaild Price");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone myPhone = new CellPhone();

            // Get the phone data
            GetPhoneData(myPhone);

            // Add the CellPhone object to the list.
            phoneList.Add(myPhone);

            // Add an entry to the list box.
            phoneListBox.Items.Add(myPhone.Brand + "" + myPhone.Model);

            // Clear the textbox controls
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            // reset the focus.
            brandTextBox.Focus();

            private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                // get the index of the selected item
                int index = phoneListBox.SelectedIndex;

                // display the selected items's price.
                MessageBox.Show(phoneList[index].Price.ToString("c"));

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
