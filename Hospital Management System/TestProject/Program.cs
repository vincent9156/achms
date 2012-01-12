using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace TestProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Retrieve the MS Access database-specific connection string. 
            string connectionString = //SQLiteConnectionProvider.GetConnectionString("mydata.sqlite");
             AccessConnectionProvider.GetConnectionString("sample.mdb");

            // Create the default DAL which is used by the default Session and 
            // newly created objects  
            // to access a data store. 
            // If the database does not exist, XPO creates it. 
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString,AutoCreateOption.DatabaseAndSchema);
            
            Console.WriteLine("App launched");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

