using Application;
using Application.Commons;
using Application.Utils;
using DataAccess;
using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.AspNetCore.OData.Routing;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Text.Json.Serialization;
using ZooManagementWebApi;
using ZooManagementWebApi.DTOs.Mapper;
using ZooManagementWebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers(opt => opt.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes =true).AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddControllers().AddOData(options => options.Select()
                                                             .Filter()
                                                             .Count()
                                                             .OrderBy()
                                                             .Expand()
                                                             .SetMaxTop(100)
                                                             .AddRouteComponents("odata", GetEdmModel()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(NewMapperProfile).Assembly);

builder.Services.AddSwaggerGenConfiguration();

// Add DB Context for seeding Database
builder.Services.AddDbContext<AppDBContext>();  // remember to remove/comment when seeding DB complete

// Add global exception middleware
builder.Services.AddSingleton<GlobalExceptionMiddleware>();

// Bind AppConfiguration from configuration
var config = new AppConfiguration();
builder.Configuration.Bind(config);
builder.Services.AddSingleton(config);

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

// Initialize data for DB
SeedDatabase();

app.UseCors();
// test middleware ( i will add middleware later)
//app.Use(next => context =>
//{
//    var endpoint = context.GetEndpoint();
//    if (endpoint == null)
//    {
//        return next(context);
//    }

//    IEnumerable<string> temps;
//    IODataRoutingMetadata? metadata = endpoint.Metadata.GetMetadata<IODataRoutingMetadata>();

//    if(metadata != null)
//    {
//        temps = metadata.Template.GetTemplates();
//    }
//    return next(context);
//});

app.UseAuthorization();

app.MapControllers();

app.Run();


void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<AppDBContext>();
            //context.Database.EnsureCreated(); // create database if not exist, add table if not has any
            DBInitializer.InitializeData(context);
        }
        catch (Exception ex)
        {
            app.Logger.LogError(ex, "An error occurred when seeding the DB.");
        }
    }
}
IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<News>("News");
    return builder.GetEdmModel();
}