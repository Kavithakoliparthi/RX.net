using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RX.net
{
    class RestrictionOperationWhere
    {
       static void Main()
        {
            var num= Observable.Interval(TimeSpan.FromSeconds(2));
            var numbers = from n in num
                          where n < 10
                          select n;

            Console.WriteLine("Numbers < 10:");
            numbers.Subscribe(lowNum =>
            {
                Console.WriteLine(lowNum);
            });

            Console.ReadKey();
        }
    }
}
