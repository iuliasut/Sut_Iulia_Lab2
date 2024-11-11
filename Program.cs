using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sut_Iulia_Lab2.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<Sut_Iulia_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Sut_Iulia_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Sut_Iulia_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("Sut_Iulia_Lab2Context") ?? throw new InvalidOperationException("Connectionstring 'Sut_Iulia_Lab2Context' not found.")));
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;   
    }).AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.Run();