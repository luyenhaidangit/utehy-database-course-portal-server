using AutoMapper;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Models.Comment;
using UTEHY.DatabaseCoursePortal.Api.Models.Role;

namespace UTEHY.DatabaseCoursePortal.Api.Mappers
{
    public class RoleMapper:Profile
    {
        public RoleMapper()
        {
            CreateMap<Role, CreateRoleRequest>();
            CreateMap<CreateRoleRequest, Role>();
            CreateMap<EditRoleRequest, Role>();
            CreateMap<Role, EditRoleRequest>();
        }
    }
}
