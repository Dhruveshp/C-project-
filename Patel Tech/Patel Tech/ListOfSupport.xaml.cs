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
    /// Interaction logic for ListOfSupport.xaml
    /// </summary>
    public partial class ListOfSupport : Window
    {
        public ListOfSupport()
        {
            InitializeComponent();
        }

        private void supplierwindow_Loaded(object sender, RoutedEventArgs e)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            
            pateltechDataSetTableAdapters.SupportTableAdapter adapter = new pateltechDataSetTableAdapters.SupportTableAdapter();

            adapter.Fill(dataset.Support);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Support.DefaultView;
        }
    }
}
