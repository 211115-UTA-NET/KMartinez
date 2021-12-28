using System.Net;
using System.Text;
using System.Xml.Serialization;
using AspNetCoreIntro.Middleware;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
/*before building an applocatopn set up middlewaer will nedd when they run*/
builder.Services.AddControllers();
WebApplication app = builder.Build();



app.UseStaticFiles();


//Replace by
app.UseMiddleware<DataSerializeMiddleware>();
//app.Use(async (context, next) =>
//{
//    if (context.Request.Query["authenticated"] == "true")
//    {
//        // "this middleware is done, let the next one in the pipeline take over"
//        await next(context);
//    }
//    else
//    {
//        // if we don't invoke "next", this middleware is "short-circuiting" the pipeline -
//        // it better finish setting up the response.

//        context.Response.StatusCode = 401;
//        context.Response.ContentType = "text/plain";
//        //await context.Response.Body.WriteAsync(Encoding.UTF8.GetBytes("error, not authenticated"));
//        await context.Response.WriteAsync("error, not authenticated");
//        //context.Response.Body
//    }
//});
app.UseRouting();
app.UseEndpoints(routeBuilder =>
{
    routeBuilder.MapControllers();
});


// broken?
app.Map("/map1", async context =>
{
    //await context.Response.Body.WriteAsync(Encoding.UTF8.GetBytes("Hello from map1"));
    await context.Response.WriteAsync("Hello from map1");
});

app.Map("/map2", async context =>
{
    await context.Response.WriteAsync("Hello from map2");
});

// "Run" middleware is at the end of the pipeline (no "next")
app.Run(async context =>
{
    // the HttpContext parameter (context) gives access to all the request data
    // and lets you modify all the response data.

    string path = context.Request.Path;
    string dataValue = context.Request.Query["data"];

    context.Response.StatusCode = 200;
    context.Response.ContentType = "text/plain";
    // serializing the string as bytes using UTF8 encoding, and writing it to the
    // HTTP response directly
    await context.Response.WriteAsync($"path was: {path}, data was {dataValue}");

    // need this line so it compiles
    // (really this delegate should've been async but we hadn't done that yet) (it's now async)
    //return Task.CompletedTask;
});


// this call runs the app
await app.RunAsync();



























//Mine
//using Microsoft.AspNetCore.Server.Kestrel.Core;
//using System.Text;
////This is me trying to follow along so far most of the code worked.


////webapplication builder
//WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
//builder.Services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
//WebApplication app = builder.Build();

////app.MapGet("/", () => "Hello World!");  //opens on browser


///*After you have a web application you need to construct its
//request-processing pipepline using components called "middlewares"
//*/


////app.Use((context, next) =>
////{
////    if (context.Request.Query["authenticated"] == "true")
////    {
////        //This middleware is done, let the next one in the piepline take over
////        next(context);
////    }
////    else
////    {
////        context.Response.StatusCode = 401;
////        context.Response.ContentType = "text/plain";
////        context.Response.Body.Write(Encoding.UTF8.GetBytes("errors, not authenticated"));
////    }


////    return Task.CompletedTask;
////});

///*this call add a middlewar to pipline.
//each middleware runs in sequences*/
//app.Run(context =>
//{





//    string path = context.Request.Path;
//    //string queryValue = context.Request.Query["data"];
//    string dataValue = context.Request.Query["data"];

//    //the HttpContext parameter 
//    context.Response.StatusCode = 200;
//   // context.Response.Body.Write($"path was: {path}, data was {}");
//    context.Response.Body.Write(Encoding.UTF8.GetBytes($"path was: {path}, data was {dataValue}"));
//    //need this line so it can comple(really thsi delgate should be aysnc but we haven't done that yet)
//    return Task.CompletedTask;
//});

////similar to Console.ReadLine()
////this one runs the app
//app.Run();
