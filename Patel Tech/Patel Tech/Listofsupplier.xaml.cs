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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Patel_Tech
{
    /// <summary>
    /// Interaction logic for Listofsupplier.xaml
    /// </summary>
    public partial class Listofsupplier : Window
    {
        public Listofsupplier()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pateltechDataSet dataset = new pateltechDataSet();

            // use a table adapter to populate the Supplier table
            pateltechDataSetTableAdapters.SupplierTableAdapter adapter = new pateltechDataSetTableAdapters.SupplierTableAdapter();

            adapter.Fill(dataset.Supplier);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Supplier.DefaultView;

        }
    }
}
