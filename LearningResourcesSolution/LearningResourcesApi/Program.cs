using LearningResourcesApi.Adapters;
using LearningResourcesApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(pol =>
{
    //work with your team and the security people at work on this.
    pol.AddDefaultPolicy(p =>
    {
        p.AllowAnyOrigin();
        p.AllowAnyMethod();
        p.AllowAnyHeader();
    });
});

builder.Services.AddSingleton<ISystemTime, SystemTime>();

builder.Services.AddDbContext<LearningResourcesDataContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("resources");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

app.UseCors();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
