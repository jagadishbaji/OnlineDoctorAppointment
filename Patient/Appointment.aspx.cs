using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class Patient_Appointment : System.Web.UI.Page
{
    mydb db = new mydb();
    SqlCommand cmd;
    string st = "";
   static  int docid;
    SqlDataReader dr;
    string i = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Patient"] == null)
        {
            Response.Redirect("../Default.aspx");
        }
    }

    public void dd_spl_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from doctor where Specialization= '" + dd_spl.Text + "' ", db.db);
        int x = cmd.ExecuteNonQuery();
        SqlDataReader re = cmd.ExecuteReader();
        dd_doctors.Items.Clear();
        while (re.Read())
        {
            dd_doctors.Items.Add(re["name"].ToString());
            docid=Convert.ToInt32(re["Id"].ToString());

        }
        re.Close();
    }
    protected void rpt_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        LinkButton lnkTime = (LinkButton)e.Item.FindControl("lnkTime");
        if (e.CommandName == "Select")
        {
            if (txt_date.Text != "")
            {

               

                st = "Select * from Appointment where date='" + txt_date.Text + "' and Time='"+lnkTime.Text+"' and DoctId="+docid+" ";
                dr = db.readall(st);
                if (dr.Read())
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Already Appointment Taken ');", true);
                    
                }
                else
                {
                    dr.Dispose();
                    st = "Insert into Appointment(PatientId,DoctId,date,Time) values (" + Session["Patient"] + "," + docid + " ,'" + txt_date.Text + "','" + lnkTime.Text + "')";
                  
                    int x = db.ExeQuery(st);
                    if (x > 0)
                    {
                        //Response.Redirect("MyAppointmentStatus.aspx");
                         ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Appointeted');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Try Again');", true);
                    }
                }
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        st = "Select * from TimeSlots";
        db.fill_rptr_ret_sqlda(st, rpt);

        foreach (RepeaterItem item in rpt.Items)
        {
            LinkButton lnkTime = (LinkButton)item.FindControl("lnkTime");
            //string datetime = txtDate.Text + " " + lnkTime.Text;
            HtmlGenericControl divslot = (HtmlGenericControl)item.FindControl("divslot");
            st = "Select * from Appointment where date='" + txt_date.Text + "' and Time='" + lnkTime.Text + "' and DoctId=" + docid + "  ";
            dr = db.readall(st);
            if (dr.Read())
            {
                lnkTime.Enabled = false;
                lnkTime.ForeColor = System.Drawing.Color.White;
                divslot.Attributes.Add("class", "divslotBooked");
                dr.Dispose();
            }
            else
            {
                lnkTime.Enabled = true;
                lnkTime.ForeColor = System.Drawing.Color.White;
                divslot.Attributes.Add("class", "divslotBook");
                dr.Dispose();
            }
        }
    }
}