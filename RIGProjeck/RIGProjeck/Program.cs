using RIGProjeck.Class;

var db = new NepremicninaDB();
DateTime currentDateTime = DateTime.Now;

// Create a DateOnly instance from the current date and time
DateOnly currentDateOnly = DateOnly.FromDateTime(currentDateTime);

// Create an instance of Nepremiènina
//var o = new Nepremiènina("Lenart", 300000, currentDateOnly, 2, 150, 8, 1, 3, 3);
//db.Add(o);
//db.SaveChanges();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<User>();
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
