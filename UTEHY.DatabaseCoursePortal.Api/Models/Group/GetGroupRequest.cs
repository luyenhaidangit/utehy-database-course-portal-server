using UTEHY.DatabaseCoursePortal.Api.Models.Common;

namespace UTEHY.DatabaseCoursePortal.Api.Models.Group
{
    public class GetGroupRequest : PagingRequest
    {
        public int? Type { get; set; }
    }
}
