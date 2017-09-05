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
using ShadowAPI.Models;
using ShadowAPI.Data;
using ShadowAPI.Services;
using System.Reflection;

namespace ShadowAPI
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            BaseEntity be = new SomeEntity();

            SomeEntity se = new SomeEntity();


            //string bes = be.GetClassName();
            //string ses = se.GetClassName();

            //Assembly ass = Assembly.GetExecutingAssembly();

            //ICollection <Type> _entityClasses = new List<Type>(ReflectionTools.GetTypes(ass, "ShadowAPI.Models"));


             ICollection<Type> _entityClasses = new List<Type>(
            ReflectionTools.GetTypes(Assembly.GetExecutingAssembly(), "ShadowAPI.Models"));

            foreach (Type t in _entityClasses)
            {
                string bla = t.Name;
            }

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
                .Build();
    }
}
