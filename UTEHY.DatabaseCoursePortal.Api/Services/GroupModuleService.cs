using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Exceptions;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;
using UTEHY.DatabaseCoursePortal.Api.Models.GroupModule;
using UTEHY.DatabaseCoursePortal.Api.Models.Student;
using System.Drawing;
using DocumentFormat.OpenXml.Office2016.Excel;
using UTEHY.DatabaseCoursePortal.Api.Helpers;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class GroupModuleService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserService _userService;
        private readonly ExamService _examService;
        private readonly IMapper _mapper;

        public GroupModuleService(ApplicationDbContext dbContext, IMapper mapper, UserService userService, ExamService examService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userService = userService;
            _examService = examService;
        }

        public async Task<PagingResult<Data.Entities.GroupModule>> Get(GetGroupModuleRequest request)
        {
            try
            {
                var query = _dbContext.GroupModules.Where(x => x.DeletedAt == null)
                    .Include(x => x.StudentGroupModules)
                    .Include(x => x.Teacher).ThenInclude(t => t.User).Where(t => t.DeletedAt == null)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(request.Name))
                {
                    query = query.Where(b => b.Name.ToLower().Contains(request.Name.ToLower()));
                }

                if (request.Status != null)
                {
                    query = query.Where(b => b.Status == request.Status);
                }

                if (request.Year != null)
                {
                    query = query.Where(b => b.Year == request.Year);
                }

                if (request.Semester != null)
                {
                    query = query.Where(b => b.Semester == request.Semester);
                }

                if (request.TeacherId != null)
                {
                    query = query.Where(b => b.TeacherId == request.TeacherId);
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

                var result = new PagingResult<Data.Entities.GroupModule>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<PagingResult<Student>> GetStudentsGroupModule(GetStudentsGroupModuleRequest request)
        {
            try
            {
                var query = _dbContext.GroupModules
                .Where(x => x.DeletedAt == null && x.Id == request.GroupModuleId)
                .Include(x => x.StudentGroupModules)
                .ThenInclude(xs => xs.Student)
                .ThenInclude(s => s.User)
                .SelectMany(x => x.StudentGroupModules.Select(sm => sm.Student))
                .Where(s => s.DeletedAt == null)
                .AsQueryable();

                if (!string.IsNullOrEmpty(request.NameOrEmail))
                {
                    string search = request.NameOrEmail.ToLower();
                    query = query.Where(b => b.User.Name.ToLower().Contains(request.NameOrEmail.ToLower()) || b.User.Email.ToLower().Contains(request.NameOrEmail.ToLower()));
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

                var result = new PagingResult<Student>(items, request.PageIndex.Value, request.PageSize.Value, request.SortBy, request.OrderBy, total, totalPages);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Data.Entities.GroupModule> GetById(int id)
        {
            try
            {
                var banner = await _dbContext.GroupModules.Include(x => x.StudentGroupModules).FirstOrDefaultAsync(x => x.Id == id && x.DeletedAt == null);

                if (banner == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                return banner;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Data.Entities.GroupModule> Create(CreateGroupModuleRequest request)
        {
            try
            {
                //Validate lớp trùng năm, kỳ
                //...

                var groupModule = _mapper.Map<Data.Entities.GroupModule>(request);

                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.CreatedAt = DateTime.Now;
                groupModule.CreatedBy = userCurrent?.Id;

                await _dbContext.GroupModules.AddAsync(groupModule);
                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Data.Entities.GroupModule> Edit(EditGroupModuleRequest request)
        {
            try
            {
                //Validate lớp trùng năm, kỳ
                //...

                var groupModule = await _dbContext.GroupModules.FindAsync(request.Id);

                if (groupModule == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                _mapper.Map(request, groupModule);
                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.UpdatedAt = DateTime.Now;
                groupModule.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Data.Entities.GroupModule> GenerateInvitationCode(GenerateInvitationCodeRequest request)
        {
            try
            {
                var groupModule = await _dbContext.GroupModules.FindAsync(request.Id);

                if (groupModule == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                var currentTime = DateTime.Now;

                if(request.Type == Constants.GroupModule.GetCode)
                {
                    if (groupModule.ExpiryTimeInvitation <= currentTime || groupModule.ExpiryTimeInvitation == null)
                    {
                        groupModule.InvitationCode = StringHelper.GenerateRandomCode(8);
                        groupModule.ExpiryTimeInvitation = currentTime.AddMinutes(15);

                        var userCurrent = await _userService.GetCurrentUserAsync();
                        groupModule.UpdatedAt = DateTime.Now;
                        groupModule.CreatedBy = userCurrent?.Id;
                    }
                }
                else
                {
                    groupModule.InvitationCode = StringHelper.GenerateRandomCode(8);
                    groupModule.ExpiryTimeInvitation = currentTime.AddMinutes(15);
                    var userCurrent = await _userService.GetCurrentUserAsync();
                    groupModule.UpdatedAt = DateTime.Now;
                    groupModule.CreatedBy = userCurrent?.Id;
                }

                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Data.Entities.GroupModule> Delete(int id)
        {
            try
            {
                var groupModule = await _dbContext.GroupModules.FindAsync(id);

                if (groupModule == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.DeletedAt = DateTime.Now;
                groupModule.CreatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<Data.Entities.GroupModule> Hide(int id)
        {
            try
            {
                var groupModule = await _dbContext.GroupModules.FindAsync(id);

                if (groupModule == null)
                {
                    throw new ApiException("Không tìm thấy nhóm học phần hợp lệ!", HttpStatusCode.InternalServerError);
                }

                groupModule.Status = false;

                var userCurrent = await _userService.GetCurrentUserAsync();
                groupModule.UpdatedAt = DateTime.Now;
                groupModule.UpdatedBy = userCurrent?.Id;

                await _dbContext.SaveChangesAsync();

                return groupModule;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public byte[] ExportStudents(List<Student> students)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add(ExportFile.ListStudentExcelTab);

                    worksheet.Cells[1, 1, 1, 5].Style.Font.Bold = true;
                    worksheet.Cells[1, 1, 1, 5].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, 1, 1, 5].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189)); // Màu xanh dương
                    worksheet.Cells[1, 1, 1, 5].Style.Font.Color.SetColor(Color.White);

                    worksheet.Cells[1, 1].Value = "MSSV";
                    worksheet.Cells[1, 2].Value = "Họ và tên";
                    worksheet.Cells[1, 3].Value = "Email";
                    worksheet.Cells[1, 4].Value = "Số điện thoại";
                    worksheet.Cells[1, 5].Value = "Ngày tham gia";


                    int row = 2;
                    foreach (var student in students)
                    {
                        worksheet.Cells[row, 1].Value = student.StudentId;
                        worksheet.Cells[row, 2].Value = student.User.Name;
                        worksheet.Cells[row, 3].Value = student.User.Email;
                        worksheet.Cells[row, 4].Value = PhoneHelper.FormatPhoneNumber(student.User.PhoneNumber);
                        worksheet.Cells[row, 5].Value = student.CreatedAt != null ? student.CreatedAt.Value.ToString("dd/MM/yyyy") : "";

                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    using (var stream = new MemoryStream())
                    {
                        package.SaveAs(stream);

                        stream.Position = 0;

                        return stream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<byte[]> ExportScoreStudents(int groupModuleId)
        {
            var students = await _dbContext.StudentGroupModules
            .Include(sgm => sgm.Student)
            .ThenInclude(s => s.User)
            .Where(sgm => sgm.GroupModuleId == groupModuleId && sgm.Student.DeletedAt == null)
            .Select(sgm => sgm.Student)
            .ToListAsync();

            var exams = _dbContext.ExamGroupModules
            .Include(egm => egm.Exam)
            .ThenInclude(er => er.ExamResults)
            .Where(egm => egm.GroupModuleId == groupModuleId && egm.Exam.DeletedAt == null)
            .Select(egm => egm.Exam)
            .ToList();

            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add(ExportFile.ListScoreStudentExcelTab);

                    worksheet.Cells[1, 1].Value = "MSSV";
                    worksheet.Cells[1, 2].Value = "Họ và tên";
                    worksheet.Cells[1, 3].Value = "Email";
                    worksheet.Cells[1, 4].Value = "Số điện thoại";
                    worksheet.Cells[1, 5].Value = "Ngày tham gia";

                    int examColumnIndex = 6;
                    foreach (var exam in exams)
                    {
                        worksheet.Cells[1, examColumnIndex].Value = exam.Title;
                        examColumnIndex++;
                    }

                    worksheet.Cells[1, 1, 1, exams.Count + 5].Style.Font.Bold = true;
                    worksheet.Cells[1, 1, 1, exams.Count + 5].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, 1, 1, exams.Count + 5].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189)); // Màu xanh dương
                    worksheet.Cells[1, 1, 1, exams.Count + 5].Style.Font.Color.SetColor(Color.White);

                    int row = 2;
                    foreach (var student in students)
                    {
                        worksheet.Cells[row, 1].Value = student.StudentId;
                        worksheet.Cells[row, 2].Value = student.User.Name;
                        worksheet.Cells[row, 3].Value = student.User.Email;
                        worksheet.Cells[row, 4].Value = PhoneHelper.FormatPhoneNumber(student.User.PhoneNumber);
                        worksheet.Cells[row, 5].Value = student.CreatedAt != null ? student.CreatedAt.Value.ToString("dd/MM/yyyy") : "";

                        examColumnIndex = 6;
                        foreach (var exam in exams)
                        {
                            var examScore = exam.ExamResults.FirstOrDefault(x => x.StudentId == student.Id) != null ? exam.ExamResults.FirstOrDefault(x => x.StudentId == student.Id).Score : 0;
                            worksheet.Cells[row, examColumnIndex].Value = examScore;
                            examColumnIndex++;
                        }

                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    using (var stream = new MemoryStream())
                    {
                        package.SaveAs(stream);

                        stream.Position = 0;

                        return stream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }

        public async Task<StudentGroupModule> AddStudentGroupModule(AddStudentGroupModuleRequest request)
        {
            try
            {
                //Validate
                var student = await _dbContext.Students.FirstOrDefaultAsync(x => x.StudentId == request.StudentId);

                if (student == null)
                {
                    throw new ApiException("Mã sinh viên không tồn tại trong hệ thống!", HttpStatusCode.InternalServerError);
                }

                var groupModule = await _dbContext.GroupModules.FindAsync(request.GroupModuleId);

                if (groupModule == null)
                {
                    throw new ApiException("Mã nhóm học phần không tồn tại trong hệ thống!", HttpStatusCode.InternalServerError);
                }

                var studentGroupModule = await _dbContext.StudentGroupModules.FirstOrDefaultAsync(x => x.GroupModuleId == request.GroupModuleId && x.StudentId == student.Id);

                if (studentGroupModule != null)
                {
                    throw new ApiException("Sinh viên đã tham gia lớp học!", HttpStatusCode.InternalServerError);
                }

                //Add student
                var studentGroupModuleCreate = new StudentGroupModule()
                {
                    StudentId = student.Id,
                    GroupModuleId = request.GroupModuleId
                };

                await _dbContext.StudentGroupModules.AddAsync(studentGroupModuleCreate);
                await _dbContext.SaveChangesAsync();

                return studentGroupModuleCreate;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message, HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
