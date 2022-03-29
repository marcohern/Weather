var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddMvc();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
