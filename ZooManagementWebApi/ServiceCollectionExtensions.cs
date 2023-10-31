using Application.IServices;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using System.Text;

namespace ZooManagementWebApi;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddODataConfiguraion(this IServiceCollection services)
    {
        var modelBuilder = new ODataConventionModelBuilder();
        // Add entity set / entity type
        modelBuilder.EntitySet<Account>("Accounts");
        modelBuilder.EntitySet<AnimalInformation>("Animals");
        modelBuilder.EntitySet<Area>("Areas");
        modelBuilder.EntitySet<Cage>("Cages");
        modelBuilder.EntitySet<Species>("Species");
        modelBuilder.EntitySet<Diet>("Diets");
        modelBuilder.EntitySet<CageHistory>("CageHistory");
        modelBuilder.EntitySet<FeedHistory>("FeedHistory");
        modelBuilder.EntitySet<Ticket>("Tickets");
        modelBuilder.EntitySet<TicketOrder>("TicketOrders");
        modelBuilder.EntitySet<TrainingDetail>("TrainingDetails");
        // Add OData
        services.AddControllers().AddOData(options 
            => options.Select().Filter().Count().OrderBy().Expand().SetMaxTop(100)
                      .AddRouteComponents("odata", modelBuilder.GetEdmModel()));

        return services;
    }
    public static IServiceCollection AddJWTConfiguration(this IServiceCollection services,
        string secretKey)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                                                    Encoding.UTF8.GetBytes(secretKey))
                    };
                });
        return services;
    }
    
    public static IServiceCollection AddSwaggerGenConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo { Title = "Zoo Management System APIs", Version = "v1" });
            opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "bearer"
            });

            opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type=ReferenceType.SecurityScheme,
                        Id="Bearer"
                    }
                },
                new string[]{}
                }
            });
        });
        return services;
    }
    
    public static IServiceCollection AddServicesDIs(this IServiceCollection services)
    {
        services.AddScoped<IClaimService, ClaimService>();
        services.AddSingleton<IEmailService, EmailService>();
        return services;
    }
}
