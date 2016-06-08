using Microsoft.Extensions.DependencyInjection;

namespace aspnet_core_security
{
    public static class AuthorizationExtensions
    {
        public static IServiceCollection RequireStatus(this IServiceCollection services, string company, string role)
        {
            services.AddAuthorization(
                options =>
                {
                    options.AddPolicy(
                        "PCIAdmins",
                        policy =>
                        {
                            policy.AddRequirements(new StatusRequirement(company, role));
                        });
                });

            return services;
        }
    }
}
