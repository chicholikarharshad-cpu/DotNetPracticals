var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

// ✅ UseStaticFiles add kiya (MapStaticAssets ki jagah)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ .WithStaticAssets() hata diya
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashbord}/{action=Dashbord}/{id?}");

app.Run();