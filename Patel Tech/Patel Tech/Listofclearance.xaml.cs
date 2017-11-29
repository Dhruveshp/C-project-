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
    /// Interaction logic for Listofclearance.xaml
    /// </summary>
    public partial class Listofclearance : Window
    {
        public Listofclearance()
        {
            InitializeComponent();
        }

        private void clerancewindow_loaded(object sender, RoutedEventArgs e)
        {
            pateltechDataSet dataset = new pateltechDataSet();
           
            pateltechDataSetTableAdapters.ClearanceTableAdapter adapter = new pateltechDataSetTableAdapters.ClearanceTableAdapter();

            adapter.Fill(dataset.Clearance);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Clearance.DefaultView;
        }
    }
}
