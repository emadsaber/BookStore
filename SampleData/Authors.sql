USE [BookStore]
GO

INSERT INTO [dbo].[Authors]
           ([FirstName],[LastName],[JoinDate],[Rating],[CreatedBy])
     VALUES
           ('Marijn', 'Haverbeke', '2001-04-01',0, 'admin'),
           ('Addy', 'Osmani', '2001-05-13',0, 'admin'),
           ('Axel', 'Rauschmayer', '2001-07-12',0, 'admin'),
           ('Eric', 'Elliott', '2001-01-12',0, 'admin'),
           ('Nicholas', 'C. Zakas', '2001-02-07',0, 'admin'),
           ('Kyle', 'Simpson', '2001-06-02',0, 'admin'),
           ('Richard', 'Silverman', '2001-08-21',0, 'admin'),
           ('Glenn', 'Block', '2001-01-11',0, 'admin')
GO


