using System.Windows.Forms;

namespace FINALPROJECTCSC323;

using FINALPROJECTCSC323.NewFolder;

public partial class DeliveryApp : Form
{
    private RESTAURANTMENUUI? openMenuForm;

    public MENUITEM Burger1 = new MENUITEM("Whopper", "Flame-grilled beef patty with fresh vegetables", 5.99m);
    public MENUITEM Burger2 = new MENUITEM("Double Cheeseburger", "Two beef patties with melted cheese", 6.49m);

    public MENUITEM Side1 = new MENUITEM("Fries", "Crispy golden fries", 2.49m);
    public MENUITEM Side2 = new MENUITEM("Onion Rings", "Battered and fried onion rings", 2.99m);

    public MENUITEM Drink1 = new MENUITEM("Coke", "Classic Coca-Cola", 1.49m);
    public MENUITEM Drink2 = new MENUITEM("Sprite", "Refreshing lemon-lime soda", 1.49m);

   
    public MENUITEM Sandwich1 = new MENUITEM("Chicken Sub", "Grilled chicken with lettuce and mayo", 6.99m);
    public MENUITEM Sandwich2 = new MENUITEM("Philly Steak", "Steak sandwich with cheese and onions", 7.99m);

    public MENUITEM Appetizer1 = new MENUITEM("Mozzarella Sticks", "Fried mozzarella with marinara sauce", 4.49m);
    public MENUITEM Appetizer2 = new MENUITEM("Wings", "Spicy buffalo wings", 5.49m);

    public MENUITEM Dessert1 = new MENUITEM("Brownie", "Rich chocolate brownie", 3.49m);
    public MENUITEM Dessert2 = new MENUITEM("Ice Cream", "Vanilla ice cream scoop", 2.99m);

    
    public MENUCATEGORY BurgerKingBurgers;
    public MENUCATEGORY BurgerKingSides;
    public MENUCATEGORY BurgerKingDrinks;

    
    public MENU BurgerKingMenu;
    public RESTAURANT BurgerKing;

    
    public MENUCATEGORY RoadsterSandwiches;
    public MENUCATEGORY RoadsterAppetizers;
    public MENUCATEGORY RoadsterDesserts;

    
    public MENU RoadsterMenu;
    public RESTAURANT Roadster;

    
    public List<RESTAURANT> Restaurants = new List<RESTAURANT>();



    public ADDRESS customerAddress = new ADDRESS("Lebanon", "Beirut", "Hamra Street", "1102");
    public CUSTOMER dummyCustomer = new CUSTOMER("Layla", "Karam", "layla.karam@example.com", "+961 70 123 456");



    public DeliveryApp()
    {
        InitializeComponent();

        BurgerKingBurgers = new MENUCATEGORY("Burgers", new List<MENUITEM> { Burger1, Burger2 });
        BurgerKingSides = new MENUCATEGORY("Sides", new List<MENUITEM> { Side1, Side2 });
        BurgerKingDrinks = new MENUCATEGORY("Drinks", new List<MENUITEM> { Drink1, Drink2 });

       
        BurgerKingMenu = new MENU("Burger King Menu", new List<MENUCATEGORY> { BurgerKingBurgers, BurgerKingSides, BurgerKingDrinks });
        BurgerKing = new RESTAURANT("Burger King", BurgerKingMenu);

       
        RoadsterSandwiches = new MENUCATEGORY("Sandwiches", new List<MENUITEM> { Sandwich1, Sandwich2 });
        RoadsterAppetizers = new MENUCATEGORY("Appetizers", new List<MENUITEM> { Appetizer1, Appetizer2 });
        RoadsterDesserts = new MENUCATEGORY("Desserts", new List<MENUITEM> { Dessert1, Dessert2 });

     
        RoadsterMenu = new MENU("Roadster Menu", new List<MENUCATEGORY> { RoadsterSandwiches, RoadsterAppetizers, RoadsterDesserts });
        Roadster = new RESTAURANT("Roadster Diner", RoadsterMenu);

    
        Restaurants.Add(BurgerKing);
        Restaurants.Add(Roadster);

        dummyCustomer.Address = customerAddress;

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void restaurantsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        restaurantsToolStripMenuItem.DropDownItems.Clear();

        
        foreach (RESTAURANT r in Restaurants)
        {
            ToolStripMenuItem? item = new ToolStripMenuItem(r.RestaurantName);
            item.Click += RestaurantsItem_Click; 
            restaurantsToolStripMenuItem.DropDownItems.Add(item);
        }
    }

    private void RestaurantsItem_Click(object sender, EventArgs e)
    {
        ToolStripMenuItem? clicked = sender as ToolStripMenuItem;
        string? restaurantName = clicked.Text;

        RESTAURANT? selectedRestaurant = Restaurants.FirstOrDefault(r => r.RestaurantName == restaurantName);

        if (selectedRestaurant != null && openMenuForm == null)
        {
            openMenuForm = new RESTAURANTMENUUI(selectedRestaurant, dummyCustomer);
            openMenuForm.FormClosed += (s, args) => openMenuForm = null;

            
            openMenuForm.WindowState = FormWindowState.Maximized;
            openMenuForm.FormBorderStyle = FormBorderStyle.None;
            openMenuForm.StartPosition = FormStartPosition.CenterScreen;

            openMenuForm.ShowDialog();
        }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void profileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProfileUI profileForm = new ProfileUI(dummyCustomer);
        profileForm.ShowDialog();
    }
}



