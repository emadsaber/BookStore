USE [BookStore]
GO

INSERT INTO [dbo].[Reviews]
([UserId],[ReviewText],[Rating],[BookId],[CreatedBy])
     VALUES

('02CF654A-3363-48B1-A1B0-0F586D8A983C', N'���� ��� ����� ������ɡ ����� ���� ������ ������ ������ �������', 4.2, '99069323-2050-49EA-B74E-00D5AB89D2FC', 'admin'),
('02CF654A-3363-48B1-A1B0-0F586D8A983C', N'Good book, keep on :)', 3.5, '2E13D6AD-6B6D-4520-9F39-ED9065C2AC5D', 'admin'),
('02CF654A-3363-48B1-A1B0-0F586D8A983C', N'Bad book', 1.5, '2CD76904-BED1-4802-950F-A5878C733594', 'admin'),
('CFD03E88-A20E-4099-BF36-114052E8E808', N'The best book to learn from, with special authors', 4.2, '99069323-2050-49EA-B74E-00D5AB89D2FC', 'admin'),
('CFD03E88-A20E-4099-BF36-114052E8E808', N'Wonderful!', 5.0, '2CD76904-BED1-4802-950F-A5878C733594', 'admin'),
('CFD03E88-A20E-4099-BF36-114052E8E808', N'Not bad', 2.7, '2E13D6AD-6B6D-4520-9F39-ED9065C2AC5D', 'admin'),
('CFD03E88-A20E-4099-BF36-114052E8E808', N'Better than others but not organized', 3.5, '8FCA3674-B6A0-4548-8D77-97CD50D7B863', 'admin'),
('F1557096-D54A-4FD5-96A2-17E070E9F9BF', N'Excellent', 5.0, '9A9E2242-8F65-4053-95B3-3C262484DE02', 'admin'),
('26AD8FA2-1477-44EE-B7CA-812F70E9BE1A', N'Old technology', 2.0, '0DB4295E-29F7-417C-958B-545C5A5E4AD1', 'admin'),
('D5EF0C94-B37B-462C-AFDC-9B7648440D8E', N'The oldest', 1.0, 'D771C6D6-B5BC-4FD9-9399-59403124C5C9', 'admin'),
('1973B251-12CB-4393-B351-A440F6C74E84', N'Smart illustration of hard topic', 3.0, '81BC9CD4-28AC-43E3-8116-8CDD728BA274', 'admin'),
('2FCD0817-C8E9-4B41-8DFB-A979D6A0AD9D', N'Good book, I advise you to read it', 4.0, 'D771C6D6-B5BC-4FD9-9399-59403124C5C9', 'admin')
GO

