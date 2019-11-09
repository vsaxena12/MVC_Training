create database EMP_DB
use EMP_DB

CREATE TABLE [dbo].[Employee](
	[ID] [int] NULL,
	[EmployeeName] [varchar](255) NULL,
	[Designation] [varchar](255) NULL
) ON [PRIMARY]
GO

insert into Employee values (1,'A','B')

select * from Employee