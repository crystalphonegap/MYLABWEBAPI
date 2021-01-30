using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using myLabWebApi.Context;
using myLabWebApi.Helper;
using myLabWebApi.Interface;
using myLabWebApi.Security;
using myLabWebApi.Services;
using System;

namespace myLabWebApi
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
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.Configure<FormOptions>(o =>
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });
            //JwtSettings settings = GetJwtSettings();
            //services.AddSingleton<JwtSettings>(settings);
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = "JwtBearer";
            //    options.DefaultChallengeScheme = "JwtBearer";

            //}).AddJwtBearer("JwtBearer", jwtOptions =>
            //{
            //    jwtOptions.TokenValidationParameters = new TokenValidationParameters()
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Key)),
            //        ValidateIssuer = true,
            //        ValidIssuer = settings.Issuer,
            //        ValidateAudience = true,
            //        ValidAudience = settings.Audience,
            //        ValidateLifetime = true,
            //        ClockSkew = TimeSpan.FromMinutes(settings.MinToExpiration)
            //    };

            //});

            services.AddControllers();

            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseContext")));

            //For all to Access WebApi

            //Commented By SUman on 20-11-2020
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                    builder.SetIsOriginAllowed(_ => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddControllers()
             .AddNewtonsoftJson(options =>
             {
                 options.UseMemberCasing();
             });
            services.AddScoped<IMyLabHelper, MyLabHelper>();
            services.AddScoped<ILogger, Logger>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ITestService, TestService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Error Handling
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //app.ConfigureCustomExceptionMiddleware();

            //added for preventing  Clickjacking Possible by suman on 20-11-2020
            //app.Use(async (context, next) =>
            //{
            //    context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
            //    await next();
            //});
            //added for preventing  Clickjacking Possible by suman on 20-11-2020

            //added for preventing Server Banner Discloser by suman on 20-11-2020
            //app.Use(async (context, nextMiddleware) =>
            //{
            //    context.Response.OnStarting(() =>
            //    {
            //        context.Response.Headers.Add("Site", "Simple-Talk");
            //        return Task.FromResult(0);
            //    });
            //    await nextMiddleware();
            //});

            //app.Use(async (context, nextMiddleware) =>
            //{
            //    using (var memory = new MemoryStream())
            //    {
            //        var originalStream = context.Response.Body;
            //        context.Response.Body = memory;

            //        await nextMiddleware();

            //        memory.Seek(0, SeekOrigin.Begin);
            //        var content = new StreamReader(memory).ReadToEnd();
            //        memory.Seek(0, SeekOrigin.Begin);

            //        // Apply logic here for deciding which headers to add
            //        context.Response.Headers.Add("Body", content);

            //        await memory.CopyToAsync(originalStream);
            //        context.Response.Body = originalStream;
            //    }
            //});
            //added for preventing Server Banner Discloser by suman on 20-11-2020

            /*security configuration*/
            app.UseXContentTypeOptions();
            app.UseReferrerPolicy(opts => opts.NoReferrer());
            app.UseXXssProtection(opts => opts.EnabledWithBlockMode());
            app.UseXfo(opts => opts.Deny());
            app.UseCsp(opt => opt
                .BlockAllMixedContent()
                //.StyleSources(x => x.Self().CustomSources("http://fonts.googleapis.com"))
                .StyleSources(x => x.Self().UnsafeInline())
                .ScriptSources(x => x.Self().UnsafeInline())
                .FontSources(x => x.Self())
                .FormActions(x => x.Self())
                .FrameAncestors(x => x.Self())
                .ImageSources(x => x.Self().CustomSources("data:"))
            );
            /*security configuration*/

            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("EnableCORS");

            //app.UseCors();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapFallbackToController("Index", "Fallback");
            });
        }

        public JwtSettings GetJwtSettings()
        {
            JwtSettings settings = new JwtSettings();
            settings.Key = Configuration["JwtSettings:key"];
            settings.Issuer = Configuration["JwtSettings:issuer"];
            settings.Audience = Configuration["JwtSettings:audience"];
            settings.MinToExpiration = Convert.ToInt32(Configuration["JwtSettings:minToExpiration"]);
            return settings;
        }
    }
}