namespace UTEHY.DatabaseCoursePortal.Api.Models.Common
{
    public class PageResult<T>
    {
        public PageResult(List<T>? items, int pageIndex, int pageSize, int totalRecords,int totalPages) 
        { 
            Items = items;

            PageIndex = pageIndex;

            PageSize = pageSize;

            TotalRecords = totalRecords;

            TotalPages = totalPages;
        }

        public List<T>? Items { set; get; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }

        public int TotalPages { get; set; }
    }
}
