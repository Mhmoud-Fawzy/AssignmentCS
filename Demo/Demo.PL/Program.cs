using Demo.BLL.Common.Services.Attachments;
using Demo.BLL.Services.Departments;
using Demo.BLL.Services.Employee;
using Demo.BLL.Services.Employees;
using Demo.DAL.Models.Identity;
using Demo.DAL.Persistence.Data;
using Demo.DAL.Persistence.UnitOfWork;
using Demo.PL.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Demo.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Configure Services

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
            // builder.Services.AddScoped<ApplicationDbContext>();
            // builder.Services.AddScoped<DbContextOptions<ApplicationDbContext>>();
            builder.Services.AddDbContext<ApplicationDbContext>((optionsBuilder) => {
                optionsBuilder.UseLazyLoadingProxies()
                              .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IUnitOfWork,UnitOfWork>(); 
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfile()));
            builder.Services.AddTransient<IAttachmentService, AttachmentService>();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>((options) =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = true;  // #%$
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 1;

                options.User.RequireUniqueEmail = true;
                //options.User.AllowedUserNameCharacters = "dafocamc;al,cw";

                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(5);
            })
                            .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.ConfigureApplicationCookie((options) =>
            {
                options.LoginPath = "/account/SignIn";          // To Configure Login Path 
                options.AccessDeniedPath= "/Home/Error";        // To Configure Access Denied Path
				options.ExpireTimeSpan= TimeSpan.FromDays(5);   // To Configure Expire Date For Token
				options.LogoutPath = "/account/SignIn";         // To Configure Logout Path 

			});

            /// builder.Services.AddAuthentication();
			/// builder.Services.AddAuthentication("Identity.Application");
			/// builder.Services.AddAuthentication(options=>
            /// {
            ///     options.DefaultAuthenticateScheme = "Identity.Application";
            ///     options.DefaultChallengeScheme= "Identity.Application";
			/// })
            ///  .AddCookie("Hamada","AspNetCore.Hamada", (options) =>
			/// {
			/// 	options.LoginPath = "/account/SignIn";         
			/// 	options.AccessDeniedPath = "/Home/Error";      
			/// 	options.ExpireTimeSpan = TimeSpan.FromDays(5); 
			/// 	options.LogoutPath = "/account/SignIn";        
            /// 
			/// });



			#endregion

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
