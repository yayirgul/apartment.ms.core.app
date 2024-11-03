using ams.data.Context;
using ams.data.Extensions;
using ams.entity.Entities;
using ams.service.Extensions;
using ams.web.Helpers;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMailSender, MailSender>(x => new MailSender(
    builder.Configuration["MailSender:Host"],
    builder.Configuration.GetValue<int>("MailSender:Port"),
    builder.Configuration.GetValue<bool>("MailSender:EnableSSL"),
    builder.Configuration["MailSender:Username"],
    builder.Configuration["MailSender:Password"]
    ));

builder.Services.DataHelper(builder.Configuration);
builder.Services.ServiceHelper();
builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(360);
});


// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



// TODO : Microsoft Identity mekanizmasını kullanabilmek için aşağıdaki tanımlamayı yaptım.
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false; // Alphanumeric zorunluluğunu kaldırıyorum
    opt.Password.RequireLowercase = false;       // Küçük harf zorunluluğunu kaldırıyorum
    opt.Password.RequireUppercase = false;       // Büyük harf zorunluluğunu kaldırıyorum
    opt.Password.RequireDigit = false; // Sadece sayısal bir değer kullanmak istiyor musunuz?

    opt.User.RequireUniqueEmail = true; // "Email" adresi sadece bir kişiye ait olmalıdır.
    //opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz"; // "UserName" alanı için türkçe karakter kullanamayacağını belirtiyoruz.

    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(5); // Kullanıcı hatalı giriş yaptığında 5 dk sisteme giriş yapmasını engelliyor.
    opt.Lockout.MaxFailedAccessAttempts = 5; // Kullanıcıya 5 hak veriyorum.

    opt.SignIn.RequireConfirmedEmail = true; // Sisteme girecek kişinin "Email" adresinin onaylı olup olmadığını kontrol ediyor. Onaylı değilse sisteme giriş yapamaz.
    //opt.SignIn.RequireConfirmedPhoneNumber = false; // Aynı durum telefon içinde geçerlidir.

})
.AddRoleManager<RoleManager<AppRole>>()
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();


builder.Services.ConfigureApplicationCookie(configure =>
{
    configure.LoginPath = new PathString("/admin/auth/login");
    configure.LogoutPath = new PathString("/admin/auth/logout");
    configure.Cookie = new CookieBuilder
    {
        Name = "AMS",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.Always // --> HTTPS üzerinden erişilebilir yapıyoruz.
    };
    configure.SlidingExpiration = true;
    configure.ExpireTimeSpan = TimeSpan.FromDays(7); // --> Cookie nesnemin kaç gün tutulacağını belirtiyorum.
    configure.AccessDeniedPath = new PathString("/ams/auth/access-denied");
});



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

app.UseSession();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(name: "Admin", areaName: "Admin", pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
    //endpoints.MapDefaultControllerRoute();
    endpoints.MapControllerRoute(name: "Default", pattern: "{controller=Home}/{action=Index}/{id?}");
});
#pragma warning restore ASP0014

app.Run();
