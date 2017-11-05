using MailSender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsServiceMailClient
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            MailClient mail = new MailClient();
            mail.SendEmail("domagoj.persic@vsmti.hr", "Proba", "Hello World !!");
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            
           
        }

        protected override void OnStop()
        {
           
        }
    }
}
