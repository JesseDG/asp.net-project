
Database Name: EmployeeCom

/*CREATING USER TABLE*/
CREATE TABLE [dbo].[usertbl]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [firstName] NVARCHAR(50) NOT NULL, 
    [lastName] NVARCHAR(50) NOT NULL, 
    [gender] NCHAR(10) NOT NULL, 
    [date_birth] NVARCHAR(50) NOT NULL
)

/*CREATING PROFILE TABLE*/
CREATE TABLE [dbo].[profile]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(MAX) NOT NULL, 
    [password] NVARCHAR(MAX) NOT NULL, 
    [user_id] INT NOT NULL, 
    CONSTRAINT [FK_profile_ToUser] FOREIGN KEY ([user_id]) REFERENCES [usertbl]([Id])
)

/*CREATING MESSAGES TABLE*/
CREATE TABLE [dbo].[message]
(
    [Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [messageText] TEXT NOT NULL, 
    [time] DATETIME NOT NULL, 
    [sender_ID] INT NOT NULL, 
    [receiver_ID] INT NOT NULL, 
	[seen] INT NULL
    CONSTRAINT [FK_message_ToProfile] FOREIGN KEY ([sender_ID]) REFERENCES [profile]([Id]), 
    CONSTRAINT [FK_message_ToProfileSecond] FOREIGN KEY ([receiver_ID]) REFERENCES [profile]([Id])
)

/*CREATING USER_LOCATION TABLE*/
CREATE TABLE [dbo].[user_location]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [street_addr] NVARCHAR(MAX) NOT NULL, 
    [city] NVARCHAR(50) NOT NULL, 
    [province_state] NVARCHAR(50) NOT NULL, 
    [country] NVARCHAR(50) NOT NULL, 
    [postal_zipCode] NVARCHAR(50) NOT NULL, 
    [user_id] INT NOT NULL, 
    CONSTRAINT [FK_userLocation_ToUser] FOREIGN KEY ([user_id]) REFERENCES [usertbl]([Id])
)