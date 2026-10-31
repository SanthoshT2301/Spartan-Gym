using Microsoft.EntityFrameworkCore;

using SpartanGym_Business.Interface.Users;

using SpartanGym_Data;

var builder = WebApplication.CreateBuilder(args);

// Configure the database connection
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<IUserService,UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();