-- GroupModules
INSERT INTO GroupModules 
    ([Name], [Description], [InvitationCode], [ExpiryTimeInvitation], [Year], [Semester], [Status], [TeacherId], [CreatedAt], [CreatedBy], [DeletedAt], [DeletedBy], [UpdatedAt], [UpdatedBy])
VALUES
    ('125201', 'Description 1', NULL, NULL, 2021, 1, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125202', 'Description 2', NULL, NULL, 2022, 2, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125203', 'Description 3', NULL, NULL, 2023, 1, 1, 3, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125204', 'Description 4', NULL, NULL, 2022, 2, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125205', 'Description 5', NULL, NULL, 2023, 1, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125206', 'Description 6', NULL, NULL, 2021, 2, 1, 3, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125207', 'Description 7', NULL, NULL, 2022, 1, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125208', 'Description 8', NULL, NULL, 2023, 2, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125209', 'Description 9', NULL, NULL, 2021, 2, 1, 3, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125210', 'Description 10', NULL, NULL, 2023, 1, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125211', 'Description 11', NULL, NULL, 2022, 2, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125212', 'Description 12', NULL, NULL, 2021, 1, 1, 3, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125213', 'Description 13', NULL, NULL, 2022, 1, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125214', 'Description 14', NULL, NULL, 2023, 2, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125215', 'Description 15', NULL, NULL, 2021, 2, 1, 3, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125216', 'Description 16', NULL, NULL, 2022, 1, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125217', 'Description 17', NULL, NULL, 2022, 1, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125218', 'Description 18', NULL, NULL, 2023, 2, 1, 3, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125219', 'Description 19', NULL, NULL, 2021, 2, 1, 1, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL),
    ('125220', 'Description 20', NULL, NULL, 2023, 1, 1, 2, GETDATE(), '69BD714F-9576-45BA-B5B7-F00649BE00DE', NULL, NULL, NULL, NULL);


-- UserGroupModules
INSERT INTO StudentGroupModules (StudentId, GroupModuleId, Status)
VALUES
    (1, 1, 1),  -- Group 1, 1 Student
    (1, 2, 1),  -- Group 2, 1 Student
    (2, 2, 1),  -- Group 2, 1 Student
    (1, 3, 1),  -- Group 3, 1 Student
    (2, 3, 1),  -- Group 3, 1 Student
    (3, 3, 1),  -- Group 3, 1 Student
    (1, 4, 1),  -- Group 4, 1 Student
    (2, 4, 1),  -- Group 4, 1 Student
    (3, 4, 1),  -- Group 4, 1 Student
    (1, 5, 1),  -- Group 5, 1 Student
    (2, 5, 1),  -- Group 5, 1 Student
    (3, 5, 1),  -- Group 5, 1 Student
    (4, 5, 1),  -- Group 5, 1 Student
    (5, 5, 1);  -- Group 5, 1 Student
