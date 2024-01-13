﻿using UTEHY.DatabaseCoursePortal.Api.Data.Entities.Interface;

namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class Section : EntityBase
    {
        public int? Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int? Priority { get; set; }

        public bool? Status { get; set; }

    }
}
