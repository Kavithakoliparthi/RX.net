using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RX.net
{
    class AsyncsubjectDemo
    {
        static void Main(string[] args)
        {
            var subject = new AsyncSubject<string>();
            //In the asyncSubject only one value will be printed then immediately complete
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            Console.ReadKey();
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
    }
}
