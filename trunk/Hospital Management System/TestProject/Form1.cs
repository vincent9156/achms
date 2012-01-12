using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using ACHMS.Common.Entities;

namespace TestProject
{
    public partial class Form1 : Form
    {
        Session session;
        public Form1()
        {
            InitializeComponent();
            session = new Session();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            using (ExplicitUnitOfWork uow = new ExplicitUnitOfWork()) {
                //uow.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema;
                Doctor doctor = new Doctor(uow);
                LoginSession ls = new LoginSession(uow);
                User user = new User(uow);
                user.UserName = "Saidul Islam";

                ls.User = user;

                uow.CommitChanges();
                
            }
        }
    }
}
