using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TetrisApp.Data;

namespace TetrisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Piece piece = new Piece();
            Piece piece2 = new Piece();
            Piece piece3= new Piece();
            Piece piece4 = new Piece();


            Console.WriteLine(piece.printPiece(piece.thisPiece));
            Console.WriteLine(piece.printPiece(piece.RotatePiece()));


        }
    }
}

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();
// builder.Services.AddSingleton<WeatherForecastService>();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
// }


// app.UseStaticFiles();

// app.UseRouting();

// app.MapBlazorHub();
// app.MapFallbackToPage("/_Host");

// app.Run();
