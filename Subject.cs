using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RX.net
{
    class Subject1
    {
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            WriteSequenceToConsole(subject);
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
            Console.ReadKey();
        }

        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            //The next two lines are equivalent.
            sequence.Subscribe(value=>Console.WriteLine(value));
            //sequence.Subscribe(Console.WriteLine);
        }
    }
}
