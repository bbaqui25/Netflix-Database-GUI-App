//
// BusinessTier:  business logic, acting as interface between UI and data store.
//

using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{

  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data dataTier;


    //
    // Constructor:
    //
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;

      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }


    //
    // TestConnection:
    //
    // Returns true if we can establish a connection to the database, false if not.
    //
    public bool TestConnection()
    {
      return dataTier.TestConnection();
    }


    //
    // GetUser:
    //
    // Retrieves User object based on USER ID; returns null if user is not
    // found.
    //
    // NOTE: if the user exists in the Users table, then a meaningful name and 
    // occupation are returned in the User object.  If the user does not exist 
    // in the Users table, then the user id has to be looked up in the Reviews 
    // table to see if he/she has submitted 1 or more reviews as an "anonymous"
    // user.  If the id is found in the Reviews table, then the user is an
    // "anonymous" user, so a User object with name = "<UserID>" and no occupation
    // ("") is returned.  In other words, name = the user’s id surrounded by < >.
    //
    public User GetUser(int UserID)
    {
      try
      {
        string sql = string.Format(@"Select UserName, Occupation 
                                     from Users where UserID = '{0}';", UserID);

        DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

        if (ds.Tables["TABLE"].Rows.Count == 0) return null;    // check if the user exists

        DataRow row = ds.Tables["TABLE"].Rows[0];

        User newObj = new User( UserID,
                                Convert.ToString(row["UserName"]),
                                Convert.ToString(row["Occupation"]) );

        return newObj;
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetUser: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

    }


    //
    // GetNamedUser:
    //
    // Retrieves User object based on USER NAME; returns null if user is not
    // found.
    //
    // NOTE: there are "named" users from the Users table, and anonymous users
    // that only exist in the Reviews table.  This function only looks up "named"
    // users from the Users table.
    //
    public User GetNamedUser(string UserName)
    {
      try
      {
        string sql = string.Format(@"Select UserID, Occupation 
                                     from Users where UserName = '{0}'
                                     order by UserName ASC;", UserName);

        DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

        if (ds.Tables["TABLE"].Rows.Count == 0) return null;    // check if the user exists

        DataRow row = ds.Tables["TABLE"].Rows[0];

        User newObj = new User(Convert.ToInt32(row["UserID"]), UserName, Convert.ToString(row["Occupation"]));

        return newObj;     
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

    }


    //
    // GetAllNamedUsers:
    //
    // Returns a list of all the users in the Users table ("named" users), sorted 
    // by user name.
    //
    // NOTE: the database also contains lots of "anonymous" users, which this 
    // function does not return.
    //
    public IReadOnlyList<User> GetAllNamedUsers()
    {
      List<User> users = new List<User>();

      string sql = string.Format(@"Select UserID, UserName, Occupation 
                                   from Users Order by UserName;");

      DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

      if (ds.Tables["TABLE"].Rows.Count == 0) return null;  // check if the user exists

      foreach (DataRow row in ds.Tables["TABLE"].Rows)
      {
          var temp = new User( Convert.ToInt32(row["UserID"]),
                               Convert.ToString(row["UserName"]),
                               Convert.ToString(row["Occupation"]) );

          users.Add(temp);
      }
      
      return users;

    }


    //
    // GetMovie:
    //
    // Retrieves Movie object based on MOVIE ID; returns null if movie is not
    // found.
    //
    public Movie GetMovie(int MovieID)
    {
      Movie newObj = null;

      try
      {
        string sql = string.Format(@"Select MovieName
                                     from Movies where MovieID = '{0}';", MovieID);

        var result = dataTier.ExecuteScalarQuery(sql);

        newObj = new Movie(MovieID, Convert.ToString(result));
                
        return result == null ? null : newObj;      // returns null if movie is not found
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

    }


    //
    // GetMovie:
    //
    // Retrieves Movie object based on MOVIE NAME; returns null if movie is not
    // found.
    //
    public Movie GetMovie(string MovieName)
    {
      Movie newObj = null;

      try
      {
        string value = MovieName;
        // escape each ' in the string value by placing a ' before it
        value = value.Replace("'", "''");

        string sql = string.Format(@"Select MovieID
                                     from Movies where MovieName = '{0}';", value);

        var result = dataTier.ExecuteScalarQuery(sql);

        newObj = new Movie(Convert.ToInt32(result), MovieName);

        return result == null ? null : newObj;      // returns null if movie is not found
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

    }


    //
    // GetAllMovies:
    //
    // Returns a list of all the movies in the database, sorted by movie name.
    //
    public IReadOnlyList<Movie> GetAllMovies()
    {
      List<Movie> movies = new List<Movie>();

      try
      {
        string sql = string.Format(@"Select MovieID, MovieName
                                     from Movies Order by MovieName ASC;");

        DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          var temp = new Movie( Convert.ToInt32(row["MovieID"]),
                                Convert.ToString(row["MovieName"]) );
                               
          movies.Add(temp);
        }
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return movies;

    }


    //
    // AddReview:
    //
    // Adds review based on MOVIE ID, returning a Review object containing
    // the review, review's id, etc.  If the add failed, null is returned.
    //
    public Review AddReview(int MovieID, int UserID, int Rating)
    {
      string sql = string.Format(@"Insert into Reviews(MovieID, UserID, Rating) values({0}, {1}, {2});
                                     SELECT ReviewID FROM Reviews WHERE ReviewID = SCOPE_IDENTITY();",
                                     MovieID, UserID, Rating);

      object result = dataTier.ExecuteScalarQuery(sql);

      if (result == null)
        return null;
      else 
        return new  Review( Convert.ToInt32(result), MovieID, UserID, Rating);

    }


    //
    // GetMovieDetail:
    //
    // Given a MOVIE ID, returns detailed information about this movie --- all
    // the reviews, the total number of reviews, average rating, etc.  If the 
    // movie cannot be found, null is returned.
    //
    public MovieDetail GetMovieDetail(int MovieID)
    {
      IReadOnlyList<Review> list = new List<Review>();
      List<Review> Review = new List<Review>();

      try
      {
        // get the Review objects
        string sql = string.Format(@"Select ReviewID, MovieID, UserID, Rating from Reviews
                                     where MovieID = '{0}'
                                     order by Rating DESC, UserID ASC;", MovieID);

        DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

       
        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          var temp = new Review( Convert.ToInt32(row["ReviewID"]),
                                 Convert.ToInt32(row["MovieID"]),
                                 Convert.ToInt32(row["UserID"]),
                                 Convert.ToInt32(row["Rating"]) );

          Review.Add(temp);
        }

        Movie movieName = GetMovie(MovieID);

        string sql1 = string.Format(@"Select Round(AVG(CONVERT(float, Rating)), 4) as AvgRating,
                                      count(*) as NumReviews from Reviews where MovieID = '{0}';",
                                      MovieID);

        DataSet ds1 = dataTier.ExecuteNonScalarQuery(sql1);

        if (ds1.Tables["TABLE"].Rows.Count == 0) return null;   // check if the movie exists

        DataRow rows = ds1.Tables["TABLE"].Rows[0];
        
        MovieDetail temp1 = new MovieDetail( movieName, 
                                 Convert.ToDouble(rows["AvgRating"]), 
                                 Convert.ToInt32(rows["NumReviews"]), 
                                 Review );

        return  temp1;      
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

   }


   //
   // GetUserDetail:
   //
   // Given a USER ID, returns detailed information about this user --- all
   // the reviews submitted by this user, the total number of reviews, average 
   // rating given, etc.  If the user cannot be found, null is returned.
   //
   public UserDetail GetUserDetail(int UserID)
   {
     List<Review> reviews = new List<Review>();

     try
     { 
       // get the Review objects
       string sql = string.Format(@"Select ReviewID, Reviews.MovieID, UserID, Rating from Reviews
                                    INNER JOIN Movies on Movies.MovieID = Reviews.MovieID
                                    where UserID = '{0}'
                                    order by MovieName ASC;", UserID);

       DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

       foreach (DataRow row in ds.Tables["TABLE"].Rows)
       {
         var temp = new Review( Convert.ToInt32(row["ReviewID"]),
                                Convert.ToInt32(row["MovieID"]),
                                Convert.ToInt32(row["UserID"]),
                                Convert.ToInt32(row["Rating"]) );

         reviews.Add(temp);
       }

       User userName = GetUser(UserID);

       string sql1 = string.Format(@"Select Round(AVG(CONVERT(float, Rating)), 4) as AvgRating,
                                     count(*) as NumReviews from Reviews where UserID = '{0}';",
                                     UserID);

       DataSet ds1 = dataTier.ExecuteNonScalarQuery(sql1);

       double avgRating = 0.0;
       int numReviews = 0;

       if (ds1.Tables["TABLE"].Rows.Count == 0) return null; // check if the user exists

       foreach (DataRow rows in ds1.Tables["TABLE"].Rows)
       {
         avgRating += Convert.ToDouble(rows["AvgRating"]);
         numReviews += Convert.ToInt32(rows["NumReviews"]);
       }

       UserDetail temp1 = new UserDetail(userName, avgRating, numReviews, reviews);

       return temp1;    
     }
     catch (Exception ex)
     {
       string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
       throw new ApplicationException(msg);
     }
   }

    
    //
    // GetTopMoviesByAvgRating:
    //
    // Returns the top N movies in descending order by average rating.  If two
    // movies have the same rating, the movies are presented in ascending order
    // by name.  If N < 1, an EMPTY LIST is returned.
    //
    public IReadOnlyList<Movie> GetTopMoviesByAvgRating(int N)
    {
      List<Movie> movies = new List<Movie>();

      try
      {
       string sql = string.Format(@"Select Top {0} Movies.MovieName, Round(AVG(CONVERT(float,Reviews.Rating)), 4) as AvgRating
                                    from Movies INNER JOIN Reviews ON Movies.MovieID = Reviews.MovieID 
                                    Group By Movies.MovieName
                                    Order By AvgRating DESC, Movies.MovieName ASC;", N);

        DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

        // check if N < 1
        if (ds.Tables["TABLE"].Rows.Count < 1)
        {
          return movies;     // returns an empty list
        }

        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          var movieName = Convert.ToString(row["MovieName"]);
          var movieId = GetMovie(movieName);
          var newObj = new Movie(movieId.MovieID, movieName);
          movies.Add(newObj);
        }

        return movies;
                                       
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

    }


    //
    // GetTopMoviesByNumReviews
    //
    // Returns the top N movies in descending order by number of reviews.  If
    // two movies have the same number of reviews, the movies are presented in
    // ascending order by name.  If N < 1, an EMPTY LIST is returned.
    //
    public IReadOnlyList<Movie> GetTopMoviesByNumReviews(int N)
    {
      List<Movie> movies = new List<Movie>();
   
      try
      {
        string sql = string.Format(@"Select Top {0} Movies.MovieName, Count(*) as NumReviews
                                     from Movies INNER JOIN Reviews ON Movies.MovieID = Reviews.MovieID 
                                     Group By Movies.MovieName
                                     Order By NumReviews DESC, Movies.MovieName ASC;", N);

        DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

        // check if N < 1
        if (ds.Tables["TABLE"].Rows.Count < 1)
        {
          return new List<Movie>();     // returns an empty list
        }

        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          var movieName = Convert.ToString(row["MovieName"]);
          var movieId = GetMovie(movieName);
          var newObj = new Movie(movieId.MovieID, movieName);
          movies.Add(newObj);
        }

        return movies;

      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetAllNamedUsers: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

   }


    //
    // GetTopUsersByNumReviews
    //
    // Returns the top N users in descending order by number of reviews.  If two
    // users have the same number of reviews, the users are presented in ascending
    // order by user id.  If N < 1, an EMPTY LIST is returned.
    //
    // NOTE: not all user ids map to users in the Users table.  User ids that don't
    // map are considered "anonymous" users, and returned with their name = to their
    // userid ("<UserID>") and no occupation ("").
    //
    public IReadOnlyList<User> GetTopUsersByNumReviews(int N)
    {
      List<User> users = new List<User>();

      //
      // execute query to rank users:
      //
      // NOTE: some reviews are anonymous, i.e. don't have an entry in the Users
      // table.  So we use a "RIGHT JOIN" to capture those as well.
      //
      string sql = string.Format(@"SELECT TOP {0} Temp.UserID, Users.UserName, Users.Occupation
                                   FROM Users
                                   RIGHT JOIN ( SELECT UserID, COUNT(*) AS RatingCount FROM Reviews
                                   GROUP BY UserID ) AS Temp
                                   On Temp.UserID = Users.UserID
                                   ORDER BY Temp.RatingCount DESC, Users.UserName Asc;", N);

       //
       // Now execute this query...  In the resulting dataset, the anonymous users will
       // have a UserName of "" because the result of the join was NULL.  So when you
       // come across a user with "" as their name, create a new User based on their user
       // id, i.e. string.Format("<{0}>", userid);
       //

       DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

       // check if N < 1
       if (ds.Tables["TABLE"].Rows.Count < 1)
       {
         return users;     // returns an empty list
       }

       foreach (DataRow row in ds.Tables["TABLE"].Rows)
       {
         string userName = Convert.ToString(row["UserName"]);

         if (userName == "") 
           userName = Convert.ToString(row["UserID"]); 

         User newObj = new User( Convert.ToInt32(row["UserID"]), 
                                 userName, 
                                 Convert.ToString(row["Occupation"]) );
         users.Add(newObj);
       }

     return users;
   }

  }//class
}//namespace
