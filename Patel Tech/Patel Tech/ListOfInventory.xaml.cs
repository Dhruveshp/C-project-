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
using System.Windows.Shapes;

namespace Patel_Tech
{
    /// <summary>
    /// Interaction logic for ListOfInventory.xaml
    /// </summary>
    public partial class ListOfInventory : Window
    {
        public ListOfInventory()
        {
            InitializeComponent();
        }

        private void InventoryWindow_Loaded(object sender, RoutedEventArgs e)
        {
            pateltechDataSet dataset = new pateltechDataSet();

            
            pateltechDataSetTableAdapters.itemTableAdapter adapter = new pateltechDataSetTableAdapters.itemTableAdapter();

            adapter.Fill(dataset.item);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.item.DefaultView;
        }
    }
}
