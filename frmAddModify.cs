using MMABooks.EF.models.datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMABooks.EF
{
    public partial class frmAddModify : Form
    {
        public Customer customer { get; set; }
        public bool isAdd { get; set; }
        public List<State> states { get; set; }
        public frmAddModify()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void setCustomerObject()
        {
            if (isAdd) { 
            customer = new Customer();
            }
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.ZipCode = txtZIPCode.Text;
            customer.Name = txtName.Text;
            customer.State = cbState.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                setCustomerObject();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            cbState.DataSource = states;
            cbState.DisplayMember = "StateName";
            cbState.ValueMember = "StateCode";

            if (isAdd)
            {
                this.Text = "Add Customer";
                cbState.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Update Customer";
                displayCustomer();
            }
        }

        private void displayCustomer()
        {
            txtName.Text = customer.Name.ToString();
            txtAddress.Text = customer.Address.ToString();
            txtCity.Text = customer.City.ToString();
            cbState.SelectedValue = customer.State;
            txtZIPCode.Text = customer.ZipCode.ToString();
        }

        private bool isValid()
        {
            int errorCount = 0;
            string errorMsg = "";

            if (txtName.Text.Length <= 0)
            {
                errorCount++;
                errorMsg += "Name is not valid.\r\n";
            }

            if (txtAddress.Text.Length <= 0)
            {
                errorCount++;
                errorMsg += "Address is not valid. \r\n";
            }

            if (txtCity.Text.Length <= 0)
            {
                errorCount++;
                errorMsg += "City is not valid. \r\n";
            }

            if (txtZIPCode.Text.Length <= 0)
            {
                errorCount++;
                errorMsg += "ZIP Code is not valid. \r\n";
            }

            if (cbState.SelectedIndex == -1)
            {
                errorCount++;
                errorMsg += "Select a state. \r\n";
            }

            if (errorCount > 0)
            {
                MessageBox.Show(errorMsg);
                return false;
            }

            return true;
        }
    }
}
