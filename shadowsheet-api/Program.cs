using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using ShadowAPI.Data;
using ShadowAPI.Services;
using System.Reflection;
using System.Net;

namespace ShadowAPI
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            //BaseEntity be = new SomeEntity();

            //SomeEntity se = new SomeEntity();


            //string bes = be.GetClassName();
            //string ses = se.GetClassName();

            //Assembly ass = Assembly.GetExecutingAssembly();

            //ICollection <Type> _entityClasses = new List<Type>(ReflectionTools.GetTypes(ass, "ShadowAPI.Models"));


            // ICollection<Type> _entityClasses = new List<Type>(
            //ReflectionTools.GetTypes(Assembly.GetExecutingAssembly(), "ShadowAPI.Models"));

            //foreach (Type t in _entityClasses)
            //{
            //    string bla = t.Name;
            //}

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var log = services.GetRequiredService<ILogger<Program>>();

                //try
                //{
                //    var context = services.GetRequiredService<RunnerContext>();
                //    RunnerContextInitializer.Initialize(context);
                //}
                //catch (Exception ex)
                //{
                //    var logger = services.GetRequiredService<ILogger<Program>>();
                //    logger.LogError(ex, "An error occured while initializing the database");
                //}
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseKestrel()
                //.UseKestrel(opt =>
                //{
                //    IPAddress fourtyTwo = IPAddress.Parse("42.42.42.42");
                //    opt.Listen(IPAddress.Loopback, 42000);
                //})

            // 0.0.0.0 defaults is on 'all' ip address, so it hits the local of pc
            .UseUrls("http://0.0.0.0:42000")//"http://10.111.179.252:42000")
            .UseIISIntegration()
            .Build();
    }
}
