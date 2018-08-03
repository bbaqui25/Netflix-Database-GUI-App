//
// Netflix Database Application using N-Tier Design.
//
// Bushra Baqui
// U. of Illinois, Chicago
// CS341, Spring 2017
// Project 08
//

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NetflixMovieData
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private bool fileExists(string filename)
        {
            if (!System.IO.File.Exists(filename))
            {
                string msg = string.Format("Input file not found: '{0}'",
                  filename);

                MessageBox.Show(msg);
                return false;
            }

            // exists!
            return true;
        }

        private void AllMovies_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var movies = bizTier.GetAllMovies();

            foreach (BusinessTier.Movie movie in movies)
            {
                this.listBox1.Items.Add(String.Format("{0}: {1}", movie.MovieID, movie.MovieName));
            }

        }

        private void AllUsers_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var users = bizTier.GetAllNamedUsers();

            foreach (BusinessTier.User user in users)
            {
                this.listBox1.Items.Add(String.Format("{0}: {1}: {2}", user.UserID, user.UserName, user.Occupation));
            }

        }

        private void GetMovieReviews_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var movieName = bizTier.GetMovie(this.textMovieReviews.Text);   // get movie name from Getmovie()
            // check if movie name exists 
            if (movieName == null)
            {
                listBox1.Items.Add("Movie doesn't exist");
                return;
            }

            var movieDetail = bizTier.GetMovieDetail(movieName.MovieID);    // get all the details of movie from GetMovieDetail()

            foreach (var movieObject in movieDetail.Reviews)
            {
                this.listBox1.Items.Add(String.Format("{0}: {1}", movieObject.UserID, movieObject.Rating)); // since we have access to Reviews we can get user id and rating
            }

        }

        private void GetUserReviews_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var userName = bizTier.GetNamedUser(this.textUserReviews.Text); // get user name from GetNamedUser()
            // check if the user name exists
            if (userName == null)
            {
                listBox1.Items.Add("User doesn't exist");
                return;
            }

            var userDetail = bizTier.GetUserDetail(userName.UserID);    // get all the details of user from GetUserDetail()

            foreach (var userObject in userDetail.Reviews)
            {
                // since we have access to Reviews we can get movie id and rating
                // we can get movie name from movie id
                var movieId = bizTier.GetMovie(userObject.MovieID);     
                   
                this.listBox1.Items.Add(String.Format("{0}: {1}", movieId.MovieName, userObject.Rating));
            }

        }

        private void AvgRating_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var movieName = bizTier.GetMovie(this.textAvgRating.Text);  // get movie name from GetMovie()
            // check if movie name exists
            if (movieName == null)
            {
                listBox1.Items.Add("Movie doesn't exist");
                return;
            }

            var movieId = bizTier.GetMovieDetail(Convert.ToInt32(movieName.MovieID));   // get all the details of movie from GetMovieDetail()

            this.listBox1.Items.Add(String.Format("{0:0.00}", movieId.AvgRating));      // we can get average rating from movieId which has all the details of movie

        }

        private void EachRating_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var movieName = bizTier.GetMovie(this.textEachRating.Text);     // get movie name from GetMovie()
            // check if movie name exist
            if (movieName == null)
            {
                listBox1.Items.Add("Movie doesn't exist");
                return;
            }

            var movieId = bizTier.GetMovieDetail(Convert.ToInt32(movieName.MovieID));   // get all the details of movie from GetMovieDetail
            var temp = movieId.NumReviews;  // get total reviews from movieId which has all details of movie
            int rate1 = 0, rate2 = 0, rate3 = 0, rate4 = 0, rate5 = 0;

            foreach (var movieObject in movieId.Reviews)
            {
                // count reviews for rating 1,2,3,4,5
                if (movieObject.Rating == 1)        
                    rate1++;
                else if (movieObject.Rating == 2)
                    rate2++;
                else if (movieObject.Rating == 3)
                    rate3++;
                else if (movieObject.Rating == 4)
                    rate4++;
                else if (movieObject.Rating == 5)
                    rate5++;
             }

            this.listBox1.Items.Add(String.Format("5: {0}", rate5));
            this.listBox1.Items.Add(String.Format("4: {0}", rate4));
            this.listBox1.Items.Add(String.Format("3: {0}", rate3));
            this.listBox1.Items.Add(String.Format("2: {0}", rate2));
            this.listBox1.Items.Add(String.Format("1: {0}", rate1));

            var total = rate1 + rate2 + rate3 + rate4 + rate5;  // total number of reviews

            this.listBox1.Items.Add(String.Format("Total: {0}", total));

        }

        private void MoviesByAvgRating_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var N = Convert.ToInt32(this.textMoviesByAvgRating.Text);
            // check if N < 1
            if (N < 1)
            {
                this.listBox1.Items.Add("Empty list is returned");
            }
            var moviesRating = bizTier.GetTopMoviesByAvgRating(N);   
           
            foreach (BusinessTier.Movie movies in moviesRating)
            {
                var movieDetail = bizTier.GetMovieDetail(movies.MovieID);       // get all the details of movie
                this.listBox1.Items.Add(String.Format("{0}: {1}", movies.MovieName, movieDetail.AvgRating));   // get movie name from movie class and average rating from movie detail
            }

        }

        private void TopProlificUsers_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var N = Convert.ToInt32(this.textProlificUsers.Text);
            // check if N < 1
            if (N < 1)
            {
                this.listBox1.Items.Add("Empty list is returned");
            }
            var userReviews = bizTier.GetTopUsersByNumReviews(N);

            foreach (BusinessTier.User users in userReviews)
            {
                var userDetail = bizTier.GetUserDetail(users.UserID);   // get all the details of users
                this.listBox1.Items.Add(String.Format("{0}: {1}", users.UserName, userDetail.NumReviews));  // get user name from User class and num of reviews from user detail
            }

        }

        private void InsertReview_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var movieName = bizTier.GetMovie(this.textInsertReview1.Text);  // get movie name from GetMovie()
            // check if movie name exist
            if (movieName == null)
            {
                listBox1.Items.Add("Insert failed, movie name not found");
                return;
            }

            var userName = bizTier.GetNamedUser(this.textInsertReview2.Text);   // get user name from GetNamedUser()
            // check if user name exist
            if (userName == null)
            {
                listBox1.Items.Add("Insert failed, user name not found");
                return;
            }

            var Rating = Convert.ToInt32(this.textInsertReview3.Text);
            // check if the rating is less than 1 or greater than 5
            if (Rating < 1 || Rating > 5)
            {
                listBox1.Items.Add("Insert failed, value of rating is not in range 1-5");
                return;
            }

            var movieId = movieName.MovieID;    // get movie id from movie name
            var userId = userName.UserID;       // get user id from user name
            var insertReview = bizTier.AddReview(movieId, userId, Rating);
            // check if the insert is successful
            if (insertReview != null)
            {
                listBox1.Items.Add("Insert Successful");
                listBox1.Items.Add(String.Format("{0}: {1}: {2}", movieName.MovieID, userName.UserID, Rating));
                listBox1.Items.Add(String.Format("Review's New ID: {0}", insertReview.ReviewID));
                return;
            }

        }

        private void TopReviewedMovies_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var N = Convert.ToInt32(this.textReviewedMovies.Text);
            // check if N < 1
            if (N < 1)
            {
                this.listBox1.Items.Add("Empty list is returned");
            }
            var movieReviews = bizTier.GetTopMoviesByNumReviews(N);

            foreach (BusinessTier.Movie movies in movieReviews)
            {
                var movieId = bizTier.GetMovieDetail(movies.MovieID);   // get all the details of movie
                var numRev = movieId.NumReviews;                        // get total reviews from movieId
                this.listBox1.Items.Add(String.Format("{0}: {1}", movies.MovieName, numRev));
            }

        }

        private void GetMovieName_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var movieId = bizTier.GetMovie(Convert.ToInt32(this.textMovieID.Text));     // get movie id from GetMovie()
            // check if the movie id exist
            if (movieId == null)
            {
                listBox1.Items.Add("Movie ID doesn't exist");
                return;
            }

            // get movie id and movie name from movieId which has access to all movie objects
            this.listBox1.Items.Add(String.Format("Movie ID: {0}", movieId.MovieID));
            this.listBox1.Items.Add(String.Format("Movie Name: {0}", movieId.MovieName));

        }

        private void GetUserName_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            //
            // Check to make sure database filename in text box actually exists:
            //
            string filename = this.txtFilename.Text;

            if (!fileExists(filename))
                return;

            BusinessTier.Business bizTier = new BusinessTier.Business(filename);

            var userId = bizTier.GetUser(Convert.ToInt32(this.textUserID.Text));    // get user id from GetUser()
            // check if user id exist
            if (userId == null)
            {
                listBox1.Items.Add("User ID doesn't exist");
                return;
            }

            // get user id and user name from userId which has access to all user objects
            this.listBox1.Items.Add(String.Format("User ID: {0}", userId.UserID));
            this.listBox1.Items.Add(String.Format("User Name: {0}", userId.UserName));

        }
    }
}



