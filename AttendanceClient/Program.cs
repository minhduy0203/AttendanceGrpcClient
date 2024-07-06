using AttendanceClient.GrpcService;
using AttendanceClient.Service;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Channels;

namespace AttendanceClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
                opt.AccessDeniedPath = "/User/Denied";
            });
            builder.Services.AddTransient<UserService>();
            builder.Services.AddTransient<ScheduleService>();
            builder.Services.AddTransient<AttendanceService>();
			builder.Services.AddTransient<StudentCourseService>();


            builder.Services.AddTransient<UserGrpcService>();
            builder.Services.AddTransient<ScheduleGrpcService>();
            builder.Services.AddTransient<AttendanceGrpcService>();
            builder.Services.AddTransient<StudentCourseGrpcService>();
            string ServerAddress = "http://localhost:5243";
            GrpcChannel grpcChannel = GrpcChannel.ForAddress(ServerAddress);
            builder.Services.AddSingleton<GrpcChannel>(grpcChannel);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapRazorPages();

            app.Run();
        }
    }
}