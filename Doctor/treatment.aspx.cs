using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;



public partial class Doctor_treatment : System.Web.UI.Page
{
    mydb db = new mydb();
    string st = "";
    DataTable dt = new DataTable();
    SqlCommand cm;
    SqlDataAdapter sqlda;
    string m;
    DataSet ds;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["doctor"] == null)
        {
            Response.Redirect("../Default.aspx");
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
           m = dt.Rows[0]["mobile"].ToString();
           txt_qual.Text = dt.Rows[0]["gender"].ToString();
       }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        st = "insert into treatment values(" + Request.QueryString["pid"].ToString() + "," + Request.QueryString["did"].ToString() + ",'" + txt_name.Text + "','" + txt_emailid.Text + "','" + txt_qual.Text + "','" + dd_spl.Text + "',"+txt_mobile.Text+",'" + txt_desc.Text + "')";
        int x = db.ExeQuery(st);
        if (x > 0)
        {
            String result;
            string apiKey = "tqVqMWIp0G4-3KEbGW4xElG4dBnvujyg4zRx1YHX6C";
            string numbers; // in a comma seperated list
            //    string message = "This is your message";
            string senders = "TXTLCL";
            string mobile =m;
            string msg = "Prescriprion Details \n Name : '" + txt_name.Text + "'\n Mobile:" + txt_mobile.Text + "\n Prescription:'" + txt_desc.Text + "'";
            String url = "https://api.textlocal.in/send/?apikey=" + apiKey + "&numbers=" + mobile + "&message=" + msg + "&sender=" + senders;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.ToString() + "')</script>");
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }


            Response.Write("<script>alert('" + result.ToString() + "')</script>");




            Response.Write("<script>alert('Submitted ...')</script>");
        }
        else
        {
            Response.Write("<script>alert('failed ...')</script>");
        }
    }
}