select UserID, Rating from Reviews
inner join Movies on Reviews.MovieID = Movies.MovieID
where MovieName = 'The Seventh Seal'
Order by Rating DESC, UserID ASC