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
    /// Interaction logic for AddNewSuplier.xaml
    /// </summary>
    public partial class AddNewSuplier : Window
    {
        public AddNewSuplier()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            datamgmt appcomp = new datamgmt();

            string[] strinput = new string[6];
            int nbrinput = 0;

            strinput[0] = txtSupplierId.Text;
            strinput[1] = txtCompanyName.Text;
            strinput[2] = txtWebsite.Text;
            strinput[3] = txtEmail.Text;
            strinput[4] = txtPhone.Text;
            strinput[5] = txtFax.Text;

            nbrinput = 6;

            retval = appcomp.showData(strinput, nbrinput, "newSupplier");
        }
    }
}
