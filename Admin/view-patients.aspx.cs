using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Web.Security;
using System.Drawing;


public partial class Admin_view_patients : System.Web.UI.Page
{
    string st = "";
    string gender = "";
    mydb db = new mydb();
    SqlCommand cm;
    int x;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["admin"] == null)
        {
            Response.Redirect("../Default.aspx");
        }
        else
        {
            fill_repeater();
        }
    }
    protected void fill_repeater()
    {
        st = "select * from patient";
        db.fill_rptr_ret_sqlda(st, Repeater1);
        if (Repeater1.Items.Count > 0)
            owner_pnl.Visible = true;
        else
            owner_pnl.Visible = false;

    }
    protected void lnk_delete_Click(object sender, System.EventArgs e)
    {
        LinkButton lnk = sender as LinkButton;
        st = "delete from patient where id=" + lnk.CommandArgument;
        db.ExeQuery(st);
        fill_repeater();
    }
}