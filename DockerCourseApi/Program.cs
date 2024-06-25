using Dapper;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();


var app = builder.Build();
app.UseCors(x => x.AllowAnyOrigin());


app.MapGet("/podcasts", async () =>
{
    var db = new SqlConnection("Server=database;Database=podcasts;User Id=sa;Password=Dometrain#123;");

    var list = await db.QueryAsync<Podcast>("Select * from Podcasts");
    var newList = list.Select(l => l.Title).ToList();

    return newList;
});

app.Run();

public record Podcast(Guid Id, string Title);