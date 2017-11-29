using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace Patel_Tech
{
    class datamgmt
    {
        public int showData(string[] strargs, int intargs, string datatype)
        {

            string msgtxt = " ";

            for (int i = 0; i <= strargs.GetUpperBound(0); i++)
            { msgtxt = msgtxt + " " + strargs[i].ToString() + "\n"; };

            MessageBox.Show(msgtxt);

            if (datatype == "Support")
            {
                /** string supportfile = System.Configuration.ConfigurationManager.AppSettings["supportfile"];
                 StreamWriter sr = new StreamWriter(supportfile, true);
                 sr.WriteLine(msgtxt);
                 sr.Close();  **/

                int retval = 0;
                retval = addsupport(strargs, intargs);
            }
            else if(datatype == "Clearance")
            {
                /** string clearancefile = System.Configuration.ConfigurationManager.AppSettings["clearancefile"];
                 StreamWriter sr = new StreamWriter(clearancefile, true);
                 sr.WriteLine(msgtxt);
                 sr.Close(); **/
                int retval = 0;
                retval = addclearance(strargs, intargs);

            }
            else if (datatype == "Employee")
            {
                /** string employeefile = System.Configuration.ConfigurationManager.AppSettings["employeefile"];
                 StreamWriter sr = new StreamWriter(employeefile, true);
                 sr.WriteLine(msgtxt);
                 sr.Close();  **/
                int retval = 0;
                retval = addemployee(strargs, intargs);
            }
            else if (datatype == "newInventory")
            {
                /**string inventoryfile = System.Configuration.ConfigurationManager.AppSettings["inventoryfile"];
                   StreamWriter sr = new StreamWriter(inventoryfile, true);
                    sr.WriteLine(msgtxt);
                    sr.Close();  

                int retval = 0;
                retval = AddNewInventory(strargs, intargs);
                 **/
                int retval = 0;
                retval = addnewitem(strargs, intargs);
            }
            else if (datatype == "newPromotion")
            {
              /**  string promotionfile = System.Configuration.ConfigurationManager.AppSettings["promotionfile"];
                StreamWriter sr = new StreamWriter(promotionfile, true);
                sr.WriteLine(msgtxt);
                sr.Close();  **/
                int retval = 0;
                retval = addnewPromotion(strargs, intargs);
            }
            else if (datatype == "newSupplier")
            {
                /** string supplierfile = System.Configuration.ConfigurationManager.AppSettings["supplierfile"];
                 StreamWriter sr = new StreamWriter(supplierfile, true);
                 sr.WriteLine(msgtxt);
                 sr.Close(); **/
     
                int retval = 0;
                retval = addSupplier(strargs, intargs); 
            }
            else
            {
                string productfile = System.Configuration.ConfigurationManager.AppSettings["productfile"];
                StreamWriter sr = new StreamWriter(productfile, true);
                sr.WriteLine(msgtxt);
                sr.Close();
            }
            return 0;
        }

        private int addemployee(string[] strargs, int intargs)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            // use a table adapter to populate the  table
            pateltechDataSetTableAdapters.EmployeeTableAdapter employee = new pateltechDataSetTableAdapters.EmployeeTableAdapter();
            employee.Insert(strargs[0], strargs[1], strargs[2], strargs[3]);
            return 1;            
        }

        private int addclearance(string[] strargs, int intargs)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            // use a table adapter to populate the  table
            pateltechDataSetTableAdapters.ClearanceTableAdapter clerance = new pateltechDataSetTableAdapters.ClearanceTableAdapter();
            clerance.Insert(int.Parse(strargs[0]), strargs[1], strargs[2], strargs[3], double.Parse(strargs[4]), int.Parse(strargs[5]), int.Parse(strargs[6]));
            return 1;
        }

        private int addsupport(string[] strargs, int intargs)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            // use a table adapter to populate the  table
            pateltechDataSetTableAdapters.SupportTableAdapter support = new pateltechDataSetTableAdapters.SupportTableAdapter();
            support.Insert(int.Parse(strargs[0]), strargs[1], strargs[2], strargs[3]);
            return 1;
        }

        private int addnewPromotion(string[] strargs, int intargs)
        {
            pateltechDataSet dataset = new pateltechDataSet();
            // use a table adapter to populate the  table
            pateltechDataSetTableAdapters.PromotionTableAdapter support = new pateltechDataSetTableAdapters.PromotionTableAdapter();
           support.Insert(int.Parse(strargs[0]), strargs[1], strargs[2], strargs[3], strargs[4]);
            return 1;
        }

        private int addSupplier(string[] strargs, int intargs)
        {
            string connectionString;
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Patel_Tech.Properties.Settings.pateltechConnectionString"].ConnectionString;

            string insertSQL;
            insertSQL = "INSERT INTO Supplier (";
            insertSQL += "supplierid, companyname, website, ";
            insertSQL += "phone, fax) ";
            insertSQL += "VALUES (";
            insertSQL += "@supplierid, @companyname, @website, ";
            insertSQL += "@phone, @fax)";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertSQL, con);

            // Add the parameters.
            cmd.Parameters.AddWithValue("@supplierid", strargs[0]);
            cmd.Parameters.AddWithValue("@companyname", strargs[1]);
            cmd.Parameters.AddWithValue("@website", strargs[2]);
            cmd.Parameters.AddWithValue("@phone", strargs[3]);
            cmd.Parameters.AddWithValue("@fax", strargs[4]);

            // Try to open the database and execute the update.
            int added = 0;
            try
            {
                con.Open();
                added = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }

            return 1;
        }

        private int addnewitem(string[] strargs, int intargs)
        {
             pateltechDataSet dataset = new pateltechDataSet();
             // use a table adapter to populate the  table
             pateltechDataSetTableAdapters.itemTableAdapter item = new pateltechDataSetTableAdapters.itemTableAdapter();
            item.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2],Int16.Parse(strargs[3]), 
                Int16.Parse(strargs[5]),strargs[6], Int16.Parse(strargs[7]), Int16.Parse(strargs[8]),
                Int16.Parse(strargs[9]),strargs[10]);
             return 1;  
            
        }

    }

    

}
        
  

