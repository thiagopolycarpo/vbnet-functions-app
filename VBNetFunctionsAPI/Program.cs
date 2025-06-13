using Microsoft.AspNetCore.Builder;
   using Microsoft.Extensions.DependencyInjection;

   var builder = WebApplication.CreateBuilder(args);

   builder.Services.AddControllers().AddNewtonsoftJson();
   builder.Services.AddCors(options =>
   {
       options.AddPolicy("AllowAll", builder =>
       {
           builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
       });
   });

   var app = builder.Build();

   app.UseRouting();
   app.UseCors("AllowAll");
   app.UseHttpsRedirection();
   app.MapControllers();

   app.Run();