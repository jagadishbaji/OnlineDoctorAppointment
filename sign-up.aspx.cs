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


public partial class sign_up : System.Web.UI.Page
{

    string st = "";
    string gender = "";
    mydb db = new mydb();
    SqlCommand cm;
    int x;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void signup_Click(object sender, System.EventArgs e)
    {
        gender = (string)(this.rdFemale.Checked ? "Female" : "Male");
       
            st = "insert into Patient values ('" + txt_name.Text + "','" + txt_emailid.Text + "','" + gender + "','" + txt_address.Text + "'," + txt_mobile.Text + ",'" + txt_password.Text + "')";
            x = db.ExeQuery(st);
            if (x > 0)
            {
                emailaccount _emailConfig = new emailaccount();
                string mail_body = _emailConfig.email_content1("Your account has been created in Health Care Organisation. <br/><b>Password : " + txt_password.Text + "</b> ", "", "", "", "Account Created");
                _emailConfig.SendEmail(txt_emailid.Text, "", "", "Your Account Created", mail_body, true);

                fill_repeater();
                Label1.Text = "Sign-up Success";
                Label1.ForeColor = Color.Green;
            }
            else
            {
                fill_repeater();
                Label1.Text = "Failed to Sign-up";
                Label1.ForeColor = Color.Red;
            }
                
    }
    protected void fill_repeater()
    {

        txt_emailid.Text = "";

        txt_name.Text = "";

        txt_password.Text = "";

    }
}