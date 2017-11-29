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
    /// Interaction logic for listofEmployee.xaml
    /// </summary>
    public partial class listofEmployee : Window
    {
        public listofEmployee()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            
            pateltechDataSetTableAdapters.EmployeeTableAdapter adapter = new pateltechDataSetTableAdapters.EmployeeTableAdapter();

            adapter.Fill(dataset.Employee);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Employee.DefaultView;

        }
    }
}
