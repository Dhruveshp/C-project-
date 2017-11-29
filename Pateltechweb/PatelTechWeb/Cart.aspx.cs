using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;



public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     //  TextBox1.Text = (string)Request.QueryString["itemid"];
      //  TextBox2.Text = (string)Request.QueryString["qty"];


        ArrayList prods = new ArrayList();
        ArrayList qtys = new ArrayList();

        prods = (ArrayList)Session["cartprod"];
        qtys = (ArrayList)Session["cartqty"];
;      

        
       
            // ==================== 

            SqlDataSource ds = new SqlDataSource();

            string sqlstatement = "SELECT ROW_NUMBER() over(order by itemid) as ROWNUM, itemid, itemname,  saleprice, 0 as QTY_ORDER, 0 as LineTotal  FROM [item] ";

            if (prods.Count > 1)
            {
                sqlstatement = sqlstatement + " WHERE itemid = " + prods[0].ToString();
                for (int i = 1; i < prods.Count; i++)
                {
                    sqlstatement = sqlstatement + " OR itemid = " + prods[i].ToString();
                }
            }
            else
            {
                sqlstatement = sqlstatement + "WHERE itemid = " + prods[0].ToString();
            }
            ds.SelectCommand = sqlstatement;

            ds.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["pateltechConnectionString2"].ConnectionString;

            ds.DataBind();

            GridView1.DataSource = ds;
            GridView1.DataBind();

        for (int i = 0; i < qtys.Count; i++)
        {
            GridView1.Rows[i].Cells[5].Text = qtys[i].ToString();
        }

        decimal salesprice;
        int qtypur=0;
        decimal linetotresult = 0;
        decimal basket_total = 0;
        int qty_total = 0;

        // Populate Line Totals and Accumulate Basket Total
        for (int i = 0; i < prods.Count; i++)
        {
            salesprice = Decimal.Parse(GridView1.Rows[i].Cells[4].Text);
            qtypur = Int16.Parse(GridView1.Rows[i].Cells[5].Text);
            linetotresult = salesprice * qtypur;
            qty_total = (int)qty_total + qtypur;
            basket_total = basket_total + linetotresult;
            GridView1.Rows[i].Cells[6].Text = linetotresult.ToString("C", CultureInfo.CurrentCulture);
        }
        // Provide Summary
        GridView1.FooterRow.Cells[4].Text = "Totals";
        GridView1.FooterRow.Cells[4].HorizontalAlign = HorizontalAlign.Right;
        GridView1.FooterRow.Cells[5].Text = qty_total.ToString();
        GridView1.FooterRow.Cells[6].Text = basket_total.ToString("C", CultureInfo.CurrentCulture);    
    }   
   
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ArrayList prods = new ArrayList();
        ArrayList qty = new ArrayList();

        prods = (ArrayList)Session["cartprod"];
        qty = (ArrayList)Session["cartqty"];

        prods.RemoveAt(e.RowIndex);
        qty.RemoveAt(e.RowIndex);

        Session["cartprod"] = (ArrayList)prods;
        Session["cartqty"] = (ArrayList)qty;

        Response.Redirect("cart.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ArrayList prods = new ArrayList();
        ArrayList qty = new ArrayList();
        prods = (ArrayList)Session["cartprod"];
        qty = (ArrayList)Session["cartqty"];

        string custid = Context.User.Identity.Name;

        if (custid != "")
        {
            DateTime currdatetime = DateTime.Now;
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["pateltechConnectionString2"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string insert_cmd = "insert into Sale(custid, itemid, saleprice, saledate, saleqty) values(@custid, @itemid, @saleprice, @saledate, @saleqty)";


       try
        {
            conn.Open();
            for (int i = 0; i <= prods.Count; i++)
            {
                SqlCommand icmd = new SqlCommand(insert_cmd, conn);
                icmd.Parameters.AddWithValue("@custid", custid);
                icmd.Parameters.AddWithValue("@itemid", prods[i]);
                icmd.Parameters.AddWithValue("@saleprice", Decimal.Parse(GridView1.Rows[i].Cells[5].Text));
                icmd.Parameters.AddWithValue("@saledate", currdatetime);
                icmd.Parameters.AddWithValue("@saleqty", qty[i]);
                icmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            string error = ex.Message;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('DB Save Problem');", true);
        }
        finally
        { conn.Close(); }

        Session["cartprod"] = new ArrayList();
        Session["cartqty"] = new ArrayList();

        Response.Redirect("confirm.aspx");

        }

        else
        { Response.Redirect("Account/Login"); }

    }
}

