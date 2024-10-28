using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options => options.JsonSerializerOptions.SerializerSettings.ContractResolver = new DefaultContractResolver());
// Add services to the container.
builder.Services.AddAntiforgery(o => o.HeaderName = "XSRF-Token");
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
