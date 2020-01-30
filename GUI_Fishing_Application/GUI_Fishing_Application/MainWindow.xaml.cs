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
        Fish_inventory fishy_inv = new Fish_inventory();
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // This line sets the data source for the grid.
            // It will use a different enumerable (here, fishy_inv) as data for the grid,
            // instead of requiring you to update the grid and your inventory separately.
            DataGrid_log.ItemsSource = fishy_inv.inventory;
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

        private void Button_fish_Click(object sender, RoutedEventArgs e)
        {
            // We only add fish to the inventory and rely in DataGrid_log.ItemsSource
            // from earlier to set it to the right value
            fishy_inv.add_fish();

            // However it only checks if the data source contains new items on first draw
            // meaning it will not update data when you don't change the tab
            // in which case we have to trigger a manual refresh
            DataGrid_log.Items.Refresh();
        }
    }
}
