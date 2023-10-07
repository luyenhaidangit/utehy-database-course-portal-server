using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Configurations;
using UTEHY.DatabaseCoursePortal.Api.Providers;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppProvider();

// Provider
builder.Services.AddEntityFrameworkProvider(builder);
builder.Services.AddFluentValidationProvider();
builder.Services.AddDependencyInjectionProvider();
builder.Services.AddSwaggerProvider();
builder.Services.AddAutoMapperProvider();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
