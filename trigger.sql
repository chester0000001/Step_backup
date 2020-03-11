create trigger DelFilm
on Films
instead of delete
as
begin
declare @name nvarchar(50), @FilmId int
Select @name = Name from deleted
Select @FilmId = Id from Films where Name = @name

Delete from Session where FilmId = @FilmId
Delete from Films where Name = @name

end