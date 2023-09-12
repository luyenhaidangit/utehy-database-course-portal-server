using System.Reflection;

namespace UTEHY.DatabaseCoursePortal.Api.Configurations
{
    public static class DependencyInjectionProvider
    {
        public static IServiceCollection AddDependencyInjectionServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var serviceProjectNamespace = $"{Assembly.GetCallingAssembly().GetName().Name}.Services";

            var serviceTypes = assembly.GetTypes()
                .Where(type => type.Namespace == serviceProjectNamespace && !type.IsAbstract && !type.IsInterface);

            foreach (var serviceType in serviceTypes)
            {
                // Đăng ký dịch vụ với kiểu của nó và kiểu triển khai của nó
                services.AddScoped(serviceType);
            }

            return services;
        }
    }
}
