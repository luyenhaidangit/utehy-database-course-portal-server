﻿using UTEHY.DatabaseCoursePortal.Api.Enums;

namespace UTEHY.DatabaseCoursePortal.Api.Models.Teacher
{
    public class CreateTeacherRequest
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public bool? Status { get; set; }

        public string? TeacherId { get; set; }

        public VerificationType VerificationType { get; set; }
    }
}
