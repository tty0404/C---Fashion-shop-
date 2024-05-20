using ICT711_Day5_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ICT711_Day9_Forms
{
    public partial class SaleForm : Form
    {
        public Store Store { get; set; }
        public SaleForm()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            Sale sale = (Sale)Tag;
            dataGridView1.DataSource =  sale.ProductsList;
            customerLbl.Text = Store.Customers.Find( c => 
                c.CustomerId == sale.CustomerId )
                    .GetFullName();

            //associateCombobox.Items.AddRange(
            //    Store.Associates.Select( 
            //        a => a.GetFullName()+","+a.AssociateId.ToString() ).ToArray()
            //    );
            associateCombobox.DataSource = Store.Associates.ConvertAll(a => (Associate)a);
            associateCombobox.DisplayMember = "FName";
            associateCombobox.ValueMember = "AssociateId"; 
            associateCombobox.SelectedItem = Store.Associates.Find(a => a.AssociateId == sale.AssociateId);


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Store.SaveSales();
        }

        private void associateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sale sale = (Sale)Tag;
        // is operator checks if the object can be casted to the given data type, and cast it to the given variable
        // Returns false if it can't cast it.
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast
            // Read more here: 
            if (((ListControl)sender).SelectedValue is int id) {
               sale.AssociateId = id;
            }
        }
    }
}
