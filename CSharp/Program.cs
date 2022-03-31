var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddMvc();

var app = builder.Build();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
