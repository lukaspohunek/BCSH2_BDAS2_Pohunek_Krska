using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oracle.ManagedDataAccess.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Build the application and create a configuration object
var app = builder.Build();
var configuration = app.Configuration;



// Continue configuring the HTTP request pipeline, routing, and run the application as needed.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

// Method to configure the Oracle connection
OracleConnection GetOracleConnection(IConfiguration configuration)
{
    string connectionString = configuration.GetConnectionString("OracleConnection");
    return new OracleConnection(connectionString);
}


