using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Admin_dashboard : System.Web.UI.Page
{
    mydb db = new mydb();
    SqlCommand cm;
    SqlDataAdapter sqlda;
    DataTable dt;
  string count, coun;
    string cust, owners;
    DataSet ds;
  
    string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("../Default.aspx");
        }
        else
        {
            st = "select count(*) from doctor";
            dt = get_datatable(st);
            if (dt.Rows.Count > 0)
            {
                coun = dt.Rows[0][0].ToString();
            }
            Doc.Text = coun;
            st = "select count(*) from patient";
            dt = get_datatable(st);
            if (dt.Rows.Count > 0)
            {
                count = dt.Rows[0][0].ToString();
            }
            pat.Text = count;
        }
    }
    public DataTable get_datatable(string st)
    {

        try
        {

            cm = new SqlCommand(st, db.db);
            sqlda = new SqlDataAdapter(cm);
            ds = new DataSet();
            ds.Tables.Clear();
            sqlda.Fill(ds, "recordset");
            db.db.Close();

        }
        catch (Exception) { }
        return ds.Tables["recordset"];
    }
}