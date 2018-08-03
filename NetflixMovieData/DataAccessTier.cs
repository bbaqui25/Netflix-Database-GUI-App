//
// Data Access Tier:  interface between business tier and data store.
//

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessTier
{

  public class Data
  {
    //
    // Fields:
    //
    private string _DBFile;
    private string _DBConnectionInfo;

    //
    // constructor:
    //
    public Data(string DatabaseFilename)
    {
      string version;

      version = "MSSQLLocalDB";  // for VS 2015:

      _DBFile = DatabaseFilename;
      _DBConnectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;",
        version,
        DatabaseFilename);
    }

    //
    // TestConnection:  returns true if the database can be successfully opened and closed,
    // false if not.
    //
    public bool TestConnection()
    {
      SqlConnection db = new SqlConnection(_DBConnectionInfo);

      bool  state = false;

      try
      {
        db.Open();

        state = (db.State == ConnectionState.Open);
      }
      catch
      {
        // nothing, just discard:
      }
      finally
      {
        db.Close();
      }

      return state;
    }

    //
    // ExecuteScalarQuery:  executes a scalar Select query, returning the single result 
    // as an object.  
    //
    public object ExecuteScalarQuery(string sql)
    {
       SqlConnection db = new SqlConnection(_DBConnectionInfo);
       object result = null;

       try
       {
          db.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;
          cmd.CommandText = sql;
          result = cmd.ExecuteScalar();     // for single value
       }
       catch
       {
          throw; // re-throw if there is an exception
       }
       finally
       {
          if (db != null & db.State == ConnectionState.Open)
            db.Close();
       }

       return result;
    }

    // 
    // ExecuteNonScalarQuery:  executes a Select query that generates a temporary table,
    // returning this table in the form of a Dataset.
    //
    public DataSet ExecuteNonScalarQuery(string sql)
    {
       SqlConnection db = new SqlConnection(_DBConnectionInfo);
       DataSet ds = new DataSet();

       try
       {
          db.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;
          SqlDataAdapter adapter = new SqlDataAdapter(cmd);

          cmd.CommandText = sql;

          adapter.Fill(ds);     // retrieve N values
       }
       catch
       {
          throw; // re-throw if there is an exception
       }
       finally
       {
          if (db != null & db.State == ConnectionState.Open)
            db.Close();
       }

       return ds;
    }

    //
    // ExecutionActionQuery:  executes an Insert, Update or Delete query, and returns
    // the number of records modified.
    //
    public int ExecuteActionQuery(string sql)
    {
       SqlConnection db = new SqlConnection(_DBConnectionInfo);
       int result = 0;

       try
       {
          db.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;
          cmd.CommandText = sql;
          result = cmd.ExecuteNonQuery();       // modify the table
       }
       catch
       {
          throw; // re-throw if there is an exception
       }
       finally
       {
          if (db != null & db.State == ConnectionState.Open)
            db.Close();
       }

       return result;
    }

  }//class
}//namespace
