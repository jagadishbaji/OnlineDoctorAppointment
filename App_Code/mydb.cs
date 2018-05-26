using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Drawing;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Web.Script.Serialization;
using System.Linq;
using System.Security.Cryptography;
//using Microsoft.Office.Interop.Excel;
/// <summary>
/// Summary description for mydb
/// </summary>
public class mydb
{
    List<ListItem> list = new List<ListItem>();
    SqlDataAdapter sqlda;
    SqlCommand cm;
    public SqlConnection db;
    string st = "";
    string con = "";
    SHA1 sh = SHA1.Create();

    public static DataSet ds = new DataSet();
    SqlDataReader dr;
    int x;
    public mydb()
    {
        try
        {
            //  con = @"Data Source=APPARI\SQLEXPRESS;Initial Catalog=college;Integrated security=true";
            // con = @"Data Source=DESKTOP-3A4GBR2;Initial Catalog=csdept;Integrated Security=True";
            //con = @"Data Source=DESKTOP-8TVC6LE;Initial Catalog=csdept;Persist Security Info=True;User ID=sa;Password=2020";
            //con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\JSoftware\csdept\App_Data\csdept.mdf;Integrated Security=True";   
         //   con = @"Data Source=DESKTOP-8TVC6LE;Initial Catalog=college;Persist Security Info=True;User ID=sa;Password=2020";
            con = @"Data Source=DESKTOP-8TVC6LE;Initial Catalog=health;Persist Security Info=True;User ID=sa;Password=2020";
            db = new SqlConnection(con);
            if (db.State == ConnectionState.Open)
            {
                db.Close();
            }
            db.Open();
        }
        catch (Exception) { }
    }

   
    public int readmax(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            x = (int)cm.ExecuteScalar();
        }
        catch (Exception) { }
        db.Close();
        return x;

    }


    public string encrypt(string password)
    {
        byte[] b = Encoding.ASCII.GetBytes(password);
        byte[] hashed = sh.ComputeHash(b);
        return Convert.ToBase64String(hashed);
    }

    public string return_affected(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            st = (string)cm.ExecuteScalar();
        }
        catch (Exception) { }
        db.Close();
        return st;
    }

    public int return_affectedID(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            x = (int)cm.ExecuteScalar();
        }
        catch (Exception) { }
        db.Close();
        return x;
    }

    public SqlDataAdapter fill_grid_ret_sqlda(string st, GridView g1)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            sqlda = new SqlDataAdapter(cm);
            ds = new DataSet();
            ds.Tables.Clear();
            g1.DataSource = null;
            g1.DataBind();
            sqlda.Fill(ds, "tbl");
            g1.DataSource = ds.Tables["tbl"];
            g1.DataBind();
            db.Close();
        }
        catch (Exception) { }
        return sqlda;
    }
    public int filldl(string st, DataList d1)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            sqlda = new SqlDataAdapter(cm);
            ds = new DataSet();
            ds.Tables.Clear();
            d1.DataSource = null;
            d1.DataBind();
            sqlda.Fill(ds, "tbl");
            d1.DataSource = ds.Tables["tbl"];
            d1.DataBind();
        }
        catch (Exception) { }
        return 1;

    }
    public int ExeQuery(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            x = cm.ExecuteNonQuery();
        }
        catch (Exception) { }
        return x;

    }

    public SqlDataReader fill_dropdown(string st, DropDownList drop)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);

            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows == true)
            {
                while (dr.Read() == true)
                {
                    if (dr[0].ToString().Trim() != "" || dr[0].ToString().Trim().Length != 0)
                    {
                        drop.Items.Add(dr[0].ToString().Trim());
                    }
                }

            }
            dr.Dispose();
            drop.Items.Insert(0, "Select");
        }
        catch (Exception) { }
        return dr;

    }
    public SqlDataReader sqldr(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            { db.Open(); }
            cm = new SqlCommand(st, db);
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception) { }
        return dr;

    }
    public int chk_data(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            { db.Open(); }
            cm = new SqlCommand(st, db);
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read() == true)
            {

                x = 1;
            }
            else
            {

                x = 0;
            }

            dr.Dispose();
        }
        catch (Exception) { }
        return x;


    }
    public string chk_0(string st)
    {
        if(st.Length == 0)
        {
            return "0";
        }
        else
        { 
        return st;
        }
    }
    public SqlDataReader readall(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            { db.Open(); }
            cm = new SqlCommand(st, db);
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception) { }
        return dr;
      

    }
    public DataTable fill_rptr_ret_sqlda(string st, Repeater r1)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            sqlda = new SqlDataAdapter(cm);
            ds = new DataSet();
            ds.Tables.Clear();
            sqlda.Fill(ds, "tbl");
            r1.DataSource = null;
            r1.DataBind();
            r1.DataSource = ds.Tables["tbl"];
            r1.DataBind();
            db.Close();

        }
        catch (Exception) { }
        return ds.Tables["tbl"];
    }
    public DataTable get_datatable(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            sqlda = new SqlDataAdapter(cm);
            ds = new DataSet();
            ds.Tables.Clear();
            sqlda.Fill(ds, "recordset");            
            db.Close();

        }
        catch (Exception) { }
        return ds.Tables["recordset"];
    }
    public SqlDataAdapter fill_ds_ret_sqlda(string st)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            cm = new SqlCommand(st, db);
            sqlda = new SqlDataAdapter(cm);
            ds = new DataSet();
            ds.Tables.Clear();
            sqlda.Fill(ds, "tbl4");
            db.Close();

        }
        catch (Exception) { }
        return sqlda;
    }
    public string ToSQL(string Param)
    {
        if (Param == null || Param.Length == 0)
        {
            return "Null";
        }
        else
        {
            return Param;
        }
    }

    public string Quote(string Param)
    {
        if (Param == null || Param.Length == 0)
        {
            return "";
        }
        else
        {
            return Param.Replace("'", "''");
        }
    }
    public void fill_drop_with_id(string st, DropDownList drop)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            { db.Open(); }
            cm = new SqlCommand(st, db);
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            //try
            //{
            list.Clear();
            drop.Items.Clear();
            //}
            //catch (Exception ex) { } 
            while (dr.Read() == true)
            {
                if (dr[1].ToString() != "" || dr[1].ToString().Length != 0)
                {
                    list.Add(new ListItem(dr[1].ToString(), dr[0].ToString()));
                }
            }
            drop.DataSource = list;
            drop.DataTextField = "Text";
            drop.DataValueField = "Value";
            drop.DataBind();
            drop.Items.Insert(0, "Select");
            dr.Dispose();

        }
        catch (Exception) { }
        db.Close();
    }

    public void fill_ddl_with_id(string st, DropDownList drop)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            { db.Open(); }
            cm = new SqlCommand(st, db);
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            //try
            //{
            list.Clear();
            drop.Items.Clear();
            //}
            //catch (Exception ex) { } 
            while (dr.Read() == true)
            {
                if (dr[1].ToString() != "" || dr[1].ToString().Length != 0)
                {
                    list.Add(new ListItem(dr[1].ToString(), dr[0].ToString()));
                }
            }
            drop.DataSource = list;
            drop.DataTextField = "Text";
            drop.DataValueField = "Value";
            drop.DataBind();
            dr.Dispose();

        }
        catch (Exception) { }
        db.Close();
    }
    public void fill_listbox_with_id(string st, ListBox drop)
    {
        try
        {
            if (db.State == ConnectionState.Closed)
            { db.Open(); }
            cm = new SqlCommand(st, db);
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            list.Clear();
            drop.Items.Clear();
            while (dr.Read() == true)
            {
                if (dr[1].ToString() != "" || dr[1].ToString().Length != 0)
                {
                    list.Add(new ListItem(dr[1].ToString(), dr[0].ToString()));
                }
            }
            drop.DataSource = list;
            drop.DataTextField = "Text";
            drop.DataValueField = "Value";
            drop.DataBind();

            dr.Dispose();
            db.Close();
        }
        catch (Exception) { }
    }    
    public string read_val(string st)
    {
        string val = "";
        try
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            dr = readall(st);
            if (dr.Read() == true)
            {
                val = dr[0].ToString();
            }
            dr.Dispose();
        }
        catch (Exception) { }
        return val;
        db.Close();
    }

    public string SqlValidate(string sql)
    {
        sql = sql.Replace(";", "");
        sql = sql.Replace("--", "");
        sql = sql.Replace("'", "''");
        sql = sql.Replace("<script", "''");
        sql = sql.Replace("</script>", "''");
        sql = sql.Replace("<SCRIPT", "''");
        sql = sql.Replace("</SCRIPT>", "''");
        sql = sql.Replace(";", "''");
        sql = sql.Replace("%", "''");
        sql = sql.Replace("?", "''");
        sql = sql.Replace("!", "''");
        sql = sql.Replace("EXEC(", "''");
        sql = sql.Replace("VARCHAR(", "''");
        sql = sql.Replace("exec(", "''");
        sql = sql.Replace("varchar(", "''");

        if (sql.IndexOf("<p>") > -1 && sql.LastIndexOf("</p>") > -1)
        {
            if (sql.Substring(0, 3).CompareTo("<p>") == 0)
            {
                //sql = sql.TrimStart('<', 'p', '>');
                //sql = sql.TrimEnd('<', '/', 'p', '>');
                sql = sql.Remove(0, 3);

            }
            if (sql.Substring(sql.Length - 4, 4).CompareTo("</p>") == 0)
            {
                sql = sql.Remove(sql.Length - 4, 4);
            }

        }
        //sql = sql.Replace("&nbsp;", "");
        return sql;

    }
    double dValue;
    long lValue;
    int iValue;
    public double StringToDouble(string val)
    {
        if (!double.TryParse(val, out dValue))
            return dValue = 0.0;
        else
            return double.Parse(val);
    }
    public long StringToLong(string val)
    {
        if (!long.TryParse(val, out lValue))
            return lValue = 0;
        else
            return long.Parse(val);
    }
    public int StringToInt(string val)
    {
        if (!int.TryParse(val, out iValue))
            return iValue = 0;
        else
            return int.Parse(val);
    }
    public double StringToDouble(string val,double defaultValue)
    {
        if (!double.TryParse(val, out dValue))
            return defaultValue;
        else
            return double.Parse(val);
    }
    public long StringToLong(string val, long defaultValue)
    {
        if (!long.TryParse(val, out lValue))
            return defaultValue;
        else
            return long.Parse(val);
    }
    public int StringToInt(string val, int defaultValue)
    {
        if (!int.TryParse(val, out iValue))
            return defaultValue;
        else
            return int.Parse(val);
    }
    public string getRandomString(int length)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var result = new string(
            Enumerable.Repeat(chars, length)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
        return result.ToString();
    }
}