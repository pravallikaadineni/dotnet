use shopping
create table member(
Member_Id	Numeric(5),
Member_Name	Char(25),
Acc_Open_Date date,
Max_Books_Allowed numeric(2),
Penalty_Amount numeric(7,2)                                               
)
create table book(
Book_No numeric(6),  
Book_Name varchar(30),
Author char(30),
cost numeric(7,2),
Category Char(10),
)

create table issue(
Lib_Issue_Id Numeric(10),
Book_No	Numeric(6),
Member_Id	Numeric(5),
Issue_Date	Date,
Return_date	Date,
)
select*from member
select*from book
select*from issue
alter table issue

add  comments char(100)

alter table issue

add  refernce char(30)
alter table issue
drop  column refernce
insert into member values(1,'richa sharma','2005-12-05',5,50)
insert into member values(2,'garima sen','2022-09-20',3,null)
insert into member values(3,'saleem','2022-09-20',34,23)
insert into member values(4,'varma','2005-1-05',55,5)
insert into member values(5,'harini','2022-05-15',30,null)
select*from member
insert into member values(1,'richa sharma','2005-12-05',110,50)
insert into member values(2,'garima sen','2022-09-20',3,null)
insert into member values(3,'saleem','2022-09-20',34,23)
insert into member values(4,'varma','2005-1-05',55,5)
insert into member values(5,'harini','2022-05-15',30,null)
select * into Member101 from Member
select*from Member101
select * into Member102 from Member where 1 = 2
select*from Member102

insert into book values(101,'let us c','dennis ritche',450,'system')
insert into book values(102,'oracle complete ref','loni',550,'database')
insert into book values(103,'mastering sql','loni',250,'database')
insert into book values(104,'PL sql ref','scott urman',750,'database')
select*from book
select*into book101 from book
select*from book101
select*into book102 from book where 1=2
select*from book102
select*into book103 from book
select*from book103
insert into book values(105,  'National Geographic', 'Adis Scott', 1000,  'Science')
select*from book
update book
set cost=300 , Category='RDBMS'
where Book_No=103
select*from book
alter table issue
drop column comments

insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7001',101,1,'2022-09-21')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7002',102,2,'2022-08-21')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7003',103,1,'2022-07-21')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7004',104,1,'2022-08-4')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7005',105,2,'2022-05-21')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7006',106,3,'2022-01-21')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7007',107,6,'2022-10-21')
insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values('7008',108,5,'2022-05-21')
select*from issue








