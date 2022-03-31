using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddMvc();

RewriteOptions rewriteOptions = new RewriteOptions().AddRewrite("/", "index.html", true);
                
var app = builder.Build();
app.UseRewriter(rewriteOptions);
app.UseDefaultFiles();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
