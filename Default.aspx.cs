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

public partial class Login : System.Web.UI.Page
{

    DataTable dt = new DataTable();
    public static DataSet ds = new DataSet();
    mydb db = new mydb();
    SqlDataAdapter sqlda;
    SqlCommand cm;
    string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {

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
    protected void login_Click(object sender, EventArgs e)
    {
         if (txt_emailid.Text.Length > 0 && txt_password.Text.Length > 0)
        {
            if (dd_login.Text == "Doctor")
            {

                st = "select * from doctor where Email='" + txt_emailid.Text + "' and Password='" + txt_password.Text + "'";
                dt = get_datatable(st);
                Session["doctor"] = txt_emailid.Text;
                if (dt.Rows.Count > 0)
                {
                    int session_princi = dt.Rows[0]["id"].GetHashCode();
                    Session["session_doct"] = session_princi;
                    Session["doctor"] = dt.Rows[0][0].ToString();
                    Doctor_details obj = new Doctor_details();

                    obj.name = dt.Rows[0]["Name"].ToString();
                    Session["doctor_details"] = obj;
                    Response.Redirect("doctor/dashboard.aspx");
                }
                else
                {
                    Label1.Text = "Login Failed";
                    Label1.ForeColor = Color.Red;
                }
            }


            else if (dd_login.Text == "Patient")
            {
                st = "select * from Patient where email='" + txt_emailid.Text + "' and password='" + txt_password.Text + "'";
                dt = get_datatable(st);

                if (dt.Rows.Count > 0)
                {
                    int session_faculty = dt.Rows[0]["id"].GetHashCode();
                    Session["session_Patient"] = session_faculty;
                    Session["Patient"] = dt.Rows[0][0].ToString();
                    Patient_details obj = new Patient_details();
                    obj.EmailID = dt.Rows[0]["email"].ToString();
                    obj.name = dt.Rows[0]["name"].ToString();

                    Session["Patient_details"] = obj;
                    Response.Redirect("Patient/Default.aspx");
                }
                else
                {
                    Label1.Text = "Login Failed";
                    Label1.ForeColor = Color.Red;
                }


            }

           
            else if (dd_login.Text == "Admin")
            {

                st = "select * from admin where email='" + txt_emailid.Text + "' and Password='" + txt_password.Text + "'";
                dt = get_datatable(st);

                if (dt.Rows.Count > 0)
                {
                    int session_admin = dt.Rows[0]["id"].GetHashCode();
                    Session["session_admin"] = session_admin;
                    Session["admin"] = dt.Rows[0][0].ToString();
                    Adminlogin_details objAdminlogin_details = new Adminlogin_details();

                    objAdminlogin_details.fullname = dt.Rows[0]["Name"].ToString();
                    Session["Adminlogin_details"] = objAdminlogin_details;
                    Response.Redirect("Admin/dashboard.aspx");
                }
                else
                {
                    Label1.Text = "Login Failed";
                    Label1.ForeColor = Color.Red;
                }
            }



        }

    }
    }
