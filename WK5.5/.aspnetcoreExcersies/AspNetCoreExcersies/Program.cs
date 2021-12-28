//Exce// exercise option 1:
//    make an asp.net core app (start with the empty template) that
//      keeps track of some structured data in custom classes and uses serialization
//      to respond with the data. for example: static list of rock-paper-scissors roundresults,
//    and use XmlSerializer to convert it to XML in the response body.
// exercise option 2:
//   make an asp.net core app (start with the empty template) that
//     treat the "path" as a relative path on the server's file system.
//     the response should include the contents of that file.
//     example: https://localhost:7206/Program.cs
//     choose a good content type based on the file extension.
//     return 404 if no such file.
// 
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Text;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!" + "goodbye"); //to check if program works

app.Run(context =>
{
    //Exercise option 2
  

    string path = context.Request.Path;
    string fileName = ($"Exercise2.txt");
    //string filePath = System.IO.File.ReadAllText($"C:/Users/mkare_wyte20y/Revature/KarenM/WK5.5/.aspnetcoreExcersies/AspNetCoreExcersies/Excercise2.txt");
    string filePath = System.IO.File.ReadAllText($"C:../AspNetCoreExcersies/Excercise2.txt"); //relative path
    
    
    context.Response.StatusCode = 404;
    context.Response.Body.Write(Encoding.UTF8.GetBytes($"path was: {path}, data was {filePath}, filename: {fileName}"));

    //Exercise option 1

    return Task.CompletedTask;
});

//not sure if its needed
object FileInfo(string filePath, string fileName)
{
    throw new NotImplementedException();
}

app.Run();//Runs app
