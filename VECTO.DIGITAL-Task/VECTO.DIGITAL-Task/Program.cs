using VECTO.DIGITAL_Task.Models.Config;
using VECTO.DIGITAL_Task.Services.Integration;
using VECTO.DIGITAL_Task.Services.Interface;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IImageProcessor, ImageProcessor>();
builder.Services.Configure<PluginConfigs>(builder.Configuration.GetSection("Plugins"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
