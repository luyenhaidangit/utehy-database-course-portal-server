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

--Exam
INSERT INTO Exams (Title, Description, Duration, StartTime, EndTime, IsShowContent, IsSeeScore, IsMixQuestion, IsMixQuestionAnswer, IsAllowChangeTab, Status, Type, NumberQuestionDifficult, NumberQuestionModerate, NumberQuestionEasy)
VALUES 
('Bài thi SQL cơ bản', 'Kiểm tra kiến thức cơ bản về SQL', '01:30:00', '2024-01-10 09:00:00', '2024-01-10 10:30:00', 1, 1, 0, 0, 1, 1, 1, 10, 15, 25),
('Đề thi thiết kế cơ sở dữ liệu', 'Đánh giá kỹ năng thiết kế cơ sở dữ liệu', '02:00:00', '2024-01-12 14:00:00', '2024-01-12 16:00:00', 1, 1, 1, 0, 1, 1, 2, 15, 20, 25),
('Thi trắc nghiệm SQL nâng cao', 'Kiểm tra hiểu biết sâu rộng về SQL', '02:30:00', '2024-01-15 10:00:00', '2024-01-15 12:30:00', 1, 1, 1, 1, 1, 1, 3, 20, 25, 30),
('Bài kiểm tra normalization', 'Đánh giá hiểu biết về quy tắc normalization', '01:45:00', '2024-01-20 08:30:00', '2024-01-20 10:15:00', 1, 1, 0, 0, 1, 1, 1, 12, 18, 25),
('Đề kiểm tra truy vấn SQL', 'Kiểm tra kỹ năng viết truy vấn SQL', '02:15:00', '2024-01-22 13:00:00', '2024-01-22 15:15:00', 1, 1, 1, 0, 1, 1, 2, 17, 22, 28),
('Bài kiểm tra bảo mật cơ sở dữ liệu', 'Kiểm tra hiểu biết về bảo mật cơ sở dữ liệu', '02:30:00', '2024-01-25 11:30:00', '2024-01-25 14:00:00', 1, 1, 1, 1, 1, 1, 3, 22, 27, 32),
('Bài thi cuối kỳ', 'Kiểm tra toàn diện kiến thức môn cơ sở dữ liệu', '03:00:00', '2024-01-31 09:00:00', '2024-01-31 12:00:00', 1, 1, 1, 1, 1, 1, 3, 25, 30, 35),
('Đề kiểm tra ERD', 'Kiểm tra hiểu biết về mô hình Entity-Relationship Diagram', '02:00:00', '2024-02-05 10:00:00', '2024-02-05 12:00:00', 1, 1, 0, 0, 1, 1, 2, 15, 20, 25),
('Bài kiểm tra SQL Injection', 'Kiểm tra kỹ năng ngăn chặn SQL Injection', '01:30:00', '2024-02-10 15:00:00', '2024-02-10 16:30:00', 1, 1, 1, 1, 1, 1, 3, 18, 22, 26),
('Thi cuối kỳ môn Cơ sở dữ liệu', 'Kiểm tra toàn diện kiến thức môn Cơ sở dữ liệu', '03:30:00', '2024-02-15 13:00:00', '2024-02-15 16:30:00', 1, 1, 1, 1, 1, 1, 3, 30, 35, 40),
('Bài kiểm tra NoSQL', 'Kiểm tra hiểu biết về hệ quản trị cơ sở dữ liệu NoSQL', '02:15:00', '2024-02-20 10:30:00', '2024-02-20 12:45:00', 1, 1, 0, 0, 1, 1, 2, 17, 22, 28),
('Đề kiểm tra Indexing', 'Kiểm tra hiểu biết và kỹ năng sử dụng Index trong cơ sở dữ liệu', '01:45:00', '2024-02-25 08:00:00', '2024-02-25 09:45:00', 1, 1, 1, 0, 1, 1, 1, 12, 18, 25),
('Bài kiểm tra ACID properties', 'Kiểm tra hiểu biết về ACID properties trong giao dịch cơ sở dữ liệu', '02:00:00', '2024-03-01 14:00:00', '2024-03-01 16:00:00', 1, 1, 1, 1, 1, 1, 3, 15, 20, 25)

