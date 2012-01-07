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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork()) {
                Doctor doctor = new Doctor();
                LoginSession ls = new LoginSession();

                uow.CommitChanges();
            }
        }
    }
}
