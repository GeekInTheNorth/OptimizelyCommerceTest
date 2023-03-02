namespace OptimizelyCommerceLearning;

using EPiServer.Cms.Shell;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Commerce.FindSearchProvider;
using EPiServer.Scheduler;
using EPiServer.Web.Routing;

using Geta.Optimizely.Categories.Configuration;
using Geta.Optimizely.Categories.Find.Infrastructure.Initialization;
using Geta.Optimizely.Categories.Infrastructure.Initialization;

using Mediachase.Commerce.Anonymous;

using OptimizelyCommerceLearning.ServiceExtensions;

public class Startup
{
    private readonly IWebHostEnvironment _webHostingEnvironment;

    public Startup(IWebHostEnvironment webHostingEnvironment)
    {
        _webHostingEnvironment = webHostingEnvironment;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        if (_webHostingEnvironment.IsDevelopment())
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(_webHostingEnvironment.ContentRootPath, "App_Data"));

            services.Configure<SchedulerOptions>(options => options.Enabled = false);
        }

        services.AddCmsAspNetIdentity<ApplicationUser>()
                .AddCommerce()
                .AddAdminUserRegistration()
                .AddEmbeddedLocalization<Startup>()
                .AddFind()
                .AddFindSearchProvider();

        services.AddCustomDependencies()
                .AddGetaCategories()
                .AddGetaContentTypeIcons()
                .AddRobotsTextHandler()
                .AddSecurityAdmin();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseAnonymousId();

        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseSecurityAdmin();

        app.UseGetaCategories();
        app.UseGetaCategoriesFind();
        app.UseGetaContentTypeIcons();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapContent();
            endpoints.MapRazorPages();
        });
    }
}
