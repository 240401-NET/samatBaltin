using CaseStatusTrackerAPI;
using CaseStatusTrackerAPI.Services;
using CaseStatusTrackerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CaseStatusDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(File.ReadAllText("dbConnection.md"))));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICaseRepository, CaseRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICaseService, CaseService>();
builder.Services.AddHttpClient<UscisApiService>();
builder.Services.AddControllers()
.AddJsonOptions(options => {
    options.JsonSerializerOptions.ReferenceHandler =
    System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

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


