create  database schoolDB
use schoolDB

create table class
(
classno int primary key,

)
create table student
(
studid int primary key,
studname varchar(20),
)
create table subject
(
subid int primary key,
subname varchar(20),

)
alter table subject
add classno int constraint fk_prfk foreign key references class(classno)

alter table class
add studid int constraint fk_stfk foreign key references student(studid)

alter table class
add subid int constraint fk_sufk foreign key references subject(subid)

alter table student
add subid int constraint fk_sutdfk foreign key references subject(subid)