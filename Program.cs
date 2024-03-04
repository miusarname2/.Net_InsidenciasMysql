using InsidenciasMysql.DataAccess;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


// Connect to the DB

const string ConnectionName = "SqlServer";
var connection = builder.Configuration.GetConnectionString(ConnectionName);

builder.Services.AddDbContext<InsidencesDbContext>(options => options.UseSqlServer(connection));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Config CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolitics", builder => { 
        builder.AllowAnyHeader();
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
    });
});


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

// Add cors runtime

app.UseCors("CorsPolitics");

app.Run();
