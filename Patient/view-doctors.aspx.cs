using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Patient_view_doctors : System.Web.UI.Page
{
    mydb db = new mydb();
    string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Patient"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
        else
        {
            fill_repeater();  
        }
         
    }
    protected void fill_repeater()
    {
        st = "select * from doctor";
        db.fill_rptr_ret_sqlda(st, Repeater1);
        if (Repeater1.Items.Count > 0)
            owner_pnl.Visible = true;
        else
            owner_pnl.Visible = false;

    }
}