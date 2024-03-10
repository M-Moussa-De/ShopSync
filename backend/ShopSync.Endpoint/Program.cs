using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopSync.Domain.Contracts;
using ShopSync.Infrastructure.Database;
using ShopSync.Infrastructure.Database.Seeds;
using ShopSync.Infrastructure.Mapper;
using ShopSync.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ===================Services Configs===================
builder.Services.AddControllers();

#region Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Connection String
var connectionString = builder.Configuration.GetConnectionString("ApplicationConnection");

builder.Services.AddDbContext<ApplicationContext>(options =>
options.UseSqlServer(connectionString));
#endregion

#region AutoMapper Configs
builder.Services.AddSingleton<IMapper>(sp => new Mapper(new MapperConfiguration(cfg =>
{
    cfg.AddProfile<DomainProfile>();
})));
#endregion

#region UnitOfWork Configs
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
#endregion

#region Repositories Configs
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
#endregion

// ===================Middlwares Configs===================
var app = builder.Build();

#region Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

app.MapControllers();

#region Seeds
var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    context.Database.Migrate();
    DbInitializer.Initialize(context);
}
catch (Exception ex)
{
    logger.LogError(ex, "A propblem occurred during migration");
}

#endregion

app.Run();