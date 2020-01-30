using cs_Fish_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_Fishing_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Fish_inventory fishy_inv = new Fish_inventory();
            //CollectionViewSource fishy_CollectionViewSource;
            //fishy_CollectionViewSource = (CollectionViewSource)(FindResource("Fish_CollectionViewSource"));
            //fishy_CollectionViewSource.Source = Fish_inventory.inventory;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            Button_inventory.Visibility = Visibility.Visible;
            Button_log.Visibility = Visibility.Collapsed;
            DataGrid_log.Visibility = Visibility.Visible;
            Inventory_grid.Visibility = Visibility.Collapsed;
            Log_controller.Visibility = Visibility.Visible;
        }
        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            Button_inventory.Visibility = Visibility.Collapsed;
            Button_log.Visibility = Visibility.Visible;
            DataGrid_log.Visibility = Visibility.Collapsed;
            Inventory_grid.Visibility = Visibility.Visible;
            Log_controller.Visibility = Visibility.Collapsed;
        }

        private void Pick_bait_Click(object sender, RoutedEventArgs e)
        {
            Button_fish.Visibility = Visibility.Hidden;
            Button_inventory.Visibility = Visibility.Hidden;
            Button_log.Visibility = Visibility.Hidden;
            Button_technique.Visibility = Visibility.Hidden;
            Button_sell_fish.Visibility = Visibility.Hidden;
            Log_border.Visibility = Visibility.Hidden;
            Fish_caught.Visibility = Visibility.Hidden;
            Money.Visibility = Visibility.Hidden;
            Fish_caught_label.Visibility = Visibility.Hidden;
            Money_label.Visibility = Visibility.Hidden;

            Technique_label.Visibility = Visibility.Visible;
            Bait_border.Visibility = Visibility.Visible;
            Bait_grid.Visibility = Visibility.Visible;
            Button_return.Visibility = Visibility.Visible;
            Log_controller.Visibility = Visibility.Hidden;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Button_fish.Visibility = Visibility.Visible;
            Button_inventory.Visibility = Visibility.Hidden;
            Button_log.Visibility = Visibility.Visible;
            Button_technique.Visibility = Visibility.Visible;
            Button_sell_fish.Visibility = Visibility.Visible;
            Log_border.Visibility = Visibility.Visible;
            Fish_caught.Visibility = Visibility.Visible;
            Money.Visibility = Visibility.Visible;
            Fish_caught_label.Visibility = Visibility.Visible;
            Money_label.Visibility = Visibility.Visible;
            Inventory_grid.Visibility = Visibility.Visible;
            Technique_label.Visibility = Visibility.Hidden;
            Bait_border.Visibility = Visibility.Hidden;
            Bait_grid.Visibility = Visibility.Hidden;
            Button_return.Visibility = Visibility.Hidden;
        }

        private void Sell_fish_Click(object sender, RoutedEventArgs e)
        {
             // Made it accessible from having public classes + making the inventory list and Fish class static
        }
        
        Fish_inventory fishy_inv = new Fish_inventory();
        Fish fishy;

        private void Button_fish_Click(object sender, RoutedEventArgs e)
        {
            fishy_inv.add_fish();
            DataGrid_log.Items.Add(new Fish(fishy.get_type(), fishy.get_value()));

            // Using a foreach (Fish fishy in Fish_inventory.inventory) returns type & value
        }
    }
}
