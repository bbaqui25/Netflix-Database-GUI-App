namespace NetflixMovieData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.AllMovies = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AllUsers = new System.Windows.Forms.Button();
            this.GetMovieReviews = new System.Windows.Forms.Button();
            this.textMovieReviews = new System.Windows.Forms.TextBox();
            this.GetUserReviews = new System.Windows.Forms.Button();
            this.textUserReviews = new System.Windows.Forms.TextBox();
            this.AvgRating = new System.Windows.Forms.Button();
            this.EachRating = new System.Windows.Forms.Button();
            this.textEachRating = new System.Windows.Forms.TextBox();
            this.textAvgRating = new System.Windows.Forms.TextBox();
            this.MoviesByAvgRating = new System.Windows.Forms.Button();
            this.InsertReview = new System.Windows.Forms.Button();
            this.textInsertReview1 = new System.Windows.Forms.TextBox();
            this.textMoviesByAvgRating = new System.Windows.Forms.TextBox();
            this.TopProlificUsers = new System.Windows.Forms.Button();
            this.textProlificUsers = new System.Windows.Forms.TextBox();
            this.textInsertReview2 = new System.Windows.Forms.TextBox();
            this.textInsertReview3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textReviewedMovies = new System.Windows.Forms.TextBox();
            this.TopReviewedMovies = new System.Windows.Forms.Button();
            this.GetMovieName = new System.Windows.Forms.Button();
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.labelMovieID = new System.Windows.Forms.Label();
            this.GetUserName = new System.Windows.Forms.Button();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFilename.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(190, 432);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(868, 26);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.Text = "netflix.mdf\r\n";
            // 
            // AllMovies
            // 
            this.AllMovies.BackColor = System.Drawing.Color.Fuchsia;
            this.AllMovies.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllMovies.Location = new System.Drawing.Point(29, 12);
            this.AllMovies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AllMovies.Name = "AllMovies";
            this.AllMovies.Size = new System.Drawing.Size(155, 27);
            this.AllMovies.TabIndex = 1;
            this.AllMovies.Text = "All Movies";
            this.AllMovies.UseVisualStyleBackColor = false;
            this.AllMovies.Click += new System.EventHandler(this.AllMovies_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(656, 17);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 394);
            this.listBox1.TabIndex = 2;
            // 
            // AllUsers
            // 
            this.AllUsers.BackColor = System.Drawing.Color.MediumOrchid;
            this.AllUsers.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllUsers.Location = new System.Drawing.Point(29, 45);
            this.AllUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(155, 27);
            this.AllUsers.TabIndex = 3;
            this.AllUsers.Text = "All Users";
            this.AllUsers.UseVisualStyleBackColor = false;
            this.AllUsers.Click += new System.EventHandler(this.AllUsers_Click);
            // 
            // GetMovieReviews
            // 
            this.GetMovieReviews.BackColor = System.Drawing.Color.Fuchsia;
            this.GetMovieReviews.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetMovieReviews.Location = new System.Drawing.Point(29, 78);
            this.GetMovieReviews.Name = "GetMovieReviews";
            this.GetMovieReviews.Size = new System.Drawing.Size(155, 39);
            this.GetMovieReviews.TabIndex = 4;
            this.GetMovieReviews.Text = "Get Movie Reviews";
            this.GetMovieReviews.UseVisualStyleBackColor = false;
            this.GetMovieReviews.Click += new System.EventHandler(this.GetMovieReviews_Click);
            // 
            // textMovieReviews
            // 
            this.textMovieReviews.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMovieReviews.Location = new System.Drawing.Point(190, 86);
            this.textMovieReviews.Name = "textMovieReviews";
            this.textMovieReviews.Size = new System.Drawing.Size(122, 23);
            this.textMovieReviews.TabIndex = 5;
            // 
            // GetUserReviews
            // 
            this.GetUserReviews.BackColor = System.Drawing.Color.MediumOrchid;
            this.GetUserReviews.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUserReviews.Location = new System.Drawing.Point(29, 123);
            this.GetUserReviews.Name = "GetUserReviews";
            this.GetUserReviews.Size = new System.Drawing.Size(155, 37);
            this.GetUserReviews.TabIndex = 6;
            this.GetUserReviews.Text = "Get User Reviews";
            this.GetUserReviews.UseVisualStyleBackColor = false;
            this.GetUserReviews.Click += new System.EventHandler(this.GetUserReviews_Click);
            // 
            // textUserReviews
            // 
            this.textUserReviews.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserReviews.Location = new System.Drawing.Point(190, 130);
            this.textUserReviews.Name = "textUserReviews";
            this.textUserReviews.Size = new System.Drawing.Size(122, 23);
            this.textUserReviews.TabIndex = 7;
            // 
            // AvgRating
            // 
            this.AvgRating.BackColor = System.Drawing.Color.MediumOrchid;
            this.AvgRating.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgRating.Location = new System.Drawing.Point(29, 211);
            this.AvgRating.Name = "AvgRating";
            this.AvgRating.Size = new System.Drawing.Size(155, 29);
            this.AvgRating.TabIndex = 8;
            this.AvgRating.Text = "Average Rating";
            this.AvgRating.UseVisualStyleBackColor = false;
            this.AvgRating.Click += new System.EventHandler(this.AvgRating_Click);
            // 
            // EachRating
            // 
            this.EachRating.BackColor = System.Drawing.Color.Fuchsia;
            this.EachRating.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EachRating.Location = new System.Drawing.Point(29, 246);
            this.EachRating.Name = "EachRating";
            this.EachRating.Size = new System.Drawing.Size(155, 26);
            this.EachRating.TabIndex = 10;
            this.EachRating.Text = "Each Rating";
            this.EachRating.UseVisualStyleBackColor = false;
            this.EachRating.Click += new System.EventHandler(this.EachRating_Click);
            // 
            // textEachRating
            // 
            this.textEachRating.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEachRating.Location = new System.Drawing.Point(190, 246);
            this.textEachRating.Name = "textEachRating";
            this.textEachRating.Size = new System.Drawing.Size(122, 23);
            this.textEachRating.TabIndex = 11;
            // 
            // textAvgRating
            // 
            this.textAvgRating.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAvgRating.Location = new System.Drawing.Point(190, 211);
            this.textAvgRating.Name = "textAvgRating";
            this.textAvgRating.Size = new System.Drawing.Size(122, 23);
            this.textAvgRating.TabIndex = 12;
            // 
            // MoviesByAvgRating
            // 
            this.MoviesByAvgRating.BackColor = System.Drawing.Color.MediumOrchid;
            this.MoviesByAvgRating.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesByAvgRating.Location = new System.Drawing.Point(29, 278);
            this.MoviesByAvgRating.Name = "MoviesByAvgRating";
            this.MoviesByAvgRating.Size = new System.Drawing.Size(155, 46);
            this.MoviesByAvgRating.TabIndex = 13;
            this.MoviesByAvgRating.Text = "Top-N Movies By Avg Rating";
            this.MoviesByAvgRating.UseVisualStyleBackColor = false;
            this.MoviesByAvgRating.Click += new System.EventHandler(this.MoviesByAvgRating_Click);
            // 
            // InsertReview
            // 
            this.InsertReview.BackColor = System.Drawing.Color.Fuchsia;
            this.InsertReview.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertReview.Location = new System.Drawing.Point(29, 177);
            this.InsertReview.Name = "InsertReview";
            this.InsertReview.Size = new System.Drawing.Size(155, 28);
            this.InsertReview.TabIndex = 14;
            this.InsertReview.Text = "Insert Review";
            this.InsertReview.UseVisualStyleBackColor = false;
            this.InsertReview.Click += new System.EventHandler(this.InsertReview_Click);
            // 
            // textInsertReview1
            // 
            this.textInsertReview1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInsertReview1.Location = new System.Drawing.Point(190, 180);
            this.textInsertReview1.Name = "textInsertReview1";
            this.textInsertReview1.Size = new System.Drawing.Size(122, 23);
            this.textInsertReview1.TabIndex = 15;
            // 
            // textMoviesByAvgRating
            // 
            this.textMoviesByAvgRating.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMoviesByAvgRating.Location = new System.Drawing.Point(190, 290);
            this.textMoviesByAvgRating.Name = "textMoviesByAvgRating";
            this.textMoviesByAvgRating.Size = new System.Drawing.Size(122, 23);
            this.textMoviesByAvgRating.TabIndex = 16;
            // 
            // TopProlificUsers
            // 
            this.TopProlificUsers.BackColor = System.Drawing.Color.Fuchsia;
            this.TopProlificUsers.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopProlificUsers.Location = new System.Drawing.Point(29, 330);
            this.TopProlificUsers.Name = "TopProlificUsers";
            this.TopProlificUsers.Size = new System.Drawing.Size(155, 45);
            this.TopProlificUsers.TabIndex = 17;
            this.TopProlificUsers.Text = "Top-N Prolific Users";
            this.TopProlificUsers.UseVisualStyleBackColor = false;
            this.TopProlificUsers.Click += new System.EventHandler(this.TopProlificUsers_Click);
            // 
            // textProlificUsers
            // 
            this.textProlificUsers.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProlificUsers.Location = new System.Drawing.Point(190, 341);
            this.textProlificUsers.Name = "textProlificUsers";
            this.textProlificUsers.Size = new System.Drawing.Size(122, 23);
            this.textProlificUsers.TabIndex = 18;
            // 
            // textInsertReview2
            // 
            this.textInsertReview2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInsertReview2.Location = new System.Drawing.Point(318, 180);
            this.textInsertReview2.Name = "textInsertReview2";
            this.textInsertReview2.Size = new System.Drawing.Size(88, 23);
            this.textInsertReview2.TabIndex = 19;
            // 
            // textInsertReview3
            // 
            this.textInsertReview3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInsertReview3.Location = new System.Drawing.Point(412, 180);
            this.textInsertReview3.Name = "textInsertReview3";
            this.textInsertReview3.Size = new System.Drawing.Size(68, 23);
            this.textInsertReview3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(209, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(325, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rating";
            // 
            // textReviewedMovies
            // 
            this.textReviewedMovies.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReviewedMovies.Location = new System.Drawing.Point(190, 398);
            this.textReviewedMovies.Name = "textReviewedMovies";
            this.textReviewedMovies.Size = new System.Drawing.Size(122, 23);
            this.textReviewedMovies.TabIndex = 25;
            // 
            // TopReviewedMovies
            // 
            this.TopReviewedMovies.BackColor = System.Drawing.Color.MediumOrchid;
            this.TopReviewedMovies.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopReviewedMovies.Location = new System.Drawing.Point(29, 381);
            this.TopReviewedMovies.Name = "TopReviewedMovies";
            this.TopReviewedMovies.Size = new System.Drawing.Size(155, 56);
            this.TopReviewedMovies.TabIndex = 26;
            this.TopReviewedMovies.Text = "Top-N Reviewed Movies";
            this.TopReviewedMovies.UseVisualStyleBackColor = false;
            this.TopReviewedMovies.Click += new System.EventHandler(this.TopReviewedMovies_Click);
            // 
            // GetMovieName
            // 
            this.GetMovieName.BackColor = System.Drawing.Color.MediumOrchid;
            this.GetMovieName.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetMovieName.Location = new System.Drawing.Point(386, 297);
            this.GetMovieName.Name = "GetMovieName";
            this.GetMovieName.Size = new System.Drawing.Size(139, 27);
            this.GetMovieName.TabIndex = 28;
            this.GetMovieName.Text = "Get Movie Name ";
            this.GetMovieName.UseVisualStyleBackColor = false;
            this.GetMovieName.Click += new System.EventHandler(this.GetMovieName_Click);
            // 
            // textMovieID
            // 
            this.textMovieID.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMovieID.Location = new System.Drawing.Point(531, 299);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(100, 23);
            this.textMovieID.TabIndex = 29;
            // 
            // labelMovieID
            // 
            this.labelMovieID.AutoSize = true;
            this.labelMovieID.BackColor = System.Drawing.Color.Black;
            this.labelMovieID.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieID.ForeColor = System.Drawing.Color.White;
            this.labelMovieID.Location = new System.Drawing.Point(549, 280);
            this.labelMovieID.Name = "labelMovieID";
            this.labelMovieID.Size = new System.Drawing.Size(58, 15);
            this.labelMovieID.TabIndex = 30;
            this.labelMovieID.Text = "Movie ID";
            // 
            // GetUserName
            // 
            this.GetUserName.BackColor = System.Drawing.Color.Fuchsia;
            this.GetUserName.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUserName.Location = new System.Drawing.Point(386, 351);
            this.GetUserName.Name = "GetUserName";
            this.GetUserName.Size = new System.Drawing.Size(139, 30);
            this.GetUserName.TabIndex = 31;
            this.GetUserName.Text = "Get User Name";
            this.GetUserName.UseVisualStyleBackColor = false;
            this.GetUserName.Click += new System.EventHandler(this.GetUserName_Click);
            // 
            // textUserID
            // 
            this.textUserID.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserID.Location = new System.Drawing.Point(531, 356);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(100, 23);
            this.textUserID.TabIndex = 32;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.BackColor = System.Drawing.Color.Black;
            this.labelUserID.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.White;
            this.labelUserID.Location = new System.Drawing.Point(558, 338);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(49, 15);
            this.labelUserID.TabIndex = 33;
            this.labelUserID.Text = "User ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1060, 460);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.GetUserName);
            this.Controls.Add(this.labelMovieID);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.GetMovieName);
            this.Controls.Add(this.TopReviewedMovies);
            this.Controls.Add(this.textReviewedMovies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInsertReview3);
            this.Controls.Add(this.textInsertReview2);
            this.Controls.Add(this.textProlificUsers);
            this.Controls.Add(this.TopProlificUsers);
            this.Controls.Add(this.textMoviesByAvgRating);
            this.Controls.Add(this.textInsertReview1);
            this.Controls.Add(this.InsertReview);
            this.Controls.Add(this.MoviesByAvgRating);
            this.Controls.Add(this.textAvgRating);
            this.Controls.Add(this.textEachRating);
            this.Controls.Add(this.EachRating);
            this.Controls.Add(this.AvgRating);
            this.Controls.Add(this.textUserReviews);
            this.Controls.Add(this.GetUserReviews);
            this.Controls.Add(this.textMovieReviews);
            this.Controls.Add(this.GetMovieReviews);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AllMovies);
            this.Controls.Add(this.txtFilename);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Netflix Movie Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button AllMovies;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AllUsers;
        private System.Windows.Forms.Button GetMovieReviews;
        private System.Windows.Forms.TextBox textMovieReviews;
        private System.Windows.Forms.Button GetUserReviews;
        private System.Windows.Forms.TextBox textUserReviews;
        private System.Windows.Forms.Button AvgRating;
        private System.Windows.Forms.Button EachRating;
        private System.Windows.Forms.TextBox textEachRating;
        private System.Windows.Forms.TextBox textAvgRating;
        private System.Windows.Forms.Button MoviesByAvgRating;
        private System.Windows.Forms.Button InsertReview;
        private System.Windows.Forms.TextBox textInsertReview1;
        private System.Windows.Forms.TextBox textMoviesByAvgRating;
        private System.Windows.Forms.Button TopProlificUsers;
        private System.Windows.Forms.TextBox textProlificUsers;
        private System.Windows.Forms.TextBox textInsertReview2;
        private System.Windows.Forms.TextBox textInsertReview3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textReviewedMovies;
        private System.Windows.Forms.Button TopReviewedMovies;
        private System.Windows.Forms.Button GetMovieName;
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.Label labelMovieID;
        private System.Windows.Forms.Button GetUserName;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Label labelUserID;
    }
}

