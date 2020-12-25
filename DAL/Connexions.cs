namespace FredSQLCompare.DAL
{
  public static class Connexions
  {
    public static string GetGeneralConnexionString()
    {
      return "Data Source = {serverName}; Initial Catalog = {databaseName}; Persist Security Info = True; User ID = {userName}; Password = {password}";
    }

    public static string GetAllDatabaseNamesRequest()
    {
      return "use master  select name from sys.databases where name NOT IN ('master', 'model', 'msdb', 'tempdb');";
    }
  }
}
