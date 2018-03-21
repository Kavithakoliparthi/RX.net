using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RX.net
{
    class TimeMilliseconds
    {
        static void Main(string[] args)
        {
            ReplaySubjectBuffer();
            Console.Read();
        }
        public static void ReplaySubjectBuffer()
        {
            var window = TimeSpan.FromMilliseconds(50);
            var subject = new ReplaySubject<string>(window);
            subject.OnNext("a");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            subject.OnNext("b");
            Thread.Sleep(TimeSpan.FromMilliseconds(50));
            subject.OnNext("c");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
    }
}

