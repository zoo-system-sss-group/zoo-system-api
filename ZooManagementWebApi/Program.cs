using Application;
using DataAccess;
using DataAccess.Commons;
using Microsoft.AspNetCore.OData;
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

// Add OData Configuraion
builder.Services.AddODataConfiguraion();

// Add Swagger configs
builder.Services.AddSwaggerGenConfiguration();
builder.Services.AddRouting(opt => opt.LowercaseUrls = true);

// Add global exception middleware
builder.Services.AddSingleton<GlobalExceptionMiddleware>();

// Bind AppConfiguration from configuration
var config = builder.Configuration.Get<AppConfiguration>();
builder.Configuration.Bind(config);
builder.Services.AddSingleton(config!);

// Add auto mapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

// Add jwt configuration
builder.Services.AddJWTConfiguration(config!.JwtConfiguration.SecretKey);

// Add DIs
builder.Services.AddDaoDIs();
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