Create database KTGK2
go

Create table Phone(
   id int primary key identity(1,1),
   model nvarchar(100),
   price decimal(18,0),
   gerenal_not nchar(1000)
   ) 
