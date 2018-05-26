using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Doctor_View_appointments : System.Web.UI.Page
{
    mydb db = new mydb();
    string st = "";
    DataTable dt = new DataTable();
    SqlCommand cm;
    SqlDataAdapter sqlda;
    DataSet ds;
   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Doctor"] == null)
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
        st = "Select * from Appointment where DoctId="+Session["Doctor"]+"";
        db.fill_rptr_ret_sqlda(st, Repeater1);
        if (Repeater1.Items.Count > 0)
            owner_pnl.Visible = true;
        else
            owner_pnl.Visible = false;

    }
    protected void proceed_Click(object sender, EventArgs e)
    {
        LinkButton lnk=sender as LinkButton;
        st = "delete from Appointment where PatientId=" + lnk.CommandArgument;
        db.ExeQuery(st);
        Response.Redirect("treatment.aspx?pid=" + lnk.CommandArgument + "&did=" + Session["doctor"] + "");
    
    }
    
}