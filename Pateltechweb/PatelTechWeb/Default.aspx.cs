using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string label_text = "";

        if (chx_signupmail.Checked == true)
        { lbl_notice.Text =  "mailing list signup."; }
        else if (chx_signupmail.Checked == false)
        { lbl_notice.Text = " "; }

        if (personal_pc.Checked == true)
        { label_text = label_text + "Product chosen is PC "; }
        else if (laptop_note.Checked == true)
        { label_text = label_text + "Product chosen is Notebook and Laptop"; }

          lbl_notice.Text = label_text;
    }

    protected void btn_Catalog_Click(object sender, EventArgs e)
    {
        Response.Redirect("Catalog.aspx");
    }
}