using DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkForm
{
    public partial class Form2 : BaseForm
    {
        
        public Form2()
        {
            InitializeComponent();
            checkButtonEnable();
        }

        private void checkButtonEnable()
        {
            if (nameTextBox.Text.Length > 0 && companyTextBox.Text.Length > 0 && cityTextBox.Text.Length > 0 && countryTextBox.Text.Length > 0)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextChangedEvent(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void companyTextChangedEvent(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void countryTextChangedEvent(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void cityTextChangedEvent(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && companyTextBox.Text.Length > 0 && cityTextBox.Text.Length > 0 && companyTextBox.Text.Length > 0)
            {
                Customer customer = new Customer();
                customer.City = cityTextBox.Text;
                customer.CompanyName = companyTextBox.Text;
                customer.ContactName = nameTextBox.Text;
                customer.Country = countryTextBox.Text;
                service.SaveCustomer(customer);
                
                nameTextBox.Text = "";
                companyTextBox.Text = "";
                cityTextBox.Text = "";
                countryTextBox.Text = "";
                MessageBox.Show("Saved");
            }
            else {
                saveButton.Enabled = false;
            }
        }
    }
}
