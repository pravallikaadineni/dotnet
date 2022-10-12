use shopping
select*from issue
update member
set Penalty_Amount=100
where member_name='garima sen'
select*from member

update issue
set Return_date='2022-08-19'
where Lib_Issue_Id=7004
update issue
set Return_date='2026-07-19'
where Lib_Issue_Id=7005



delete from Issue
where Member_Id=1 And Issue_Date < '2022-02-09'

delete from book
where Category!='RDBMS'And  Category='database '
select*from book
drop table Member101
drop table book101
select*from member
select*from book
select*from issue

select*from member where Acc_Open_Date='2005-12-05'
select*from book where Author='loni' AND cost<600
select*from book
select*from issue where Return_date!='2022-08-19'
select*from issue where Return_date!='2022-07-19'

select*from issue

update issue
set Return_date='2006-12-31'
where Member_Id!=7005 and  Member_Id!=7006

select*from issue where (Issue_Date)-(Return_date)>30;
select*from issue
 select * from Book
where Cost between 500 and 700 and Category= 'RDBMS'
 select*from book
 SELECT * FROM Book 
WHERE category in ('Science','Database', 'Fiction','Management')
select*from member order by Penalty_Amount desc
select*from member order by Penalty_Amount
select * from book order by category asc,cost desc
select * from book where book_name like'%SQL%'
SELECT * FROM MEMBER where MEMBER_NAME like'R%'OR
MEMBER_NAME LIKE'G%' AND MEMBER_NAME LIKE '%I%'

select upper(book_name) from book
order by book_name desc;

select * from issue order by issue_date

SELECT SUM(MAX_BOOKS_ALLOWED) FROM MEMBER WHERE
MEMBER_ID=1
 select sum(penalty_amount) from member
  select sum(cost) from book
  where Category='system'

   select min(cost) from book
   select Issue_Date from issue
   where Lib_Issue_Id=7001

   select avg(cost) from book
   where Category='system'

   


   select*from book