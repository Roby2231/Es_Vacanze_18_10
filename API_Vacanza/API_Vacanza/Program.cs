
using API_Vacanza.Context;
using API_Vacanza.Controllers;
using API_Vacanza.Repositories;
using API_Vacanza.Services;
using Microsoft.EntityFrameworkCore;

namespace API_Vacanza
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #region Importanti per la configurazione del context

           builder.Services.AddDbContext<VaContext>(
               options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
                );

           builder.Services.AddScoped<DestinazioneRepo>();
           builder.Services.AddScoped<PacchettoRepo>();
           builder.Services.AddScoped<RecensioneRepo>();
            // Services
           builder.Services.AddScoped<DestinazioneServices>();
          

            #endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {   
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
