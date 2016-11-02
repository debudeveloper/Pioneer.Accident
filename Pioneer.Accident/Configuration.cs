using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pioneer.Accident
{
    public static class Configuration
    {
        public static string LiveConnectionString
        {
            get { return WebConfigurationManager.ConnectionStrings["LiveConnection"].ConnectionString; }
        }

        public static string LeadStatus
        {
            get { return WebConfigurationManager.AppSettings["LeadStatus"].ToString(); }
        }

        public static int SiteId
        {
            get { return int.Parse(WebConfigurationManager.AppSettings["SiteId"].ToString()); }
        }

        public static string SmptHost
        {
            get { return WebConfigurationManager.AppSettings["SmtpHost"].ToString(); }
        }

        public static string ServerEmail
        {
            get { return WebConfigurationManager.AppSettings["ServerEmail"].ToString(); }
        }

        public static string ThankEmailSubject
        {
            get { return WebConfigurationManager.AppSettings["ThankEmailSubject"].ToString(); }
        }

        public static string CustomerServiceEmail
        {
            get { return WebConfigurationManager.AppSettings["CustomerServiceEmail"].ToString(); }
        }

        public static string LeadEmail
        {
            get { return WebConfigurationManager.AppSettings["LeadEmail"].ToString(); }
        }

        public static bool EnableEmailLead
        {
            get { return Convert.ToBoolean(WebConfigurationManager.AppSettings["EnableEmailLead"].ToString()); }
        }

        public static string NoReplyEmail
        {
            get { return WebConfigurationManager.AppSettings["NoReplyEmail"].ToString(); }
        }
    }

}