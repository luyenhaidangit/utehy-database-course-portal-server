﻿using UTEHY.DatabaseCoursePortal.Api.Models.User;

namespace UTEHY.DatabaseCoursePortal.Api.Models.Post
{
    public class PostHomeDto
    {
        public int? Id { get; set; }

        public Guid? UserId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string? Content { get; set; }

        public int? Priority { get; set; }

        public bool? IsPublished { get; set; }

        public int? ReadingTime { get; set; }

        public UserProfileDto? User { get; set; }
    }
}
