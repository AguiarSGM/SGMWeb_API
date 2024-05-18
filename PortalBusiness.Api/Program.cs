using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using PortalBusiness.Application;
using PortalBusiness.Application.Interfaces;
using PortalBusiness.Application.Services;
using PortalBusiness.Infrastructure;
using PortalBusiness.Infrastructure.ClassSales;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Interfaces;
using PortalBusiness.Infrastructure.Interfaces.ContractSales;
using PortalBusiness.Infrastructure.Ioc;
using PortalBusiness.Shared;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var connectionString = configuration.GetConnectionString("OracleDBConnection");

builder.Services.AddScoped<IDbConnection>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    connectionString = configuration.GetConnectionString("OracleDBConnection");

    return new OracleConnection(connectionString);
});

builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseOracle(connectionString));

Runtime.ConnectionString = connectionString;

builder.Services.AddScoped<IAuthenticationServices, AuthenticationService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IHealthService, HealthService>();
builder.Services.AddScoped<IHealthRepository, HealthRepository>();

builder.Services.AddScoped<IBrandsService, BrandsService>();
builder.Services.AddScoped<IBrandsRepository, BrandsRepository>();

builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

builder.Services.AddScoped<IChargesService, ChargesService>();
builder.Services.AddScoped<IChargesRepository, ChargesRepository>();

builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();

builder.Services.AddScoped<IClientsService, ClientsService>();
builder.Services.AddScoped<IClientsRepository, ClientsRepository>();

builder.Services.AddScoped<IContatoService, ContatoService>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();

builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IDashboardRepository, DashboardRepository>();

builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

builder.Services.AddScoped<IParameterService, ParameterService>();
builder.Services.AddScoped<IParameterRepository, ParameterRepository>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IRegionService, RegionService>();
builder.Services.AddScoped<IRegionRepository, RegionRepository>();

builder.Services.AddScoped<ISectionService, SectionService>();
builder.Services.AddScoped<ISectionRepository, SectionRepository>();

builder.Services.AddScoped<ISalesService, SalesService>();
builder.Services.AddScoped<ISalesRepository, SalesRepository>();

builder.Services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();
builder.Services.AddScoped<IAtendimentoService, AtendimentoService>();

builder.Services.AddScoped<IOportunidadeRepository, OportunidadeRepository>();
builder.Services.AddScoped<IOportunidadeService, OportunidadeService>();

builder.Services.AddScoped <ITransportadoraService, TransportadoraService>();
builder.Services.AddScoped <ITransportadoraRepository, TransportadoraRepository>();

builder.Services.AddScoped<IUnitService, UnitService>();
builder.Services.AddScoped<IUnitRepository, UnitRepository>();

builder.Services.AddScoped<ISubCategoriesService, SubCategoriesService>();
builder.Services.AddScoped<ISubCategoriesRepository, SubCategoriesRepository>();

builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();

builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();

builder.Services.AddScoped<ITabObjetivoDiaService, TabObjetivoDiaService>();
builder.Services.AddScoped<ITabObjetivoDiaRepository, TabObjetivoDiaRepository>();

//builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<UserContext>();

builder.Services.AddControllers().AddNewtonsoftJson();


builder.Services.AddSingleton<IConfiguration>(configuration);

builder.Services.AddEndpointsApiExplorer();



builder.Services.AddInfrastructureJWT(configuration);
builder.Services.AddInfrastructureSwagger(configuration);


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseHttpsRedirection();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

app.Use(async (context, next) =>
{
    try
    {
        await next.Invoke();
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred while processing the request.");
        throw;
    }
});

app.Run();
