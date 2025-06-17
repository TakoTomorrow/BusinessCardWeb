// Cross-Origin Request (Cors) reference: https://learn.microsoft.com/en-us/aspnet/core/security/cors

namespace BusinessCardWeb.Server.Infrastructures;

public static class CorsService
{
    public static void AddCorsService(this IServiceCollection services)
    {
        var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
        var origins = config.GetSection("CorsOrigins").Get<string[]>();

        services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.WithOrigins(origins ?? new string[] { })
                      .AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowCredentials();
            });
        });
    }
}