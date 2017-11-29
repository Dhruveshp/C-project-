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
    /// Interaction logic for AddClearance.xaml
    /// </summary>
    public partial class AddClearance : Window
    {
        public AddClearance()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            datamgmt appcomp = new datamgmt();

            string[] strinput = new string[7];
            int nbrinput = 0;

            strinput[0] = txtClearanceId.Text;
            strinput[1] = txtItemName.Text;
             strinput[2] = clearanceDescription.Text;
            strinput[3] = txtActuallyCost.Text;
            strinput[4] = txtClearancePrice.Text;
            strinput[5] = txtsupplier.Text;
            strinput[6] = txtOrderId.Text;

            nbrinput = 7;

            retval = appcomp.showData(strinput, nbrinput,"Clearance");

        }
    }
}
