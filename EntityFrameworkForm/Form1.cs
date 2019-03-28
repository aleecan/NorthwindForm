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
    public partial class Form1 : BaseForm
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("İSİM", 150);
            listView1.Columns.Add("ŞİRKET ADI", 200);
            listView1.Columns.Add("ŞEHİR", 50);
            listView1.Columns.Add("ÜLKE", 150);
            getCustomersList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCustomersList();
        }

        private void getCustomersList()
        {
            var customers = service.GetCustomers();
            string[] list = new string[7];
            ListViewItem itm;
            for (var item = 0; item < customers.Count; item++)
            {
                list[0] = customers[item].ContactName;
                list[1] = customers[item].CompanyName;
                list[2] = customers[item].City;
                list[3] = customers[item].Country;
                itm = new ListViewItem(list);
                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 150);
            var hist = service.GetCustomerHist(customerIdText.Text);
            textBox1.Text = "";
            foreach (var item in hist)
            {
                textBox1.AppendText(string.Format("Ürün : {0} - Adet : {1} \n\r",item.ProductName,item.Total));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            //var item = listView1.SelectedItems[0];
            var myColumnData = item;
            MessageBox.Show(myColumnData.SubItems[0].Text + " | " + myColumnData.SubItems[1].Text + " | " + myColumnData.SubItems[2].Text + " | " + myColumnData.SubItems[3].Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }
    }
}
