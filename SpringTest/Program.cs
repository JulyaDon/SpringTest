using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

namespace SpringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using(IApplicationContext ctx = ContextRegistry.GetContext()){
                ISimpleMessage simpleMessage = (ISimpleMessage)ctx.GetObject("SimpleMessage");
                Console.WriteLine(simpleMessage.Message);
                Console.Read();
            }
        }
    }
}
