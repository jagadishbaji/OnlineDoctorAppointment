using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Doctor_treatment : System.Web.UI.Page
{
    mydb db = new mydb();
    string st = "";
    DataTable dt = new DataTable();
    SqlCommand cm;
    SqlDataAdapter sqlda;
    DataSet ds;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["doctor"] == null)
        {
            Response.Redirect("../login.aspx");

        }
        else
        {
            fill_details();
        }

    }
    public void fill_details()
    { 
       st="select * from patient where id="+Request.QueryString["pid"].ToString()+"";
       dt = db.get_datatable(st);
       if (dt.Rows.Count > 0)
       {
           txt_name.Text = dt.Rows[0]["name"].ToString();
           txt_emailid.Text = dt.Rows[0]["email"].ToString();
           txt_mobile.Text = dt.Rows[0]["mobile"].ToString();
           txt_qual.Text = dt.Rows[0]["gender"].ToString();
       }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        st = "insert into treatment values(" + Request.QueryString["pid"].ToString() + "," + Request.QueryString["did"].ToString() + ",'" + txt_name.Text + "','" + txt_emailid.Text + "','" + txt_qual.Text + "','" + dd_spl.Text + "',"+txt_mobile.Text+",'" + txt_desc.Text + "')";
        int x = db.ExeQuery(st);
        if (x > 0)
        {
            Response.Write("<script>alert('Submitted ...')</script>");
        }
        else
        {
            Response.Write("<script>alert('failed ...')</script>");
        }
    }
}