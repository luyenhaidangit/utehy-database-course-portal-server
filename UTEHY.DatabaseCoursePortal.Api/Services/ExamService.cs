using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Exam;
using UTEHY.DatabaseCoursePortal.Api.Models.Student;
using UTEHY.DatabaseCoursePortal.Api.Models.Question;
using Newtonsoft.Json;
using System.Diagnostics;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class ExamService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileService _fileService;
        private readonly IMapper _mapper;

        public ExamService(ApplicationDbContext dbContext, FileService fileService, IMapper mapper)
        {
            _dbContext = dbContext;
            _fileService = fileService;
            _mapper = mapper;
        }

        //public async Task<PagingResult<ExamDto>> Get(GetExamRequest request)
        //{
        //    var query = _dbContext.Exams
        // .Include(e => e.ExamQuestions)
        //     .ThenInclude(eq => eq.Question)
        // .AsQueryable();

        //    if (!string.IsNullOrEmpty(request.Title))
        //    {
        //        query = query.Where(b => b.Title == request.Title);
        //    }

        //    if (!string.IsNullOrEmpty(request.Description))
        //    {
        //        query = query.Where(b => b.Description == request.Description);
        //    }

           

        //    // Các điều kiện lọc tại đây

        //    // ...

        //    int total = await query.CountAsync();

        //    if (request.PageIndex == null) request.PageIndex = 1;
        //    if (request.PageSize == null) request.PageSize = total;

        //    int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

        //    // Sắp xếp và phân trang ở đây

        //    // ...

        //    var items = await query
        //        .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
        //        .Take(request.PageSize.Value)
        //        .Select(exam => new ExamDto
        //        {
        //            Id = exam.Id,
        //            Title = exam.Title,
        //            Description = exam.Description,
        //            Duration = exam.Duration,
        //            Questions = exam.ExamQuestions
        //                .Select(eq => new QuestionDto
        //                {
        //                    Id = eq.Question.Id,
        //                    Title = eq.Question.Title,
        //                    Feedback = eq.Question.Feedback,
        //                    Score = eq.Question.Score,
        //                    QuestionCategoryId = eq.Question.QuestionCategoryId,
        //                    Difficulty = eq.Question.Difficulty,
        //                    Type = eq.Question.Type
        //                })
        //                .ToList()
        //        })
        //        .ToListAsync();

        //    var result = new PagingResult<ExamDto>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

        //    return result;
        //}

        //public async Task<ExamDto> GetById(int id)
        //{
        //    var options = new JsonSerializerOptions
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve,
        //        // Các tùy chọn khác nếu cần thiết
        //    };

           

        //    var exam = await _dbContext.Exams
        //        .Include(e => e.ExamQuestions)
        //        .ThenInclude(eq => eq.Question)
        //        .Where(e => e.DeletedAt == null && e.Id == id)
        //        .FirstOrDefaultAsync();


        //    if (exam == null)
        //    {
        //        // Xử lý trường hợp không tìm thấy đề thi
        //        return null;
        //    }

        //    var examDto = new ExamDto
        //    {
        //        Id = exam.Id,
        //        Title = exam.Title,
        //        Description = exam.Description,
        //        Duration = exam.Duration,
        //        Questions = new List<QuestionDto>() // Khởi tạo danh sách câu hỏi
        //    };

        //    foreach (var eq in exam.ExamQuestions)
        //    {
        //        var questionDto = new QuestionDto
        //        {
        //            Id = eq.Question.Id,
        //            Title = eq.Question.Title,
        //            Feedback = eq.Question.Feedback,
        //            Score = eq.Question.Score,
        //            QuestionCategoryId = eq.Question.QuestionCategoryId,
        //            Difficulty = eq.Question.Difficulty,
        //            Type = eq.Question.Type
        //        };

        //        examDto.Questions.Add(questionDto); // Thêm câu hỏi vào danh sách
        //    }

        //    return examDto;
        //}

        //public async Task<Exam> Create(CreateExamRequest createExamRequest)
        //{
        //    var exam = _mapper.Map<Exam>(createExamRequest);

        //    var newExam = new Exam
        //    {
        //        Title = createExamRequest.Title,
        //        Description = createExamRequest.Description,
        //        Duration = createExamRequest.Duration,
        //    };

        //    _dbContext.Exams.Add(newExam);
        //    await _dbContext.SaveChangesAsync(); 

        //    foreach (var questionDto in createExamRequest.Questions)
        //    {
        //        var newExamQuestion = new ExamQuestion
        //        {
        //            ExamId = newExam.Id,
        //            QuestionId = questionDto.Id 
                                                
        //        };

        //        _dbContext.ExamQuestions.Add(newExamQuestion);
        //    }

        //    await _dbContext.SaveChangesAsync(); 

        //    return exam;
        //}

    }
}
