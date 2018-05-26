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



public partial class Admin_Manage_doctors : System.Web.UI.Page
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        gender = (string)(this.rdFemale.Checked ? "Female" : "Male");
        st = "insert into doctor values ('" + txt_name.Text + "','" + txt_emailid.Text + "','" + gender + "','" + txt_qual.Text + "','"+dd_spl.Text+"'," + txt_mobile.Text + ",'" + txt_password.Text + "')";
        x = db.ExeQuery(st);
        if (x > 0)
        {
            emailaccount _emailConfig = new emailaccount();
            string mail_body = _emailConfig.email_content1("Your account has been created in Health Care Organisation. <br/><b>Password : " + txt_password.Text + "</b> ", "", "", "", "Account Created");
            _emailConfig.SendEmail(txt_emailid.Text, "", "", "Your Account Created", mail_body, true);

            Label1.Text = "Doctor Added Success";
            Label1.ForeColor = Color.Green;
          
        }
        else
        {
         
            Label1.Text = "Failed to Add";
            Label1.ForeColor = Color.Red;
        }
        fill_empty();
        fill_repeater();
    }
    protected void fill_empty()
    {

        txt_emailid.Text = "";

        txt_name.Text = "";

        txt_password.Text = "";

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
    protected void lnk_delete_Click(object sender, EventArgs e)
    {
        LinkButton lnk = sender as LinkButton;
        st = "delete from doctor where id=" + lnk.CommandArgument;
        db.ExeQuery(st);
        fill_repeater();
    }
}