using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Concrete;

namespace ResourceBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Resources.Utility.ResourceBuilder();
            string filePath = builder.Create(new DbResourceProvider(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MvcInternationalization;Integrated Security=True;Pooling=False"),
                summaryCulture: "tr-TR");
            Console.WriteLine("Created file {0}", filePath);
            Console.ReadLine();
        }
    }
}
