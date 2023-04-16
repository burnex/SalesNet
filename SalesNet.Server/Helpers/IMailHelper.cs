using System;
using SalesNet.Shared.Responses;

namespace SalesNet.Server.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }
}

