--foreign key is something using which you can link two different tables together". "It is a column in one table, that is linked to the primary key of another table"

select * from Customer
select * from Item
select * from Orders

DELETE from Customer;

delete from Catagory
--Drop
drop table Catagory;
--Create
create table Customer
(
Cus_ID INT NOT NULL Identity (1,1),
Customer_Name VARCHAR(20),
Contact INT,
Address VARCHAR(100),
primary key (Cus_ID)
)

--Insert
insert into Customer (Customer_Name,Contact,Address)values ('Abir', '45554', 'Dhaka');

--Select 
Select * from Orders

UPDATE Customer SET Customer_Name = 'Tarek', Contact='545454', Address ='assafdf' Where Cus_ID=28;

--delete
Delete Customer where Cus_ID =1;
Delete Item where ItemID =1;
Delete Orders where OrderID =1
--select
Select * from  Customer
Select * from  Item
Select * from  Orders

--Create
create table Item
(
ItemID INT NOT NULL Identity (1,1),
ItemName VARCHAR(20),
price INT,
primary key (ItemID)
)

--Insert
insert into Item 
(ItemName,
price 
)
values 
(
'reguler', 
'90'
);

--Create
create table Orders
(
OrderID INT NOT NULL Identity (1,1),
Cus_ID INT,
ItemID INT,
Queintity INT, 
primary key (OrderID),
Foreign key (Cus_ID) references Customer(Cus_ID),
Foreign key (ItemID) references Item(ItemID)
)

insert into Orders 
(Cus_ID,
ItemID,
Queintity
)
values 
(
'3', 
'3',
'4'
);

UPDATE
Orders
SET
Queintity = '3'
Where
OrderID=3;

Select Customer_Name,Contact from Customer where Cus_ID < 10


create table enrollment 
(
e_id INT  NOT NULL Identity (1,1), 
e_StudentID integer, 
e_CourseID integer, 
e_year YEAR, 
PRIMARY KEY (e_id), 
FOREIGN KEY (e_StudentID) REFERENCES students(s_id), 
FOREIGN KEY (e_CourseID) REFERENCES courses(c_id)
);

select * from students where s_firstname='Mohan' AND s_phone='7404076892';

ALTER TABLE students ADD PRIMARY KEY (s_id);
ALTER TABLE students ADD CONSTRAINT pk_students PRIMARY KEY (s_phone,s_firstname);


--Query OK, 0 rows affected (0.10 sec)

create table students 
(
s_firstname VARCHAR(30) NOT NULL, 
s_lastname VARCHAR(30) NOT NULL, 
s_email VARCHAR(40), 
s_phone BIGINT(10) NOT NULL, 
PRIMARY KEY (s_phone, s_firstname));

--Query OK, 0 rows affected (0.09 sec)

insert into students 
(s_firstname,
s_lastname,
s_email,
s_phone) 
values 
(
'Shankar', 
'Bhat', 
'shankar@example.com', 
'7303075409'
);

Query OK, 1 row affected, 1 warning (0.02 sec)


insert into enrollment (e_StudentID, e_CourseID, e_year) values (5, 1, 2016);
ERROR 1452 (23000): Cannot add or update a child row: a foreign key constraint fails (`university`.`enrollment`, CONSTRAINT `enrollment_ibfk_1` FOREIGN KEY (`e_StudentID`) REFERENCES `students` (`s_id`))