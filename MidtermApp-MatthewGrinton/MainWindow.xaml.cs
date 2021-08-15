using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MidtermApp_MatthewGrinton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    enum Type
    {
        Electronics,
        Books,
        Media
    }

    
    public partial class MainWindow : Window
    {
        public static List<Product> products = new List<Product>();
        public static List<String> types = new List<String>();
        public  static Stack<OrderItem> order = new Stack<OrderItem>();

        public MainWindow()
        {
            InitializeComponent();
            PopulateList(products, types);
            Product_Type.ItemsSource = types;

        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = Search_Bar.Text;
            var search = from product in products
                         where product.name == searchText
                         select product;
            string displayName = "name", displayDescription = "description", displayType = "Electronics";
            double displayPrice = 50;
            foreach (var item in search)
            {
                displayName = item.name;
                displayDescription = item.description;
                displayPrice = item.price;
                displayType = item.productType;
            }
            Product_Description.Text = "Product Name: " + displayName + "\n" +
                  "Product Description: " + displayDescription;

            Product_Type.Text = displayType;

            Price.Text = "" + displayPrice;
        }
        private void purchaseButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = Search_Bar.Text;
            var search = from product in products
                         where product.name == searchText
                         select product;
            string displayName = "name", displayDescription = "description", displayType = "Electronics";
            double displayPrice = 50;
            foreach (var item in search)
            {
                displayName = item.name;
                displayDescription = item.description;
                displayPrice = item.price;
                displayType = item.productType;
            }
            if (Quantity.IsChecked == true)
            {
                if ((bool)(Sale.IsChecked == true))
                {
                    OrderItem o = new OrderItem(displayName, displayDescription, displayPrice, displayType, double.Parse(Order.Text), (displayPrice/2), true);
                    order.Push(o);
                }
                else
                {
                    OrderItem o = new OrderItem(displayName, displayDescription, displayPrice, displayType, double.Parse(Order.Text), double.Parse(Price.Text), false);
                    order.Push(o);
                }
            }
            else if (Total_Amount.IsChecked == true)
            {
                if ((bool)(Sale.IsChecked == true))
                {
                    double grandTotal = double.Parse(Order.Text), price = double.Parse(Price.Text);
                    double quantity = grandTotal / price;
                    OrderItem o = new OrderItem(displayName, displayDescription, displayPrice, displayType, Math.Floor(quantity), (displayPrice/2), true);
                    order.Push(o);
                }
                else
                {
                    double grandTotal = double.Parse(Order.Text), price = double.Parse(Price.Text);
                    double quantity = grandTotal / price;
                    OrderItem o = new OrderItem(displayName, displayDescription, displayPrice, displayType, Math.Floor(quantity), double.Parse(Price.Text), false);
                    order.Push(o);
                }
            }
            else
            {
                MessageBox.Show("Please pick either Quantity, or Total $ Amount");
            }
        }
        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Owner = this;
            window.Tag = this;
            this.Visibility = Visibility.Collapsed;
            window.Show();

        }
        private void Sale_Checked(object sender, RoutedEventArgs e)
        {
            double sale = double.Parse(Price.Text) / 2;
            Price.Text = "" + sale;
        }
        private void Sale_Unchecked(object sender, RoutedEventArgs e)
        {
            double sale = double.Parse(Price.Text) * 2;
            Price.Text = "" + sale;
        }
        private void PopulateList(List<Product> p, List<String> t)
        {
            Type e = Type.Electronics;
            Type b = Type.Books;
            Type m = Type.Media;
            Product p1 = new Product("iPad", "Tablet", "Electronics");
            Product p2 = new Product("Ides of March", "Historical Fiction", "Books");
            Product p3 = new Product("Avengers: Endgame", "Drama", "Media");
            Electronic_Price_Generator(p1);
            Book_Price_Generator(p2);
            Media_Price_Generator(p3);

            p.Add(p1);
            p.Add(p2);
            p.Add(p3);

            t.Add(Enum.GetName(typeof(Type), e));
            t.Add(Enum.GetName(typeof(Type), b));
            t.Add(Enum.GetName(typeof(Type), m));
        }


        public static void Electronic_Price_Generator(Product p1)
        {
            Random r1 = new Random();
            p1.price = r1.Next(1500, 5000);
        }
        public static void Book_Price_Generator(Product p1)
        {
            Random r1 = new Random();
            p1.price = r1.Next(15, 50);
        }
        public static void Media_Price_Generator(Product p1)
        {
            Random r1 = new Random();
            p1.price = r1.Next(100, 500);
        }
        private void AppExit_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void Admin_Pannel_View(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Owner = this;
            window.Tag = this;
            this.Visibility = Visibility.Collapsed;
            window.Show();
        }
    }

}
