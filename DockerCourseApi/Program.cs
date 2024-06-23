using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();


var app = builder.Build();
app.UseCors(x => x.AllowAnyOrigin());


app.MapGet("/podcasts", () =>
{
    var dbConnection = new SqlConnection("")


});

app.Run();
