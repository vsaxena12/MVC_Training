<<<<<<< HEAD
create database LoggerDemo;
use LoggerDemo;

create table [dbo].[Logs](
	[LogId] [int] IDENTITY(1,1) not null,
	[Level] [varchar](max) not null,
	[CallSite] [varchar](max) not null,
	[Type] [varchar](max) not null,
	[Message] [varchar](max) not null,
	[StackTrace] [varchar](max) not null,
	[InnerException] [varchar](max) not null,
	[AdditionalInfo] [varchar](max) not null,
	[LoggedOnDate] [datetime] not null constraint [df_logs_loggedondate]  default (getutcdate()),

	constraint [pk_logs] primary key clustered 
	(
		[LogId]
	)
)

GO

create procedure [dbo].[InsertLog] 
(
	@level varchar(max),
	@callSite varchar(max),
	@type varchar(max),
	@message varchar(max),
	@stackTrace varchar(max),
	@innerException varchar(max),
	@additionalInfo varchar(max)
)
as

insert into dbo.Logs
(
	[Level],
	CallSite,
	[Type],
	[Message],
	StackTrace,
	InnerException,
	AdditionalInfo
)
values
(
	@level,
	@callSite,
	@type,
	@message,
	@stackTrace,
	@innerException,
	@additionalInfo
)

go


select * from Logs;
=======
create database LoggerDemo;
use LoggerDemo;

create table [dbo].[Logs](
	[LogId] [int] IDENTITY(1,1) not null,
	[Level] [varchar](max) not null,
	[CallSite] [varchar](max) not null,
	[Type] [varchar](max) not null,
	[Message] [varchar](max) not null,
	[StackTrace] [varchar](max) not null,
	[InnerException] [varchar](max) not null,
	[AdditionalInfo] [varchar](max) not null,
	[LoggedOnDate] [datetime] not null constraint [df_logs_loggedondate]  default (getutcdate()),

	constraint [pk_logs] primary key clustered 
	(
		[LogId]
	)
)

GO

create procedure [dbo].[InsertLog] 
(
	@level varchar(max),
	@callSite varchar(max),
	@type varchar(max),
	@message varchar(max),
	@stackTrace varchar(max),
	@innerException varchar(max),
	@additionalInfo varchar(max)
)
as

insert into dbo.Logs
(
	[Level],
	CallSite,
	[Type],
	[Message],
	StackTrace,
	InnerException,
	AdditionalInfo
)
values
(
	@level,
	@callSite,
	@type,
	@message,
	@stackTrace,
	@innerException,
	@additionalInfo
)

go


select * from Logs;
>>>>>>> e1347fd80caf84bc50a5b48c1834aabd2326ed85
