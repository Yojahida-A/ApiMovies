using Microsoft.EntityFrameworkCore;
using MovieApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar el contexto de la base de datos
builder.Services.AddDbContext<AppDbContext>();
// Agregar servicios para controladores
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
  //  app.UseExceptionHandler("/Error");
//}
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
