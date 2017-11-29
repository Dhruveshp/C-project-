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
    /// Interaction logic for AddNewInventory.xaml
    /// </summary>
    public partial class AddNewInventory : Window
    {
        public AddNewInventory()
        {
            InitializeComponent();
        }
        private void Button_Click (object sender, RoutedEventArgs e)
        {
                int retval = 0;

               datamgmt appcomp = new datamgmt();

                 string[] strinput = new string[10];
                 int nbrinput = 0; 

                 

                  strinput[0] = txtProductId.Text;
                  strinput[1] = txtProductName.Text;
                  strinput[2] = txtDescription.Text;
                  strinput[3] = txtcost.Text;
                  strinput[4] = txtsellingprice.Text;
                  strinput[5] = txtStatuts.Text;
                  strinput[6] = txtpurchase.Text;
              //    strinput[7] = txtDescription.Text;
                 strinput[7] = txtsupplier_ID.Text; ;
                  strinput[8] = txtOrderId.Text;
                   strinput[9]  = txtGeneration.Text;


                      nbrinput = 10;

                  retval = appcomp.showData(strinput, nbrinput,"newInventory");         


        }
        
    }
}
