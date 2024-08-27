using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."));
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

#region Services

builder.Services.AddScoped<IGenericRepository<CountryModel>, IGenericRepository<CountryModel>>();
builder.Services.AddScoped<IGenericRepository<QuestionModel>, IGenericRepository<QuestionModel>>();
builder.Services.AddScoped<IGenericRepository<ResultModel>, IGenericRepository<ResultModel>>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService>();

#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
