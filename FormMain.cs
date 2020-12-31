using MultipleDatabases.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        UserName = Properties.Settings.Default.UserName,
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

      List<string> listOfDatabaseNames = DALHelper.ExecuteSqlQueryToListOfStrings(sqlQuery, dbConnexionSource.DatabaseName, dbConnexionSource.ServerName);

      listBoxDatabaseName.Items.Clear();
      if (Properties.Settings.Default.DatabasePattern != string.Empty)
      {
        foreach (string dbName in listOfDatabaseNames)
        {
          if (dbName.ToLower().StartsWith(Properties.Settings.Default.DatabasePattern.ToLower()))
          {
            listBoxDatabaseName.Items.Add(dbName);
          }
        }
      }
    }

    private void ButtonSearchBill_Click(object sender, EventArgs e)
    {
      // recherche facture sur plusieurs bases
      // for each Databases, ajouter le résultat de la recherche
      string connexionString = Connexions.GetGeneralConnexionString();
      // "Data Source = {serverName}; Initial Catalog = {databaseName}; Persist Security Info = True; User ID = {userName}; Password = {password}";
      DatabaseAuthentication dbConnexion = new DatabaseAuthentication
      {
        UserName = Properties.Settings.Default.UserName,
        UserPassword = Properties.Settings.Default.UserPassword,
        ServerName = Properties.Settings.Default.ServerName,
        DatabaseName = Properties.Settings.Default.DatabaseName
      };

      connexionString = connexionString.Replace("{serverName}", dbConnexion.ServerName);
      connexionString = connexionString.Replace("{userName}", dbConnexion.UserName);
      connexionString = connexionString.Replace("{password}", dbConnexion.UserPassword);

      string sqlQuery = ""; // TODO
      SqlDataReader result = null;
      foreach (string dbName in listBoxDatabaseName.Items)
      {
        // construction de la connexion string:
        dbConnexion.DatabaseName = dbName;
        connexionString = connexionString.Replace("{databaseName}", dbName);
        // verify target db connexion
        if (!DALHelper.VerifyDatabaseConnexion(sqlQuery, dbName, dbConnexion.ServerName))
        {
          MessageBox.Show($"Cannot connect to the database: {dbName} on the server: {dbConnexion.ServerName}");
          return;
        }

        result = DALHelper.ExecuteSqlQueryManyResults(sqlQuery, dbName, dbConnexion.ServerName);
        if (result != null)
        {
          // result to be added to total result var
        }
      }
    }
  }
}
