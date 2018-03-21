using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RX.net
{
    class DefaultDemo
    {
        static void Main(string[] args)
        {
            var sub =new  BehaviorSubject<string>("sfsrf");
            sub.Subscribe(value => Console.WriteLine(value));
            sub.OnNext("hello");
            sub.OnNext("hiii");
            Console.ReadLine();
        }

    }
}
