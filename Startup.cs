using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;
using WebApiHacoupian.Extention;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;
using WebApiHacoupian.Services;

namespace WebApiHacoupian
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApiHacoupian", Version = "v1" });
            });

            services.AddDbContext<MainContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("DBConnection"));
                option.LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging();
            });

            services.AddControllers()
               .AddJsonOptions(options =>
                   options.JsonSerializerOptions.PropertyNamingPolicy = null);

            //Add Interface and Service To Core
            services.AddTransient<MainContext>();
            services.AddTransient<IPerson, Person>();
            services.AddTransient<IPersonRole, PersonRole>();
            services.AddTransient<ICertificate, Certificate>();
            services.AddTransient<ICity, City>();
            services.AddTransient<IPersonCertificate, PersonCertificate>();
            services.AddTransient<IPhone, Phone>();
            services.AddTransient<IPhoneType, PhoneType>();
            services.AddTransient<IPlace, Place>();
            services.AddTransient<IPlaceType, PlaceType>();
            services.AddTransient<IProvince, Province>();
            services.AddTransient<IProductionOrder, ProductionOrder>();
            services.AddTransient<IProductionOrderFinishedGoodProducts, ProductionOrderFinishedGoodProducts>();
            services.AddTransient<IProductionOrderRawMaterialProducts, ProductionOrderRawMaterialProducts>();
            services.AddTransient<IProductionOrderRawMaterialProductsDetails, ProductionOrderRawMaterialProductsDetails>();
            services.AddTransient<IProductionOrderTracking, ProductionOrderTracking>();
            services.AddTransient<IFinishedGoodProduct, FinishedGoodProduct>();
            services.AddTransient<IRawMaterialProduct, RawMaterialProduct>();
            services.AddTransient<IProductionOrderMoreInfo, ProductionOrderMoreInfo>();
            services.AddTransient<ICodingPatternValue, CodingPatternValue>();
            services.AddTransient<ICodingPatternValueType, CodingPatternValueType>();
            services.AddTransient<IInvoiceMaster, InvoiceMaster>();
            services.AddTransient<IInvoiceMasterDiscount, InvoiceMasterDiscount>();
            services.AddTransient<IInvoiceMasterPayment, InvoiceMasterPayment>();
            services.AddTransient<IInvoiceMasterPrePayment, InvoiceMasterPrePayment>();
            services.AddTransient<IInvoiceMasterRemain, InvoiceMasterRemain>();
            services.AddTransient<IInvoiceSlave, InvoiceSlave>();
            services.AddTransient<IRegistrarType, RegistrarType>();
            services.AddTransient<IFinishedGoodStockSheet, FinishedGoodStockSheet>();
            services.AddTransient<IFinishedGoodStockSheetItem, FinishedGoodStockSheetItem>();

            services.AddCors(c =>
            {
                c.AddPolicy("myPolicy", options => options.WithOrigins("http://192.168.15.34:80", "http://localhost:52751", "http://192.168.27.12", "http://localhost:3000", "http://192.168.15.73:8000", "http://d.hcpn.ir:8080", "http://46.209.137.19:8081", "http://172.30.11.4:70")
                    .AllowAnyHeader().AllowAnyMethod());
            });

            // services.AddControllers().AddNewtonsoftJson(options =>
            //options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //JWT Setup Key
            var secret = this.Configuration.GetValue<string>("secret");
            services.AddAuthentication(aut =>
            {
                aut.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                aut.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwt =>
            {
                jwt.RequireHttpsMetadata = false;
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiHacoupian v1"));
            }
            app.ConfigureBuildExeptionHandler(loggerFactory);

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("myPolicy");
            //JWT Authentication
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}