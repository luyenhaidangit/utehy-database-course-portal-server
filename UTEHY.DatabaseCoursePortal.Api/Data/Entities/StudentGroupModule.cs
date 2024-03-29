﻿namespace UTEHY.DatabaseCoursePortal.Api.Data.Entities
{
    public class StudentGroupModule
    {
        public int Id { get; set; }

        public int? StudentId { get; set; }

        public int? GroupModuleId { get; set; }

        public int? Status { get; set; }

        public DateTime? JoinDate { get; set; }

        public virtual Student? Student { get; set; }
    }
}
