create table Users
(
Id int not null identity primary key,
UserLogin nvarchar(50) unique check(UserLogin !=''),
UserPass nvarchar(50) check(UserPass !='')
)
