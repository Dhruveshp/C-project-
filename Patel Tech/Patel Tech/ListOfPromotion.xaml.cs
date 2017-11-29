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
    /// Interaction logic for ListOfPromotion.xaml
    /// </summary>
    public partial class ListOfPromotion : Window
    {
        public ListOfPromotion()
        {
            InitializeComponent();
        }

        private void listPromotionWindow_loaded(object sender, RoutedEventArgs e)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            
            pateltechDataSetTableAdapters.PromotionTableAdapter adapter = new pateltechDataSetTableAdapters.PromotionTableAdapter();

            adapter.Fill(dataset.Promotion);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Promotion.DefaultView;
        }
    }
}
