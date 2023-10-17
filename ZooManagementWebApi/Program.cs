using Application;
using Application.Commons;
using Application.Utils;
using DataAccess;
using Domain.Entities;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using DataAccess.DAOs;
using System.Text.Json.Serialization;
using ZooManagementWebApi;
using ZooManagementWebApi.Mapper;
using ZooManagementWebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers(opt => opt.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true).AddJsonOptions(opt =>
{
    var enumConverter = new JsonStringEnumConverter();
    opt.JsonSerializerOptions.Converters.Add(enumConverter);
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddControllers().AddOData(options => options.Select()
                                                             .Filter()
                                                             .Count()
                                                             .OrderBy()
                                                             .Expand()
                                                             .SetMaxTop(100)
                                                             .AddRouteComponents("odata",GetEdmModel()));
builder.Services.AddEndpointsApiExplorer().AddRouting(op => op.LowercaseQueryStrings = true); ;

builder.Services.AddSwaggerGenConfiguration();

// Add DB Context for seeding Database
//builder.Services.AddDbContext<AppDBContext>();  // remember to remove/comment when seeding DB complete

// Add global exception middleware
builder.Services.AddSingleton<GlobalExceptionMiddleware>();
// Bind AppConfiguration from configuration
var config = new AppConfiguration();
builder.Configuration.Bind(config);
builder.Services.AddSingleton(config);
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

// Add jwt configuration
builder.Services.AddJWTConfiguration(config.JwtConfiguration.SecretKey);

// Add DIs
builder.Services.AddRepositoryDIs();
builder.Services.AddServicesDIs();

// Add DI for IHttpContextAccessor
builder.Services.AddHttpContextAccessor();

// Add CORS configuration
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin() // Allow requests from any origin
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GlobalExceptionMiddleware>();

app.UseHttpsRedirection();

// Use Odata
app.UseODataBatching();
// Use routing
app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<News>("News");
    return builder.GetEdmModel();
}