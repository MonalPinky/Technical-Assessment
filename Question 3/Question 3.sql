use master;
Go
Create database TehnicalAssessment;
use TehnicalAssessment;
Go

Create table [ContactDetails](
ID int identity(1,1) Primary key, 
[Description] varchar(10),
IsActive bit,
OrderNumber int,
AreaCode varchar(3),
Telephone varchar(8)
)
--Added more for the fun of it
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('Pete',0,3,'012','3488457');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('Pete',1,3,'012','3488457');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('Izak',1,5,'023','234223');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('Christo',1,3,'032','2342323');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('Tania',0,2,'042','23423422');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('Tatum',1,4,'019','5674225');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('x',0,4,'019','5674225');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('hidexthe',0,4,'019','5674225');
insert into [ContactDetails](Description,IsActive,OrderNumber,AreaCode,Telephone)
values('letshidex',0,4,'019','5674225');
GO

---Asumstion made active is 1
select * from ContactDetails
--•	Selects all entries that are active with the Area Code 012
select * from ContactDetails where AreaCode = '012' and IsActive = 1;

---•	Set all entries with a Description containing the letter x to active, except entries with an Order number smaller than or equal to 50
--using wildcard caracter so will check everywhere where there is an x and changes active to 1#
begin tran
	update ContactDetails set IsActive =1 where Description like '%x%'; 
commit tran

----•	Re-Orders the entire table from 1 to N --Not quite sure what is expected here.
	select * from ContactDetails order by ID
-- •	Alters the table and combines the AreaCode and Telephone columns to one column called TelephoneNumber
begin
	begin tran 
		--Add new column
		alter table ContactDetails add TelephoneNumber varchar(12);
		-- Add the new details
		update ContactDetails set TelephoneNumber = AreaCode+' '+Telephone
		-- Drop useless data
		alter table ContactDetails drop column Telephone,AreaCode;
	commit tran
end;