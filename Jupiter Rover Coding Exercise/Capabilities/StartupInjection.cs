using Jupiter_Rover_Coding_Exercise.Repositories;
using Jupiter_Rover_Coding_Exercise.Repositories.Interfaces;
using Jupiter_Rover_Coding_Exercise.Services;

namespace Jupiter_Rover_Coding_Exercise.Capabilities
{
    public static class StartupInjection
    {
        public static IServiceCollection ConfigureInjection(this IServiceCollection services)
        {
            services.AddSingleton<IRoverLocationRepository, RoverLocationRepository>();
            services.AddSingleton<IRoverRepository, RoverRepository>();

            services.AddScoped<IMovingService, MovingService>();
            services.AddScoped<IRoverLocationService, RoverLocationService>();

            return services;
        }
    }
}