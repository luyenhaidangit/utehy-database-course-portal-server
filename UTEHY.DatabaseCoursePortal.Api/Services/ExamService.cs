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
using Microsoft.IdentityModel.Tokens;
using UTEHY.DatabaseCoursePortal.Api.Models.GroupModule;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class ExamService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileService _fileService;
        private readonly IMapper _mapper;
        private readonly UserService _userService;

        public ExamService(ApplicationDbContext dbContext, FileService fileService, IMapper mapper , UserService userService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<PagingResult<Exam>> Get(GetExamRequest request)
        {
            try
            {
                var query = _dbContext.Exams.Where(x => x.DeletedAt == null)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(request.Title))
                {
                    query = query.Where(b => b.Title.ToLower().Contains(request.Title.ToLower()));
                }

                int total = await query.CountAsync();

                if (request.PageIndex == null) request.PageIndex = 1;
                if (request.PageSize == null) request.PageSize = total;

                int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

                if (string.IsNullOrEmpty(request.OrderBy) && string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else if (string.IsNullOrEmpty(request.OrderBy))
                {
                    if (request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }
                else if (string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else
                {
                    if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Desc)
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }

                var items = await query
                .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                .Take(request.PageSize.Value)
                .ToListAsync();

                var result = new PagingResult<Exam>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<PagingResult<Exam>> Get(GetExamRequest request)
        {
            try
            {
                var query = _dbContext.Exams.Where(x => x.DeletedAt == null)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(request.Title))
                {
                    query = query.Where(b => b.Title.ToLower().Contains(request.Title.ToLower()));
                }

                int total = await query.CountAsync();

                if (request.PageIndex == null) request.PageIndex = 1;
                if (request.PageSize == null) request.PageSize = total;

                int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

                if (string.IsNullOrEmpty(request.OrderBy) && string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else if (string.IsNullOrEmpty(request.OrderBy))
                {
                    if (request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }
                else if (string.IsNullOrEmpty(request.SortBy))
                {
                    query = query.OrderByDescending(b => b.Id);
                }
                else
                {
                    if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Asc)
                    {
                        query = query.OrderBy(b => b.Id);
                    }
                    else if (request.OrderBy == OrderByConstant.Id && request.SortBy == SortByConstant.Desc)
                    {
                        query = query.OrderByDescending(b => b.Id);
                    }
                }

                var items = await query
                .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                .Take(request.PageSize.Value)
                .ToListAsync();

                var result = new PagingResult<Exam>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<PagingResult<ExamDto>> Get(GetExamRequest request)
        {
            var query = _dbContext.Exams
         .Include(e => e.ExamQuestions)
             .ThenInclude(eq => eq.Question)
         .AsQueryable();

            if (!string.IsNullOrEmpty(request.Title))
            {
                query = query.Where(b => b.Title == request.Title);
            }

            if (!string.IsNullOrEmpty(request.Description))
            {
                query = query.Where(b => b.Description == request.Description);
            }



            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

     

            var items = await query
                .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                .Take(request.PageSize.Value)
                .Select(exam => new ExamDto
                {
                    Id = (int)exam.Id,
                    Title = exam.Title,
                    Description = exam.Description,
                    Duration = (TimeSpan)exam.Duration,
                    StartTime=exam.StartTime,
                    EndTime=exam.EndTime,
                    NumberQuestionDifficult = exam.NumberQuestionDifficult,
                    NumberQuestionEasy = exam.NumberQuestionEasy,
                    NumberQuestionModerate = exam.NumberQuestionModerate,
                    Type = exam.Type,
                    IsSeeScore=exam.IsSeeScore,
                    IsShowContent=exam.IsShowContent,
                    Questions = exam.ExamQuestions
                        .Select(eq => new QuestionDto
                        {
                            Id = eq.Question.Id,
                            Title = eq.Question.Title,
                            Feedback = eq.Question.Feedback,
                            Score = eq.Question.Score,
                            QuestionCategoryId = eq.Question.QuestionCategoryId,
                            Difficulty = eq.Question.Difficulty,
                            Type = eq.Question.Type
                        })
                        .ToList()
                })
                .ToListAsync();

            var examDtos = _mapper.Map<List<ExamDto>>(items);

            var result = new PagingResult<ExamDto>(examDtos, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

            return result;
        }



        public async Task<ExamDto> GetById(int id)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
            };



            var exam = await _dbContext.Exams
                .Include(e => e.ExamQuestions)
                .ThenInclude(eq => eq.Question)
                .Where(e => e.DeletedAt == null && e.Id == id)
                .FirstOrDefaultAsync();


            if (exam == null)
            {
                return null;
            }

            var examDto = new ExamDto
            {
                Id = (int)exam.Id,
                Title = exam.Title,
                Description = exam.Description,
                Duration = (TimeSpan)exam.Duration,
                StartTime = exam.StartTime,
                EndTime = exam.EndTime,
                NumberQuestionDifficult = exam.NumberQuestionDifficult,
                NumberQuestionEasy = exam.NumberQuestionEasy,
                NumberQuestionModerate = exam.NumberQuestionModerate,
                Type = exam.Type,
                IsSeeScore = exam.IsSeeScore,
                IsShowContent = exam.IsShowContent,
                Questions = new List<QuestionDto>() 
            };

            var examdto = _mapper.Map<ExamDto>(examDto);

            foreach (var eq in exam.ExamQuestions)
            {
                var questionDto = new QuestionDto
                {
                    Id = eq.Question.Id,
                    Title = eq.Question.Title,
                    Feedback = eq.Question.Feedback,
                    Score = eq.Question.Score,
                    QuestionCategoryId = eq.Question.QuestionCategoryId,
                    Difficulty = eq.Question.Difficulty,
                    Type = eq.Question.Type
                };

                examDto.Questions.Add(questionDto); 
            }

            return examdto;
        }

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





        public async Task<Exam> Delete(int id)
        {
            try
            {
                var exam = await _dbContext.Exams.FindAsync(id);

                if (exam == null)
                {
                    throw new ApiException("Không tìm thấy bài thi hợp lệ!", HttpStatusCode.InternalServerError);
                }

                var userCurrent = await _userService.GetCurrentUserAsync();
                exam.DeletedAt = DateTime.Now;
                exam.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return exam;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<List<Exam>> DeleteMultiple(List<int?> ids)
        {
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var exams = await _dbContext.Exams
                                                   .Where(s => ids.Contains(s.Id) && s.DeletedAt == null)
                                                   .ToListAsync();

                    if (!exams.Any())
                    {
                        throw new ApiException("Không tìm thấy bài thi nào hợp lệ để xoá.", HttpStatusCode.BadRequest);
                    }

                    foreach (var exam in exams)
                    {
                        exam.DeletedAt = DateTime.Now;
                    }

                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return exams;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new ApiException($"Lỗi khi xoá các bài thi: {ex.Message}", HttpStatusCode.InternalServerError, ex);
                }
            }
        }



        public async Task<ExamResult?> GetScoreExamStudent(int studentId, int examId)
        {
            try
            {
                var result = await _dbContext.ExamResults.FirstOrDefaultAsync(x => x.StudentId == studentId && x.ExamId == examId);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
