using PlugAndPlay.Business;
using PlugAndPlay.Common;

namespace PlugNPlayAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Load MailSettings from appsettings.json
            builder.Services.Configure<MailSettings>(
                builder.Configuration.GetSection("MailSettings")
            );

            // Register Mail Service
            builder.Services.AddTransient<serviceMail>();

            // Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
