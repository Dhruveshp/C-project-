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
    /// Interaction logic for AddNewPromotion.xaml
    /// </summary>
    public partial class AddNewPromotion : Window
    {
        public AddNewPromotion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            datamgmt appcomp = new datamgmt();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtPromoName.Text;
            strinput[1] = txtPromoitem.Text;
            strinput[2] = txtPromoStart.Text;
            strinput[3] = txtPromoend.Text;
           

            nbrinput = 4;

            retval = appcomp.showData(strinput, nbrinput, "newPromotion");
        }
    }
}
