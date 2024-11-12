CREATE TABLE [dbo].[Assignments]
(
	[AssignmentId] INT IDENTITY (1,1) NOT NULL, 
    [ProjectCode] NVARCHAR(6) NOT NULL, 
    [StudentNumber] INT NOT NULL, 
    [AssignmentDate] DATE NOT NULL
       PRIMARY KEY CLUSTERED ([AssignmentId] ASC),
CONSTRAINT [FK_dbo.Assignments_dbo.Projects_ProjectCode] FOREIGN KEY
([ProjectCode])
REFERENCES [dbo].[Projects] ([ProjectCode]) ON DELETE CASCADE,
CONSTRAINT [FK_dbo.Assignments_dbo.Students_StudentNumber] FOREIGN KEY
([StudentNumber])
REFERENCES [dbo].[Students] ([StudentNumber]) ON DELETE CASCADE
)
