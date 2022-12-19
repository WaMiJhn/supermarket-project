using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using RhClassLibrary.Interfaces;
using RhClassLibrary.Managers;
using RhDalLibrary.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = new PathString("/Login");
    options.AccessDeniedPath = new PathString("/Error");
});
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IAccountManager>(s => new AccountManager(new AccountDAL()));
builder.Services.AddScoped<IItemManager>(s => new ItemManager(new ItemDAL()));
builder.Services.AddScoped<ICategoryManager>(s => new CategoryManager(new CategoryDAL()));
builder.Services.AddScoped<ICustomerManager>(s => new PersonManager(new PersonDAL()));
builder.Services.AddScoped<IOrderManager>(s => new OrderManager(new OrderDAL()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
