var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSpa(spa => {
    // To learn more about options for serving an Angular SPA from ASP.NET Core,
    // see https://go.microsoft.com/fwlink/?linkid=864501
    spa.Options.SourcePath = "ClientApp";

    spa.Options.DefaultPageStaticFileOptions = new StaticFileOptions
    {
        OnPrepareResponse = context =>
        {
            // never cache index.html
            if (context.File.Name == "index.html")
            {
                // more info on this header: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Cache-Control#preventing_caching
                context.Context.Response.Headers.Add("Cache-Control", "no-store, max-age=0");
                context.Context.Response.Headers.Add("Expires", "-1");
            }
        }
    };

    if (app.Environment.IsDevelopment())
    {
        // Dev note: start Angular server by running `npm start` from the ClientApp folder
        spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
    }
});

app.Run();
