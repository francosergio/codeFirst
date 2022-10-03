using DB;
using Microsoft.EntityFrameworkCore;
using WebAPIClient.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IClient,ClientR>();

/**** agrege esto **/
builder.Services.AddDbContext<BI_TESTGENContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("BI_TESTGENConnection"))
);
/******/


var app = builder.Build();


/*** agrege esto   migracion del codigo de la base datos ***/
using (var scope=app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<BI_TESTGENContext>();
    context.Database.Migrate();
}
/******/

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
