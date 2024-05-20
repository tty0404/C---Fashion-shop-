using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICT711_Day5_classes;

namespace ICT711_Day9_Forms
{
    public partial class CustomersForm : Form
    {
        public Store Store { get; set; }
        Customer selectedCustomer = null;
        public CustomersForm()
        {
            InitializeComponent();

        }
        class SaleView
        {
            public int Id; public DateTime Date { get; set; }
            public decimal Total { get; set; }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Get the current customer Object
            selectedCustomer = (Customer)((DataGridView)sender).CurrentRow.DataBoundItem;
            if (selectedCustomer is null) return;   // Make sure there is a current selection
            associateNameLbl.Text = selectedCustomer.GetAssociate(Store.Associates);

            // Get the current user purchases and convert the list to SaleView type
            List<SaleView> ss = selectedCustomer.GetPurchases(Store.Sales).ConvertAll(s =>
                new SaleView
                {
                    Id = s.Id,
                    Date = s.Date,
                    Total = s.GetTotal()
                });
            // Connect the SaleView list to dataGridView2
            dataGridView2.DataSource = ss;
        }

        private void eStore_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            // Connect the customers list to dataGridView1
            dataGridView1.DataSource = Store.Customers.ConvertAll(c => (Customer)c);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var salev = (SaleView)grid.Rows[e.RowIndex].DataBoundItem;
                Sale sale = (Sale)Store.Sales.Find(s => s.Id == salev.Id);

                SaleForm sf = new SaleForm();
                sf.Tag = sale;
                sf.Store = Store;
                sf.Show();

                //MessageBox.Show($"{sale.Id}: ${sale.Date}", "Sale");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryForm iff = new InventoryForm();
            iff.ShowDialog();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            // Create the new form
            myNewForm nf = new myNewForm();
            // Give it one value
            if (selectedCustomer is null) return;
            // Get the associate ID for the current customer
            int associateID = selectedCustomer.MainAssociateId;
            // Get the associate information
            Associate associate = (Associate)Store.Associates.Find(a => a.AssociateId == associateID);

            //nf.Tag = associate;
            nf.MyAssociate = associate;

            // Show the new form
            var r = nf.ShowDialog();
            // Read the result of the form
            if (r == DialogResult.OK)
                MessageBox.Show(nf.MyAssociate.FName, "Results");
            if (r == DialogResult.Cancel)
                MessageBox.Show("It is Cancel", "Results");
        }

        private void associateNameLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedCustomer is null) return;
            // Get the associate ID for the current customer
            int associateID = selectedCustomer.MainAssociateId;
            // Get the associate information
            Associate associate = (Associate)Store.Associates.Find(a => a.AssociateId == associateID);
            //Show the associate data
            //MessageBox.Show($"{associate.AssociateId}:{associate.GetFullName()}, " +
            //    $"{associate.Department}\n{associate.Email}, {associate.Tel}", "Customer Associate");
            AssociateForms associateform = new AssociateForms();
            associateform.Tag = associate;
            var r = associateform.ShowDialog();

            if (r == DialogResult.OK)
            {
                MessageBox.Show("Ok, " + associateform.Tag.ToString());
            }
            else
                MessageBox.Show("Cancel");
        }
    }
}
