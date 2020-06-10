using System;
using System.Reflection;
using System.Runtime.Versioning;
using Newtonsoft.Json;

namespace libSrc
{
    public class MyClass
    {
        public static void DoThing()
        {
            Console.Out.WriteLine($"Environment: {Environment.Version}");
            
            Console.Out.WriteLine(JsonConvert.SerializeObject(new { Test="value"}));
            Console.Out.WriteLine(System.Reflection.Assembly.GetAssembly(typeof(JsonConvert)).GetName().Version);

            var framework = Assembly
                .GetEntryAssembly()?
                .GetCustomAttribute<TargetFrameworkAttribute>()?
                .FrameworkName;

#if CORE
            Console.Out.WriteLine("IS IN DOTNET CORE!");
#endif


            Console.Out.WriteLine($"Framework: {framework}");
        }
    }
}
