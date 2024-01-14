using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Permisson;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class PermissionService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;


        public PermissionService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }



        //public List<Permission> GetPermissionsByRoleId(GetPermissonRequest request)
        //{
        //    var rolePermissions = _dbContext.RolePermissions
        //        .Where(rp => rp.RoleId == request.RoleId)
        //        .Include(rp => rp.Permission) 

        //    var permissions = rolePermissions.Select(rp => rp.Permission).ToList();

        //    // Lấy danh sách quyền con cho mỗi quyền và kết hợp vào danh sách chung
        //    var allPermissions = new List<Permission>();
        //    foreach (var permission in permissions)
        //    {
        //        var permissionAndChildren = GetChildPermissions(permission.Id);
        //        allPermissions.AddRange(permissionAndChildren);
        //    }

        //    return allPermissions;
        //}

        //public List<Permission> GetChildPermissions(int parentPermissionId)
        //{
        //    var childPermissions = _dbContext.Permissions
        //        .Where(p => p.ParentPermissionId == parentPermissionId)
        //        .ToList();

        //    return childPermissions;
        //}









        //public List<PermissionDto> GetAllPermissionsHierarchy()
        //{
        //    var allPermissions = _dbContext.Permissions
        //        .Where(p => p.ParentPermissionId == null)
        //        .ToList();

        //    var permissionDtos = allPermissions.Select(p => MapPermissionToDto(p)).ToList();

        //    return permissionDtos;
        //}

        //private PermissionDto MapPermissionToDto(PermissionDto permissionDtoRequest)
        //{
        //    var permission = _mapper.Map<Permission>(permissionDtoRequest);

        //    var permissionDto = new PermissionDto
        //    {
        //        Id = permission.Id,
        //        Name = permission.Name,
        //        DisplayName = permission.DisplayName,
        //        ParentPermissionId = permission.ParentPermissionId,
        //        Description = permission.Description,
        //        Children = _dbContext.Permissions
        //            .Where(p => p.ParentPermissionId == permission.Id)
        //            .Select(p => MapPermissionToDto(p))
        //            .ToList()
        //    };

        //    return permissionDto;
        //}




    }
}
