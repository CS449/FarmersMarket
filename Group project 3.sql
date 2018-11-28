Use James;
create table vendor(
vendorID  INT  not null,
firstname  varchar(30) null,
lastname varchar(45) null,
phone varchar(10)  null,
active char(1)  null,

primary key (vendorID)

);
drop table vendor;
create table vendor(
vendorID  INT  not null,
firstname  varchar(20) null,
lastname varchar(20) null,
phone varchar(10)  null,
active int not  null,
locationID char(5) null,
primary key (vendorID)

);
drop table vendor;
create table vendor(
vendorID  INT  not null,
firstname  varchar(20) null,
lastname varchar(20) null,
phone varchar(10)  null,
acceptsCards int not  null,
locationID char(5) not null,
primary key (vendorID),
foreign key (locationID) references location(locationID)


);
Alter  table vendor
Add Column active int after vendorID;
Alter table vendor
Add column Storename varchar(20) not null after active;
insert into vendor(vendorID, active, storename, firstname, lastname, acceptsCards, locationID) Values (1,0,'Johns Apples', 'John', 'Smith', 1, 1);
create table inventory(
ProductID int,
VendorID int,
Productname varchar(20),
Num_in_stock int,
primary key(productID),
foreign key(vendorID) references vendor(vendorID)






);
insert into inventory(ProductID, VendorID, Productname, Num_in_stock) Values(1,3, 'Apples', 15);
create table vendortransactionhistory(
transactionID int not null,
VendorID int not null,
ProductName varchar(20) not null,
price Dec(2)  not null,
ProductID int,
primary key (transactionID),
foreign key (ProductID) references inventory(ProductID)







);
Alter table vendortransactionhistory
Add Column Date datetime after ProductName;
insert into vendortransactionhistory(TransactionID, VendorID, ProductName, Date, price, ProductID) Values (123, 5, 'Apples', now(), 18.00, 2);
create table customer(
CustomerID int not null,
First varchar(20), 
Last varchar(20),
CardNumber varchar(4) not null,
primary key (CustomerID)







);
insert into customer (CustomerID, First, Last, CardNumber) Values ( 4, 'John', 'Smith', '1234');
create table locationpricing(
locationID int not null,
Section char(2) not null,
Boothnumber int not null,
primary key (locationID)


);