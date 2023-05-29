using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MMABooks.EF.models.datalayer;

namespace MMABooks.EF
{
    public partial class Form1 : Form
    {
        private MMABooksContext context = new MMABooksContext();
        private Customer customer = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCustID.Focus();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            int intCustID = -1;

            if (int.TryParse(txtCustID.Text, out intCustID) && intCustID > 0)
            {
                try
                {
                    customer = context.Customers.Find(intCustID);
                    if (customer != null)
                    {
                        if (!context.Entry(customer).Reference("StateNavigation").IsLoaded)
                            context.Entry(customer).Reference("StateNavigation").Load();

                        displayCustomer();
                    }
                    else
                    {
                        MessageBox.Show("No customer was found with ID: " + intCustID.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Introduce a valid customer ID.");
                txtCustID.Text = string.Empty;
                txtCustID.Focus();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayCustomer()
        {
            txtCustID.Text = customer.CustomerId.ToString();
            outputName.Text = customer.Name.ToString();
            outputAddress.Text = customer.Address.ToString();
            outputCity.Text = customer.City.ToString();
            outputState.Text = customer.State.ToString();
            outputZIPCode.Text = customer.ZipCode.ToString();
        }
        private void HandleDataError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;

            foreach (SqlError err in sqlException.Errors)
            {
                errorMessage += "Error code: " + err.Number + " " + errorMessage + "\r\n";

                MessageBox.Show(errorMessage);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModify frmAdd = new frmAddModify();

            frmAdd.isAdd = true;

            frmAdd.states = context.States.OrderBy(s => s.StateName).ToList();

            DialogResult result = frmAdd.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    customer = frmAdd.customer;
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    displayCustomer();
                }
                catch (DbUpdateException ex)
                {
                    HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void handleConcurrencyEx(DbUpdateConcurrencyException ex)
        {
            var state = context.Entry(customer).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Customer has been deleted by another user.");
                txtCustID.Text = string.Empty;
                outputAddress.Text = string.Empty;
                outputCity.Text = string.Empty;
                outputName.Text = string.Empty;
                outputZIPCode.Text = string.Empty;
                outputState.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Customer has been updated by another user.");
                context.Entry(customer).Reload();
                displayCustomer();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                frmAddModify frmAdd = new frmAddModify();

                frmAdd.isAdd = false;

                frmAdd.states = context.States.OrderBy(s => s.StateName).ToList();

                frmAdd.customer = customer;

                DialogResult result = frmAdd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    customer = frmAdd.customer;
                    try
                    {
                        context.SaveChanges();
                        displayCustomer();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        handleConcurrencyEx(ex);
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDataError(ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                    
                }

                else
                {

                }
            }
            else
            {
                MessageBox.Show("Select user.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(customer != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + customer.Name + "'s record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        context.Customers.Remove(customer);
                        context.SaveChanges();

                        txtCustID.Text = string.Empty;
                        outputAddress.Text = string.Empty;
                        outputCity.Text = string.Empty;
                        outputName.Text = string.Empty;
                        outputZIPCode.Text = string.Empty;
                        outputState.Text = string.Empty;
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        handleConcurrencyEx(ex);
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDataError(ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a user to delete.");
            }
        }
    }
}