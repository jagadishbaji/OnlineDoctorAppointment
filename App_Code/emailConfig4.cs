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





public class emailConfig4
{
    string strFrom;

    string strCcList;
    string strBccList;
    string strSubject;
    string strBody;

    bool IsBodyHtml;
    public emailConfig4()
    {
        strFrom = string.Empty;

        strCcList = string.Empty;
        strBccList = string.Empty;
        strSubject = string.Empty;
        strBody = string.Empty;
    }

    public string email_content1(string body_text, string person_name, string link_url, string link_text, string mail_header)
    {
        string email_content = string.Format(@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD XHTML 1.0 Strict//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns=""http://www.w3.org/1999/xhtml"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
<head>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""viewport"" content=""width=device-width"" />
</head>
<body style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; width: 100% !important; height: 100%; -webkit-font-smoothing: antialiased; -webkit-text-size-adjust: none; background: #efefef; margin: 0; padding: 0;"" bgcolor=""#efefef"">
    <table class=""body-wrap"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; width: 100% !important; height: 100%; -webkit-font-smoothing: antialiased; -webkit-text-size-adjust: none; background: #efefef; margin: 0; padding: 0;"" bgcolor=""#efefef"">
        <tr style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
            <td class=""container"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; display: block !important; clear: both !important; max-width: 580px !important; margin: 0 auto; padding: 0;"">
                <table style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; width: 100% !important; border-collapse: collapse; margin: 0; padding: 0;"">
                    <tr style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
                        <td align=""center"" class=""masthead"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; color: white; background: url('http://patterncooler.com/gen/index/180/tear_drop_spin_pattern-523.png'); margin: 0; padding: 80px 0;"">

                            <h1 style=""font-size: 32px; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.25; max-width: 90%; text-transform: uppercase; margin: 0 auto; padding: 0;"">{0}</h1>

                        </td>
                    </tr>
                    <tr style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
                        <td class=""content"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; background: white; margin: 0; padding: 30px 35px;"" bgcolor=""white"">

                            <h2 style=""font-size: 28px; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.25; margin: 0 0 20px; padding: 0;"">Hi {1},</h2>

                            <p style=""font-size: 16px; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; font-weight: normal; margin: 0 0 20px; padding: 0;"">{2}</p>

                            <table style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; width: 100% !important; border-collapse: collapse; margin: 0; padding: 0;{3}"">
                                <tr style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
                                    <td align=""center"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
                                        <p style=""font-size: 16px; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; font-weight: normal; margin: 0 0 20px; padding: 0;"">
                                            <a href='{4}' class=""button"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; color: white; text-decoration: none; display: inline-block; font-weight: bold; border-radius: 4px; background: #008CAD; margin: 0; padding: 0; border-color: #008cad; border-style: solid; border-width: 10px 20px 8px;"">{5}</a>
                                        </p>
                                    </td>
                                </tr>
                            </table>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
            <td class=""container"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; display: block !important; clear: both !important; max-width: 580px !important; margin: 0 auto; padding: 0;"">
                <table style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; width: 100% !important; border-collapse: collapse; margin: 0; padding: 0;"">
                    <tr style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; margin: 0; padding: 0;"">
                        <td class=""content footer"" align=""center"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; background: white none; margin: 0; padding: 30px 35px;"" bgcolor=""white"">
                            <p style=""font-size: 14px; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; font-weight: normal; color: #888; text-align: center; margin: 0; padding: 0;"" align=""center"">Sent by <a href=""#"" style=""font-size: 100%; font-family: 'Avenir Next', 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; line-height: 1.65; color: #888; text-decoration: none; font-weight: bold; margin: 0; padding: 0;"">CollegeApp</a></p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</body>
</html>
", mail_header, person_name, body_text, (link_text.Length == 0) ? "display:none;" : "", link_url, link_text);
        return email_content;

    }

    public bool SendEmail(string strTo, string strCcList, string strBccList, string strSubject, string strBody, bool IsBodyHtml)
    {
        bool status = false;

        this.strFrom = "CollegeApp";
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



