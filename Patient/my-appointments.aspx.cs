using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Patient_my_appointments : System.Web.UI.Page
{
    mydb db = new mydb();
    string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Patient"] == null)
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
        st = "Select * from Appointment where PatientId=" + Session["Patient"] + "";
        db.fill_rptr_ret_sqlda(st, Repeater1);
        if (Repeater1.Items.Count > 0)
            owner_pnl.Visible = true;
        else
            owner_pnl.Visible = false;

    }
    protected void lnk_delete_Click(object sender, EventArgs e)
    {
        LinkButton lnk = sender as LinkButton;
        st = "delete from Appointment where PatientId="+Session["Patient"]+" and id=" + lnk.CommandArgument;
        db.ExeQuery(st);
        fill_repeater();
    }
}