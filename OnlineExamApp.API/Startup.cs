using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Factory;
using OnlineExamApp.API.Helpers;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using OnlineExamApp.API.Repository;
using OnlineExamApp.API.Service;

namespace OnlineExamApp.API
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

            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            IdentityBuilder builder = services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 4;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
            });

            builder = new IdentityBuilder(builder.UserType, typeof(Role), builder.Services);
            builder.AddEntityFrameworkStores<DataContext>();
            builder.AddRoleValidator<RoleValidator<Role>>();
            builder.AddRoleManager<RoleManager<Role>>();
            builder.AddSignInManager<SignInManager<User>>();
            services.AddAutoMapper(typeof(DataContext));

            services.AddTransient<Seed>();
            services.Configure<CloudinarySettings>(Configuration.GetSection("CloudinarySettings"));
            services.AddCors();

            //Register Factory
            services.AddScoped<IEmailTemplate, AccountVerificationEmail>();
            services.AddScoped<IEmailTemplate, ChangePasswordEmail>();
            services.AddScoped<IEmailTemplate, PurchaseDetailsEmail>();
            services.AddScoped<IEmailTemplate, ScoreDetailsEmail>();
            
            
            //Registered repository
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDigitalFileRepository, DigitalFileRepository>();
            services.AddScoped<IOptionRepository, OptionRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IScoreRepository, ScoreRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserScoreRepository, UserScoreRepository>();
            
            //Registered service
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IUserService, UserService>();

            services.AddMvc().AddNewtonsoftJson(options =>
                options.SerializerSettings.ContractResolver =
                    new CamelCasePropertyNamesContractResolver());

    
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                        .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("UserPolicy", policy => policy.RequireRole("USER"));
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("ADMIN", "USER"));

            }

            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Seed seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());  //cors 
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();  //for authentication middleware   
            app.UseAuthorization();
            seeder.SeedQuestions();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToController("Index","Fallback");
            });
        }
    }
}
