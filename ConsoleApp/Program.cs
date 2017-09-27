using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDataProtection();
            var services = serviceCollection.BuildServiceProvider();

            // create an instance of MyClass using the service provider
            var instance = ActivatorUtilities.CreateInstance<ClassLibrary1.Class1>(services);
            
                      
            var x=instance.GetStringValue();

            Console.WriteLine("protected Payload:"+x.protectedPayload);
            Console.WriteLine("uprotected Payload:" + x.unprotectedPayload);
            Console.ReadLine();
            ClassLibrary2.Class1 cls = new ClassLibrary2.Class1();

            var x1= cls.GetStrValue();

            Console.WriteLine("protected Payload:" + x1.protectedPayload);
            Console.WriteLine("uprotected Payload:" + x1.unprotectedPayload);
            Console.ReadLine();




        }
        public class EncrypDecryptModel
        {

            public string unprotectedPayload { get; set; }
            public string protectedPayload { get; set; }

        }
    }
}
