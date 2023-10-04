﻿using FluentValidation.AspNetCore;
using System.Reflection;

namespace UTEHY.DatabaseCoursePortal.Api.Providers
{
    public static class FluentValidationProvider
    {
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidation(options =>
            {
                options.ImplicitlyValidateChildProperties = true;
                options.ImplicitlyValidateRootCollectionElements = true;

                options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

            return services;
        }
    }
}
