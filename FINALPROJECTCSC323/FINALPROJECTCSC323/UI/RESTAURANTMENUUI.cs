using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FINALPROJECTCSC323;

using FINALPROJECTCSC323.CLASSES;
using FINALPROJECTCSC323.NewFolder;

public partial class RESTAURANTMENUUI : Form
{
    private RESTAURANT? selectedRestaurant;
    public CART? cart = new CART();
    public CUSTOMER? dummyCustomer;
    private INOTIFICATION? notification;
    private IDELIVERY? deliveryoption;

    public RESTAURANTMENUUI(RESTAURANT restaurant, CUSTOMER customer)
    {
        InitializeComponent();
        selectedRestaurant = restaurant;
        dummyCustomer = customer;

        Text = selectedRestaurant.RestaurantName + " Menu";
        cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

        upDownQuantity.SelectedIndex = 0;
        lblTotal.Text = "Total: $0.00";
        pnlConfirmOrder.Visible = false;

        cmbPaymentMethod.Items.AddRange(Enum.GetNames(typeof(PAYMENTMETHOD)));
        cmbNotification.Items.AddRange(new string[] { "SMS", "Email" });
        cmbDiscount.Items.AddRange(new string[] { "0%", "5%", "10%" });
        cmbdelivery.Items.AddRange(new string[] { "Standard", "Express" });


        cmbDiscount.SelectedIndex = 0;
        cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;

        this.Controls.Add(cmbDiscount);

    }




    private void RESTAURANTMENUUI_Load(object sender, EventArgs e)
    {
        cmbCategory.Items.Clear();
        foreach (var category in selectedRestaurant.Menu.MenuCategories)
        {
            cmbCategory.Items.Add(category.MenuCategoryName);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmbMenuItem.Items.Clear();

        MENUCATEGORY selectedCategory = selectedRestaurant.Menu.MenuCategories
            .FirstOrDefault(cat => cat.MenuCategoryName == cmbCategory.SelectedItem.ToString());

        if (selectedCategory != null)
        {
            foreach (var item in selectedCategory.MenuItems)
            {
                cmbMenuItem.Items.Add($"{item.MenuItemName} - ${item.Price}");
            }
        }
    }

    private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (cmbCategory.SelectedItem == null || cmbMenuItem.SelectedItem == null)
        {
            MessageBox.Show("Please select a category and a menu item.");
            return;
        }

        
        string? selectedItemText = cmbMenuItem.SelectedItem.ToString();
        string? itemName = selectedItemText.Split('-')[0].Trim();

        
        MENUITEM? selectedItem = null;
        foreach (var cat in selectedRestaurant.Menu.MenuCategories)
        {
            selectedItem = cat.MenuItems.FirstOrDefault(i => i.MenuItemName == itemName);
            if (selectedItem != null) break;
        }

        if (selectedItem == null)
        {
            MessageBox.Show("Item not found.");
            return;
        }

        
        if (!int.TryParse(upDownQuantity.Text, out int quantity) || quantity <= 0)
        {
            MessageBox.Show("Please enter a valid quantity.");
            return;
        }

        
        ORDERDETAIL detail = new ORDERDETAIL(selectedItem, quantity);
        cart.AddItem(detail);
        AddCartItemToPanel(detail);
        UpdateTotal();
        UpdateDiscountedTotal();

        MessageBox.Show($"{quantity} x {selectedItem.MenuItemName} added to cart.");
    }

    List<Button> btnRemoves= new List<Button>();
    private void AddCartItemToPanel(ORDERDETAIL orderDetail)
    {
        Panel panel = new Panel();
        panel.Width = flowCartItems.Width - 25;
        panel.Height = 40;
        panel.BorderStyle = BorderStyle.FixedSingle;

        Label lbl = new Label();
        lbl.Text = $"{orderDetail.item.MenuItemName}  {orderDetail.Quantity} - ${orderDetail.Subtotal}";
        lbl.AutoSize = true;
        lbl.Location = new Point(10, 10);

        Button btnRemove = new Button();
        btnRemoves.Add(btnRemove);
        btnRemove.Text = "Remove";
        btnRemove.AutoSize = true;
        btnRemove.Location = new Point(panel.Width - 80, 5);
        btnRemove.Click += (s, e) =>
        {
            cart.RemoveItem(orderDetail);
            flowCartItems.Controls.Remove(panel);
            btnRemoves.Add(btnRemove);
            UpdateTotal();
            UpdateDiscountedTotal();
        };

        panel.Controls.Add(lbl);
        panel.Controls.Add(btnRemove);

        flowCartItems.Controls.Add(panel);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    public decimal total;
    private void UpdateTotal()
    {

        total = 0;
        foreach (var item in cart.Order.OrderDetails)
        {
            total += item.Subtotal;
        }

        lblTotal.Text = $"Total: ${total}";
    }

    private void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        if (cart.Order.OrderDetails.Count == 0)
        {
            MessageBox.Show("Your cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        
        cmbCategory.Enabled = false;
        cmbMenuItem.Enabled = false;
        cmbDiscount.Enabled = false;
        btnAdd.Enabled = false;
        upDownQuantity.Enabled = false;

        foreach(Button btnRemove in btnRemoves)
        {
            btnRemove.Enabled=false;
        }





        pnlConfirmOrder.Visible = true;
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void btnConfirmOrder_Click(object sender, EventArgs e)
    {
        if (cmbPaymentMethod.SelectedItem == null || cmbNotification.SelectedItem == null)
        {
            MessageBox.Show("Please select a payment method and notification type.");
            return;
        }

        PAYMENTMETHOD selectedPayment = (PAYMENTMETHOD)Enum.Parse(typeof(PAYMENTMETHOD), cmbPaymentMethod.SelectedItem.ToString());

        cart.Order.ApplyDiscount(discountPercentage);

        if (cmbNotification.SelectedItem.ToString() == "Email")
            notification = new EMAILNOTIFICATION();
        else
            notification = new SMSNOTIFICATION();

        if (cmbdelivery.SelectedItem.ToString() == "Standard")
            deliveryoption = new STANDARDDELIVERY();
        else
            deliveryoption = new EXPRESSDELIVERY();

        cart.Order.SetDelivery(deliveryoption);

        
        cart.PlaceOrder(dummyCustomer, selectedRestaurant, selectedPayment, notification);

        MessageBox.Show("Order placed successfully!");

        pnlConfirmOrder.Visible = false;
        
        this.Hide();
        Deliveryui statusForm = new Deliveryui();
        statusForm.ShowDialog();
        this.Close();
    }

    private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateDiscountedTotal();
    }

    public decimal discountPercentage;
    private void UpdateDiscountedTotal()
    {
        if (cmbDiscount.SelectedItem == null)
            return;

        string selected = cmbDiscount.SelectedItem.ToString();
        discountPercentage = 0;

        if (selected == "5%") discountPercentage = 0.05m;
        else if (selected == "10%") discountPercentage = 0.10m;

        decimal totalAmount = total; 
        decimal discountedAmount = totalAmount * (1 - discountPercentage);

        lblDiscountedTotal.Text = $"Discounted Total: ${discountedAmount:0.00}";
    }

    private void cmbMenuItem_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        
        cmbCategory.Enabled = true;
        cmbMenuItem.Enabled = true;
        cmbDiscount.Enabled = true;
        btnAdd.Enabled = true;
        upDownQuantity.Enabled = true;

        foreach (Button btnRemove in btnRemoves)
        {
            btnRemove.Enabled = true;
        }


        pnlConfirmOrder.Visible = false;
       
    }
}



