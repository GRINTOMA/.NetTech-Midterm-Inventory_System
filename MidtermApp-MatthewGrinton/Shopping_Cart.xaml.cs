using System.Collections.Generic;
using System.Windows;

namespace MidtermApp_MatthewGrinton
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public OrderItem SelectedItem;
        public Window1()
        {
            InitializeComponent();

            if (MainWindow.order.ToArray().Length > 0)
            {
                this.SelectedItem = MainWindow.order.ToArray()[0];
                Total.Text = getCartTotal().ToString();
            }
            Cart.ItemsSource = MainWindow.order;
        }
        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            var main = (MainWindow)Tag;
            main.Show();
            Close();
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
        private double getCartTotal()
        {
            double total = 0;
            foreach(OrderItem o in MainWindow.order.ToArray())
            {
                total += o.totalPrice * o.quantity;
            }
            return total; 
        }

        private void Cart_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.SelectedItem = (OrderItem)Cart.SelectedItem;
            Cost.Text = this.SelectedItem.price.ToString();
        }
    }
}
