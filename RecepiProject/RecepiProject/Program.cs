using BLL.functions;
using BLL.intrefaces;
using DAL.fanctions;
using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
//using RecepiProject.models;

var builder = WebApplication.CreateBuilder(args);

 //Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TamarTableContext>(y => y.UseSqlServer("Server=kitotSrv\\sql;Database=TamarTable;Trusted_Connection=True;TrustServerCertificate=True;"));
//DAL
builder.Services.AddScoped<IRecepi_DAL, Recepi_DAL_Func>();
builder.Services.AddScoped<IEngrediens_DAL, Engrediens_DAL_Func>();
builder.Services.AddScoped<IEngrediensForRecepi_DAL, EngrediensForRecepi_DAL_Func>();
builder.Services.AddScoped<IUser_DAL, User_DAL_Func>();
//BLL
builder.Services.AddScoped<IRecepi_BLL, Recepi_BLL_Func>();
builder.Services.AddScoped<IEngrediens_BLL, Engrediens_BLL_Func>();
builder.Services.AddScoped<IEngrediensForRecepi_BLL, EngrediensForRecepi_BLL_Func>();
builder.Services.AddScoped<IUser_BLL, User_BLL_Func>();

//איפשור גישה מהלקוח
builder.Services.AddCors(p => p.AddPolicy("corspolicy", builder =>
   {
       builder
       .AllowAnyOrigin()
       .AllowAnyMethod()
       .AllowAnyHeader();
   }));


var app = builder.Build();
app.UseCors("corspolicy");
app.UseStaticFiles();

// Configure the HTTP request pipeline.
//איפשור גישה מהלקוח
if (app.Environment.IsDevelopment())
{
    //app.UseCors("AlowAll");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
