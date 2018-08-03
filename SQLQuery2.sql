select UserID, UserName, Occupation from Users
Order By UserName ASC;

--provide the average review for a movie name entered or selected by the user.
select ROUND(AVG(CONVERT(float,Rating)), 2) from Reviews INNER JOIN Movies on
Movies.MovieID = Reviews.MovieID where MovieName = 'The Seventh Seal'

select Rating, count(*) as Reviews from reviews inner join Movies on 
Movies.MovieID=Reviews.MovieID where MovieName = 'Finding Nemo'
group by Rating
order by rating DESC;




