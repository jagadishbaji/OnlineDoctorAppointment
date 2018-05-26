using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Net.Mail;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;





public class emailforgetpwd
{
    string strFrom;

    string strCcList;
    string strBccList;
    string strSubject;
    string strBody;

    bool IsBodyHtml;
    public emailforgetpwd()
    {
        strFrom = string.Empty;

        strCcList = string.Empty;
        strBccList = string.Empty;
        strSubject = string.Empty;
        strBody = string.Empty;
    }

    public string email_content(string body_text,string person_name, string link_url, string link_text, string mail_header)
    {
        string email_content = string.Format(@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD XHTML 1.0 Strict//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"">
         <html xmlns=""http://www.w3.org/1999/xhtml"">
         <head>
  <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
  <title>Policy Menia</title>
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0""/>
</head>
<body style=""margin: 0; padding: 0;"">

    <table align=""center"" border=""1"" cellpadding=""0"" cellspacing=""0"" width=""600"">

 <tr>

  <td align=""center"" bgcolor=""#70bbd9"" style=""padding: 40px 0 30px 0;"">
 <h2>Registraion Succesfull, Thank You</h2>

 </tr>
 <tr>
  <td bgcolor=""#ffffff"" style=""padding: 40px 30px 40px 30px;"">
      <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
 <tr>
  <td>
 College App
  </td>
 </tr>
 <tr>
  <td style=""padding: 20px 0 30px 0;"">
  <br/>
http://localhost:1553/csdept/Admin/reset-password.aspx
CollegeApp</td>
 </tr>
 
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
 <tr>
  <td width=""260"" valign=""top"">
   <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
    <tr>
    
    </tr>
    <tr>
    
    </tr>
   </table>
  </td>
  <td style=""font-size: 0; line-height: 0;"" width=""20"">
   &nbsp;
  </td>
  <td width=""260"" valign=""top"">
   <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
    <tr>
    
    </tr>
    <tr>
   
    </tr>
   </table>
  </td>
 </tr>
</table>

 </tr>
 <tr>
  <td bgcolor=""#ee4c50"" style=""padding: 30px 30px 30px 30px;"">

<table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">

 <tr>
     <td width=""75%"">
 &reg; CollegeApp 2016<br/>
 Desgn by Jagadish B

</td>
 <td align=""right"">
 <table border=""0"" cellpadding=""0"" cellspacing=""0"">
  <tr>
   
   <td style=""font-size: 0; line-height: 0;"" width=""20"">&nbsp;</td>
   <td>
    
   </td>
  </tr>
 </table>
</td>
 </tr>
</table>
</td>

 </tr>
</table>
</body>
</html>", body_text,mail_header, person_name, body_text, (link_text.Length == 0) ? "display:none;" : "", link_url, link_text);
        return email_content;
    }

    public bool SendEmail(string strTo, string strCcList, string strBccList, string strSubject, string strBody, bool IsBodyHtml)
    {
        bool status = false;

        this.strFrom = "CollegeSports";
        this.strCcList = strCcList;
        this.strBccList = strBccList;
        this.strSubject = strSubject;
        this.strBody = strBody;
        this.IsBodyHtml = IsBodyHtml;

        SmtpClient smtpSendMail = new SmtpClient();
        smtpSendMail.Port = 587;
        smtpSendMail.Host = "smtp.gmail.com";
        MailMessage objEmail = new MailMessage();
        objEmail.From = new MailAddress("pajimanmohan@gmail.com", strFrom);
        objEmail.To.Add(strTo);
        objEmail.Subject = strSubject;
        objEmail.Body = strBody;
        objEmail.IsBodyHtml = IsBodyHtml;
        smtpSendMail.EnableSsl = true;


        try
        {
            smtpSendMail.Credentials = new System.Net.NetworkCredential("pajimanmohan@gmail.com", "sushmit12");
            smtpSendMail.Send(objEmail);
            status = true;
        }
        catch (Exception e)
        {
            throw;
        }
        return true;
    }
}



