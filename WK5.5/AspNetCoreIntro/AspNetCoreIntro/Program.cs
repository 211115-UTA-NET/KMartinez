using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Text;
//This is me trying to follow along so far most of the code worked.


//webapplication builder
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
WebApplication app = builder.Build();

//app.MapGet("/", () => "Hello World!");  //opens on browser


/*After you have a web application you need to construct its
request-processing pipepline using components called "middlewares"
*/


//app.Use((context, next) =>
//{
//    if (context.Request.Query["authenticated"] == "true")
//    {
//        //This middleware is done, let the next one in the piepline take over
//        next(context);
//    }
//    else
//    {
//        context.Response.StatusCode = 401;
//        context.Response.ContentType = "text/plain";
//        context.Response.Body.Write(Encoding.UTF8.GetBytes("errors, not authenticated"));
//    }

    
//    return Task.CompletedTask;
//});

/*this call add a middlewar to pipline.
each middleware runs in sequences*/
app.Run(context =>
{





    string path = context.Request.Path;
    //string queryValue = context.Request.Query["data"];
    string dataValue = context.Request.Query["data"];

    //the HttpContext parameter 
    context.Response.StatusCode = 200;
   // context.Response.Body.Write($"path was: {path}, data was {}");
    context.Response.Body.Write(Encoding.UTF8.GetBytes($"path was: {path}, data was {dataValue}"));
    //need this line so it can comple(really thsi delgate should be aysnc but we haven't done that yet)
    return Task.CompletedTask;
});

//similar to Console.ReadLine()
//this one runs the app
app.Run();
