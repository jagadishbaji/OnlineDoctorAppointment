﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Web.Security;
using System.Drawing;

public partial class Doctor_treat_details : System.Web.UI.Page
{
    string st = "";
    string gender = "";
    mydb db = new mydb();
    SqlCommand cm;
    int x;
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
        st = "select * from treatment where p_id=" + Session["Patient"] + "";
        db.fill_rptr_ret_sqlda(st, Repeater1);
        if (Repeater1.Items.Count > 0)
            owner_pnl.Visible = true;
        else
            owner_pnl.Visible = false;

    }
}