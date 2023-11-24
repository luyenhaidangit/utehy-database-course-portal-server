using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.Course;
using UTEHY.DatabaseCoursePortal.Api.Models.Track;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class CourseService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly FileService _fileService;

        public CourseService(ApplicationDbContext dbContext, IMapper mapper, FileService fileService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _fileService = fileService;
        }
        public async Task<List<Course>> GetCourses()
        {
            var listCourses = await _dbContext.Courses.ToListAsync();

            return listCourses;
        }
        public async Task<Course> GetCourseById(int id)
        {
            var course = await _dbContext.Courses.FindAsync(id);


            return course;
        }
        //public async Task<List<VideoCourse>> GetListVideoCourseByIdCourse(int courseId)
        //{
        //    var listVideoCourse = await _dbContext.VideoCourses.Where(x => x.CourseId == courseId).ToListAsync();

        //    return listVideoCourse;
        //}
        public async Task<Course> CreateCourse(CreateCourseRequest request)
        {
            if (request.ImageFile?.Length > 0)
            {
                request.ImageUrl = await _fileService.UploadFileAsync(request.ImageFile, PathFolder.Course);
            }
            var course = _mapper.Map<Course>(request);

            if (request.PublishedAt < DateTime.Now)
            {
                request.IsPublished = true;
            }

            await _dbContext.Courses.AddAsync(course);
            await _dbContext.SaveChangesAsync();

            return course;
        }

        public async Task<Track> CreateTrackByCourseId(CreateTrackRequest request)
        {
            var track = _mapper.Map<Track>(request);

            await _dbContext.Tracks.AddAsync(track);
            await _dbContext.SaveChangesAsync();

            return track;
        }

        public async Task<StepTrack> CreateStepTrackByTrackId(CreateStepTrackRequest request)
        {
            var stepTrack = _mapper.Map<StepTrack>(request);

            if (request.VideoCourse != null)
            {
                var videoCourse = _mapper.Map<VideoCourse>(request.VideoCourse);
                await _dbContext.VideoCourses.AddAsync(videoCourse);
                await _dbContext.SaveChangesAsync();
                stepTrack.VideoCourseId = videoCourse.Id;
            }
            if (request.AssignmentCourse != null)
            {
                //var quizCourse = _mapper.Map<QuizCourse>(request.AssignmentCourse.QuizCourses);
                //await _dbContext.QuizCourses.AddAsync(quizCourse);
                //await _dbContext.SaveChangesAsync();
                //stepTrack.AssignmentCourseId = quizCourse.Id;
                var assigment = await CreateAssignment(request.AssignmentCourse);
                stepTrack.AssignmentCourseId = assigment.Id;
            }

            await _dbContext.StepTracks.AddAsync(stepTrack);
            await _dbContext.SaveChangesAsync();
            return stepTrack;
        }
        public async Task<PagingResult<Course>> GetCourses(PagingRequest request)
        {
            var query = _dbContext.Courses.AsQueryable();

            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

            var courses = await query.Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
                                .Take(request.PageSize.Value)
                                .ToListAsync();

            var result = new PagingResult<Course>(courses, request.PageIndex.Value, request.PageSize.Value, total, totalPages);

            return result;
        }

        public async Task<IEnumerable<Track>> GetTracksByCourseId(int courseId)
        {
            var tracks = _dbContext.Tracks.Where(x => x.CourseId == courseId).ToList();

            return tracks;
        }

        public async Task<IEnumerable<CreateStepTrackRequest>> GetStepTracksByTrackId(int trackId)
        {
            var stepTrack = await _dbContext.StepTracks.Where(x => x.TrackID == trackId).ToListAsync();
            var stepTrackVM = new List<CreateStepTrackRequest>();
            for (int i = 0; i < stepTrack.Count; i++)
            {
                stepTrackVM.Add(_mapper.Map<CreateStepTrackRequest>(stepTrack[i]));
                if (stepTrack[i].VideoCourseId != null)
                {
                    var videoCourse = await _dbContext.VideoCourses.FirstOrDefaultAsync(x => x.Id == stepTrack[i].VideoCourseId);
                    stepTrackVM[i].VideoCourse = videoCourse;
                }
                if (stepTrack[i].AssignmentCourseId != null)
                {
                    var assignmentCourse = await _dbContext.AssignmentCourses.FirstOrDefaultAsync(x => x.Id == stepTrack[i].AssignmentCourseId);
                    var quizCoursesByAssignmentCourseId = await _dbContext.QuizCourses.Where(x => x.AssignmentCourseId == stepTrack[i].AssignmentCourseId).ToListAsync();
                    var quizCourses = new List<QuizCourseRequest>();
                    for (int j = 0; i < quizCoursesByAssignmentCourseId.Count; j++)
                    {
                        quizCourses.Add(_mapper.Map<QuizCourseRequest>(quizCoursesByAssignmentCourseId[i]));
                    }
                    //var quizCourses = _mapper.Map<QuizCourseRequest>(quizCoursesByAssignmentCourseId);
                    var assignmentCourserequest = new CreateAssignmentCourseRequest
                    {
                        Title = assignmentCourse.Title,
                        Question = assignmentCourse.Question,
                        QuizCourses = quizCourses
                    };
                    stepTrackVM[i].AssignmentCourse = assignmentCourserequest;

                }
            }
            return stepTrackVM;
        }

        public async Task<AssignmentCourse> CreateAssignment(CreateAssignmentCourseRequest request)
        {
            var assignmentCourse = new AssignmentCourse
            {
                Title = request.Title,
                Question = request.Question
            };

            await _dbContext.AssignmentCourses.AddAsync(assignmentCourse);
            await _dbContext.SaveChangesAsync();

            if (request.QuizCourses != null)
            {
                for (int i = 0; i < request.QuizCourses.Count; i++)
                {
                    var quizCourse = _mapper.Map<QuizCourse>(request.QuizCourses[i]);
                    quizCourse.AssignmentCourseId = assignmentCourse.Id;

                    await _dbContext.QuizCourses.AddAsync(quizCourse);
                }
            }

            await _dbContext.SaveChangesAsync();

            return assignmentCourse;
        }
    }
}
