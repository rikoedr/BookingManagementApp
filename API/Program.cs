using API.Contracts;
using API.Data;
using API.Model;
using API.Models;
using API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BookingManagementDbContext>(option => option.UseSqlServer(connectionString));

// Add repositories to the controller
builder.Services.AddScoped<ITableRepository<University>, UniversityRepository>();
builder.Services.AddScoped<ITableRepository<Employee>, EmployeeRepository>();
builder.Services.AddScoped<ITableRepository<Education>, EducationRepository>();
builder.Services.AddScoped<ITableRepository<Account>, AccountRepository>();
builder.Services.AddScoped<ITableRepository<AccountRole>, AccountRoleRepository>();
builder.Services.AddScoped<ITableRepository<Booking>, BookingRepository>();
builder.Services.AddScoped<ITableRepository<Role>, RoleRepository>();
builder.Services.AddScoped<ITableRepository<Room>, RoomRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
