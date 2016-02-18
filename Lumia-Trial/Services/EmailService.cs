using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using Lumia_Trial.Models;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {
        }

        public void Send(CompanyViewModel model)
        {
            string email = Resources.EmailSettings.Email;
            string password = Resources.EmailSettings.Password;

            var loginInfo = new NetworkCredential(email, password);
            var msg = new MailMessage();
            var smtpClient = new SmtpClient(Resources.EmailSettings.SMTP, Convert.ToInt32(Resources.EmailSettings.Port));

            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress(model.EmailAddress));
            msg.Subject = "Lumia Trial";
            msg.Body = this.BuildEmailBody(model);
            msg.IsBodyHtml = true;

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(msg);
        }

        private string BuildEmailBody(CompanyViewModel model)
        {
            var body = string.Format("Region: {0} Selection Date:  {1} " +
                                     "Contact Name: {2} Email Address:{3} Address: {4} Number: {5} Postcode: {6} Job Title: {7} Company Name: {8} Handset Opotunitiy: {9} Refresh Date: {10} Handset Provider: {11} " +
                                     "Handset Operator: {12}  Accepted Terms: {13}  Share Information: {14}",
                model.SelectedRegionName, model.SelectionDateName, model.ContactName, model.EmailAddress, model.Address,
                model.Number, model.PostCode, model.JobTitle, model.CompanyName, model.SelectedHandsetOpotunityName,
                model.SelectionDateName, model.CurrentHandsetProvider, model.CurrentHandsetOperator,
                model.IsTermsAcepted,
                model.IsSharedInformationAllowed);

            model.Devices.ForEach(x =>
            {
                body += string.Format("Device Selection - Name: {0} Enabled: {1} Selected: {2} {3} ", x.Name, x.Enabled, x.Checked, Environment.NewLine);
            });

            return body;
        }
    }
}