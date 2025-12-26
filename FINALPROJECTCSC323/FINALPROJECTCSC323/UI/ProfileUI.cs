using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECTCSC323;

using FINALPROJECTCSC323.NewFolder;

public partial class ProfileUI : Form
{
    private CUSTOMER customer;

    public ProfileUI(CUSTOMER customer)
    {
        InitializeComponent();
        this.customer = customer;

        lblFirstName.Text = $"First Name: {customer.FirstName}";
        lblLastName.Text = $"Last Name: {customer.LastName}";
        lblEmail.Text = $"Email: {customer.Email}";
        lblPhone.Text = $"Phone: {customer.PhoneNumber}";
        lblAddress.Text = $"Address: {customer.Address.GetFullAddress()}";

        if (customer.Orders != null && customer.Orders.Any())
        {
            int count = 1;
            foreach (var order in customer.Orders)
            {
                lstOrders.Items.Add($"Order {count} - {order.OrderDate.ToShortDateString()} - {order.OrderStatus}");
                count++;
            }
        }
        else
        {
            lstOrders.Items.Add("No orders found.");
        }

    }
    private void ProfileUI_Load(object sender, EventArgs e)
    {

    }

    private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lstOrders_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void lstOrders_Click(object sender, EventArgs e)
    {
        int selectedIndex = lstOrders.SelectedIndex;

        if (selectedIndex >= 0 && selectedIndex < customer.Orders.Count)
        {
            var selectedOrder = customer.Orders[selectedIndex];
            var invoice = selectedOrder.Invoice?.printinvoice()?.ToString();

            if (!string.IsNullOrWhiteSpace(invoice))
            {
                MessageBox.Show(invoice, "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}