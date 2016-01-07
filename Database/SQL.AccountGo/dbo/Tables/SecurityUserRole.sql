﻿CREATE TABLE [dbo].[SecurityUserRole] (
	[SecurityUserRoleId] INT IDENTITY(1,1) NOT NULL,
	[SecurityRoleId] INT NULL,
    [UserId] INT NULL
	CONSTRAINT [PK_SecurityUserRole] PRIMARY KEY CLUSTERED ([SecurityUserRoleId] ASC),
	CONSTRAINT [FK_SecurityUserRole_SecurityRole] FOREIGN KEY ([SecurityRoleId]) REFERENCES [dbo].[SecurityRole] ([Id]),
	CONSTRAINT [FK_SecurityUserRole_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
)
