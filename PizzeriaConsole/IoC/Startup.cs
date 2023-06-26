namespace PizzeriaConsole.IoC;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzeriaConsole.Handlers;

public static class Startup
{
    public static IHostBuilder CreateHostBuilder()
    {
        // build the basepath of appsettings.json (system independent)
        var name = "PizzeriaConsole";
        var path = Directory.GetCurrentDirectory();
        // ...
        var root = Path.GetPathRoot(path) ?? "No PathRoot";
        var bs = Path.Combine(path.Split(Path.DirectorySeparatorChar).TakeWhile(s => !s.Equals(name)).ToArray());
        // ...
        var basepath = Path.Combine(root, bs, name);
        // Console.WriteLine(basepath);
        // ...
        // add the filepath of appsettings.json to host
        var host = Host.CreateDefaultBuilder().UseContentRoot(basepath);

        // add the filepath of appsettings.json to host 
        // (specification where prog take the appsetting.json needed)
        // var host = Host.CreateDefaultBuilder();

        // configure host
        return host.ConfigureServices((context, service)
            => {

                var cn = context.Configuration["ConnectionString"] ?? "No Connection";
                // Console.WriteLine(cn);

                // var ... = new ...
                // var ... = new ...

                // adding services
                service.AddSingleton<IHandler, Handler>();

                // service.AddSingleton<...>(_ => ...);
                // service.AddScoped<...>(_ => ...);
                // service.AddTransient<...>(_ => ...);

                // service.AddSingleton<..., ...>();
                // service.AddScoped<..., ...>();
                // service.AddTransient<..., ...>();
            });
    }
}