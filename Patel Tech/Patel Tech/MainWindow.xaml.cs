using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.IO;


namespace Patel_Tech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewInventory addnewinventory = new AddNewInventory();
            addnewinventory.Show();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddSupport addsupport = new AddSupport();
            addsupport.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddClearance addclearance = new AddClearance();
            addclearance.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddEmployee addemployee = new AddEmployee();
            addemployee.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AddNewSuplier addnewsupplier = new AddNewSuplier();
            addnewsupplier.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddNewPromotion addnewpromotion = new AddNewPromotion ();
            addnewpromotion.Show();
        }

        private void btn_testfile_Click(object sender, RoutedEventArgs e)
        {
            string filename = System.Configuration.ConfigurationManager.AppSettings["datafile"];
            string line = "";

            StreamReader sr = new StreamReader(filename);
            while ((line = sr.ReadLine()) != null)
            {
                System.Windows.Forms.MessageBox.Show(line);
            }
            sr.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Listofsupplier listofsupplier = new Listofsupplier();
            listofsupplier.Show();
        }

        private void listEmployeebtton_Click(object sender, RoutedEventArgs e)
        {
            listofEmployee listofemployee = new listofEmployee();
            listofemployee.Show();
        }

        private void listofInventorybttn_Click(object sender, RoutedEventArgs e)
        {
            ListOfInventory listofinventory = new ListOfInventory();
            listofinventory.Show();
        }

        private void listClerancebttn_Click(object sender, RoutedEventArgs e)
        {
            Listofclearance listofclearace = new Listofclearance();
            listofclearace.Show();
        }
                
        private void listofsupportbttn_Click_1(object sender, RoutedEventArgs e)
        {
            ListOfSupport listofsupport = new ListOfSupport();
            listofsupport.Show();
        }

        private void listofPrmotionbttn_Click(object sender, RoutedEventArgs e)
        {
            ListOfPromotion listofpromotion = new ListOfPromotion();
            listofpromotion.Show();
        }
    }
}
