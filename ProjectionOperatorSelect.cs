using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RX.net
{
    class Class1
    {
        static void Main()
        {
            var number = Observable.Interval(TimeSpan.FromSeconds(2));
            var numbers = from n in number
                                  select n * 2;
            Console.WriteLine("Numbers * 2:");
            numbers.Subscribe(num =>
            {
                Console.WriteLine(num);
            });
            Console.ReadKey();
        }
    }
}
