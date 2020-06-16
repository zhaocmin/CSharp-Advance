--drop table MyDay;
--drop table Important;
--drop table Planed;
--drop table AssignToYou;
--drop table Task;
--drop table users;
--CREATE TABLE Users
--( 
--  Id int PRIMARY KEY,
--  username varchar(25) NOT NULL,
--  password varchar(30) NOT NULL

--);
--CREATE TABLE MyDay (
--    Id int  IDENTITY(1,1) PRIMARY KEY  NOT NULL,
--	UserId int,
--    MyDayText varchar(800),
--	FOREIGN KEY (UserId) REFERENCES Users(Id)
--);
--CREATE TABLE Important(
--    Id int  IDENTITY(1,1) PRIMARY KEY  NOT NULL,
--	UserId int,
--    ImportantText varchar(800),
--	FOREIGN KEY (UserId) REFERENCES Users(Id)
--);
--CREATE TABLE Planed (
--    Id int  IDENTITY(1,1) PRIMARY KEY  NOT NULL,
--	UserId int,
--    PlanedText varchar(800),
--	FOREIGN KEY (UserId) REFERENCES Users(Id)
--);
--CREATE TABLE AssignToYou (
--    Id int  IDENTITY(1,1) PRIMARY KEY  NOT NULL,
--	UserId int,
--    AssignToYouText varchar(800),
--	FOREIGN KEY (UserId) REFERENCES Users(Id)
--);
--CREATE TABLE Task (
--    Id int  IDENTITY(1,1) PRIMARY KEY  NOT NULL,
--	UserId int,
--    TaskText varchar(800),
--	FOREIGN KEY (UserId) REFERENCES Users(Id)
--);


--insert Users values(1,'Alex','alex');

--insert Users values(2,'Max','max');
--insert Task(UserId,TaskText) values(1,'Task1 for alex');
--insert Task(UserId,TaskText) values(1,'Task2 for Alex');
--insert Task(UserId,TaskText) values(1,'Task3 for Alex');
--insert Task(UserId,TaskText) values(2,'Task1 for Max');
--insert Task(UserId,TaskText) values(2,'Task2 for Max');
--insert Task(UserId,TaskText) values(2,'Task3 for Max');
--insert Task(UserId,TaskText) values(2,'Task4 for Max');


--insert MyDay(UserId,MyDayText) values(1,'MyDayText1 for alex');
--insert MyDay(UserId,MyDayText) values(1,'MyDayText2 for Alex');
--insert MyDay(UserId,MyDayText) values(1,'MyDayText3 for Alex');
--insert MyDay(UserId,MyDayText) values(2,'MyDayText1 for Max');
--insert MyDay(UserId,MyDayText) values(2,'MyDayText2 for Max');
--insert MyDay(UserId,MyDayText) values(2,'MyDayText3 for Max');
--insert MyDay(UserId,MyDayText) values(2,'MyDayText4 for Max');
--insert Important(UserId,ImportantText) values(1,'ImportantText1 for Alex');
--insert Important(UserId,ImportantText) values(1,'ImportantText2 for Alex');

--insert Important(UserId,ImportantText) values(2,'ImportantText1 for Max');
--insert Important(UserId,ImportantText) values(2,'ImportantText2 for Max');
--insert Important(UserId,ImportantText) values(2,'ImportantText3 for Max');
--insert Important(UserId,ImportantText) values(2,'ImportantText4 for Max');
--insert Important(UserId,ImportantText) values(2,'ImportantText5 for Max');

--insert AssignToYou(UserId,AssignToYouText) values(1,'AssignToYou1 for Alex');
--insert AssignToYou(UserId,AssignToYouText) values(1,'AssignToYou2 for Alex');

--insert AssignToYou(UserId,AssignToYouText) values(1,'AssignToYou3 for Alex');
--insert AssignToYou(UserId,AssignToYouText) values(1,'AssignToYou4 for Alex');
--insert AssignToYou(UserId,AssignToYouText) values(1,'AssignToYou5 for Alex');
--insert AssignToYou(UserId,AssignToYouText) values(1,'AssignToYou6 for Alex');
--insert AssignToYou(UserId,AssignToYouText) values(2,'AssignToYou5 for Max');

