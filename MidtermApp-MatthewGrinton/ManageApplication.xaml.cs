using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MidtermApp_MatthewGrinton
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Product SelectedProduct;
        public List<Product> DeletionQueue = new List<Product>();
        public Window2()
        {
            InitializeComponent();
            Product_List1.ItemsSource = MainWindow.products;
            Product_List.ItemsSource = MainWindow.products;
        }
        private void Add_Product_Button_Click(object sender, RoutedEventArgs e)
        {
            string n = Product_Name.Text, d = Product_Description.Text, t = Product_Type.Text;
            Product p = new Product(n, d, t);
            if(t == "Electronics" || t == "electronics")
            {
                MainWindow.Electronic_Price_Generator(p);
                MainWindow.products.Add(p);
            }
            else if(t == "Books" || t == "books")
            {
                MainWindow.Book_Price_Generator(p);
                MainWindow.products.Add(p);
            }
            else
            {
                MainWindow.Media_Price_Generator(p);
                MainWindow.products.Add(p);
            }
            Product_List1.Items.Refresh();
            Product_Name.Text = "";
            Product_Description.Text = "";
            Product_Type.Text = "";
        }
        private void Update_Product_Click(object sender, RoutedEventArgs e)
        {
           
            string name = Product_Name_Update.Text;
            var update = from product in MainWindow.products
                         where product.name == name
                         select product;
            foreach (var item in update)
            {
                item.name = Product_Name_Update.Text;
                item.description = Product_Description_Update.Text;
                item.price = double.Parse(Product_Cost_Update.Text);
                item.productType = Product_Type_Update.Text;
            }
            Product_List1.Items.Refresh();
            Product_List.Items.Refresh();
        }
        private void Add_Queue_Clicked(object sender, RoutedEventArgs e)
        {
            DeletionQueue.Add((Product)Product_View.SelectedItem);
        }
        private void Delete_Product_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var item in DeletionQueue)
            {
                MainWindow.products.Remove(item);
            }
            Product_List1.Items.Refresh();
            Product_List.Items.Refresh();
            DeletionQueue.Clear();
        }
        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            string searchText = Product_Search_Delete.Text;
            var search = from product in MainWindow.products
                         where product.name == searchText
                         select product;
            Product_View.ItemsSource = search;
            Product_View.Items.Refresh();
        }
        private void Close_Button_Update_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Close_Button_Add_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Close_Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Product_List_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Product p1 = (Product)Product_List.SelectedItem;
            Product_Name_Update.Text = p1.name.ToString();
            Product_Description_Update.Text = p1.description.ToString();
            Product_Cost_Update.Text = p1.price.ToString();
            Product_Type_Update.Text = p1.productType.ToString();
        }

        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Product_List1.Items.Refresh();
            Product_List.Items.Refresh();
        }

    
    }
}
