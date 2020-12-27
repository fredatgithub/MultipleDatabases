using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using MultipleDatabases.DAL;

namespace MultipleDatabases
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    public List<string> DatabaseNames = new List<string>();

    private void FormMain_Load(object sender, EventArgs e)
    {
      // loading databases
      string sqlQuery = Connexions.GetAllDatabaseNamesRequest();
      // verify source db connexion
      DatabaseAuthentication dbConnexionSource = new DatabaseAuthentication
      {
        UserName = Properties.Settings.Default.UserName ,
        UserPassword = Properties.Settings.Default.UserPassword,
        ServerName = Properties.Settings.Default.ServerName,
        DatabaseName = Properties.Settings.Default.DatabaseName
      };

      dbConnexionSource.DatabaseName = "master";
      // verify target db connexion
      if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbConnexionSource.DatabaseName, dbConnexionSource.ServerName))
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexionSource.DatabaseName} on the server: {dbConnexionSource.ServerName}");
        return;
      }

      
      List<string> listOfDatabaseNames = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionSource.DatabaseName, Dns.GetHostName());

      listBoxDatabaseName.Items.Clear();
      foreach (string dbName in listOfDatabaseNames)
      {
        listBoxDatabaseName.Items.Add(dbName);
      }
    }
  }
}
