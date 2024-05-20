using ICT711_Day5_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT711_Day9_Forms
{
    public partial class StoreForm : Form
    {
        Store store;
        public StoreForm()
        {
            InitializeComponent();
            // Instantiate the store object
            Store.StoreFileName = "../../../Data/store_data.json";
            store = Store.CreateStore();

            // Modify the data file locations- they are static properties so we can access them using the class name
            // "../../../" means go 3 folders up from the exe location. 
            // "../../../Data" means go up 3 folders then inside Data folder
            Store.AssociatesFileName = "../../../Data/associates_data.json";
            Store.CustomersFileName = "../../../Data/customers_data.json";
            Store.InventoryFileName = "../../../Data/inventory_data.json";
            Store.SalesFileName = "../../../Data/sales_data.json";
            Store.StoreFileName = "../../../Data/store_data.json";

            // Supply the Store object to the Binding Source 
            storeBindingSource.DataSource = store;
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            // Create a new Object of the Customer form
            var customers = new CustomersForm();
            // Pass a reference to the store object
            customers.Store = store;
            // Show the customer form in a Modal way (can't access the current form before you close the Dialog form)
            customers.Show();

            //customers.Show();   // Shows the form, but you still can access the calling form
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            store.LoadCustomers();
            store.LoadAssociates();
            store.LoadSales();
            store.LoadInventory();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Save all data
            store.SaveCustomers();
            store.SaveAssociates();
            store.SaveInventory();
            store.SaveSales();
            store.SaveStoreInfo();
        }

        private void StoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var r = MessageBox.Show("Are you sure you want to close the form?",
                "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.No)    // To cancel closing
                e.Cancel = true;
        }

       
    }
}
