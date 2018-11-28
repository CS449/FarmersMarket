CREATE DATABASE farmers_Market;
use farmers_Market;

--Vendor Info Table
CREATE TABLE Vendor_Info (
VendorID INT NOT NULL, 
First VARCHAR(20) NOT NULL, 
Last VARCHAR(20) NOT NULL, 
Active INT NOT NULL, 
StoreName VARCHAR(20)NOT NULL,
LocationID INT,
AcceptsCard INT,
PRIMARY KEY (VendorID),
foreign key (LocationID) references LocationPrice(LocationID));
INSERT INTO Vendor_Info(VendorID,First,Last,Active,StoreName,LocationID,AcceptsCard)
VALUES(1,'John','Smith',0,'JohnsApples',1,1)

drop table Vendor_Info
--Inventory Table
CREATE Table Inventory_Table(
ProductID int,
VendorID int,
ProductName VarChar(20),
Num_in_Stock int,
Primary Key (ProductID),
foreign key (VendorID)references Vendor_Info(VendorID));
INSERT INTO Inventory_Table(ProductID,VendorID,ProductName,Num_in_Stock)
VALUES(1,3,'Apples',15)
DROP TABLE Inventory_Table

--Vandoor transaction history related table 
CREATE Table VendorTransHistory(
TransactionID int not null,
VendorID int not null,
ProductName VarChar(20) not null,
Date DateTime not null,
Price money not null,
ProductID int,
Primary Key (TransactionID),
foreign key(ProductID)references Inventory_Table (ProductID));
INSERT INTO VendorTransHistory(TransactionID,VendorID,ProductName,Date,Price,ProductID)
VALUES(123,5,'Apples',10/29/2018,18,15);
DROP Table VendorTransHistory
--Customer table for CC Trans only
CREATE Table CustomerTable(
CustomerID INT not NULL,
First VarChar(20),
Last  VarChar(20),
CardNumber VarChar(4) not null,
Primary Key (CustomerID));
INSERT INTO CustomerTable(CustomerID,First,Last,CardNumber)
VALUES(4,'John','Smith',1234);

--Location pricing Table 
CREATE TABLE LocationPrice(
LocationID INT NOT NULL,
Section CHAR(2) NOT NULL,
BoothNumber INT NOT NULL,
Price int NOT NULL,
Primary Key (LocationID));


--Credit card transaction table
CREATE TABLE CCtransaction(
transID INT,
MethodofPayment bit,
CustomerID int ,
CreditNumhash nvarchar(max),
Salt nvarchar(50),
Primary Key(transID),
Foreign Key(CustomerID)references CustomerTable(CustomerID));
drop table CCTransaction 
