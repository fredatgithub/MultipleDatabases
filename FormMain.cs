using System;
using System.Collections.Generic;
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


    }
  }
}
