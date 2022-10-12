create database shopping
use shopping
create table customer(
custid int,
custname varchar(20),
city varchar(20),
state varchar(20)
)
create table products(
productid int,
productname varchar(20),
unitprice float,
unitofmeasur float,
qtyinstock int
)
create table sales_header(
invno int,
invdate date,
invamt float,
dispercent float
)
create table sales_details(
invno int,
custid int,
productid int,
qtysold int
)
drop table sales_details

create table sales_details(
invno int primary key,
custid int,
productid int,
qtysold int
)
alter table sales_details
add productid int foreign key references productid(productid)
 
 alter table sales_details
 drop column qtysold

