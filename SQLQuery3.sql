select UserName from Users

--get all reviews entered by a particular Netflix user. 
--You can list all the user names in a listbox and allow the user to select a name from the list, 
--or you can have the user input a username into a textbox. 
--When getting reviews for a user, display the movie name and rating for each review. 
--Display the results in ascending order by movie name.
select MovieName,Rating from Movies INNER JOIN (select Rating, MovieID from Reviews inner join Users on Users.UserID=Reviews.UserID where UserName='Pooja') as T
on Movies.MovieID=T.MovieID
order by MovieName ASC
