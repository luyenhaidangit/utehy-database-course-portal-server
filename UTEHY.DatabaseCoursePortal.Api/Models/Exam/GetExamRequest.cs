﻿using UTEHY.DatabaseCoursePortal.Api.Models.Common;

namespace UTEHY.DatabaseCoursePortal.Api.Models.Exam
{
    public class GetExamRequest: PagingRequest
    {
        public string? Title { get; set; }

        public Guid? CreateBy { get; set; }
    }
}
