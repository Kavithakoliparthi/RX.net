using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RX.net
{
    class BufferSize
    {
        static void Main(string[] args)
        {
            ReplaySubjectBuffer();
            Console.Read();
        }
        public static void ReplaySubjectBuffer()
        {
            var bufferSize = 2;   //means only get the last 2 values before our subscription
            var subject = new ReplaySubject<string>(bufferSize);
            subject.OnNext("hello");
            subject.OnNext("rx.net");
            subject.OnNext("hii");
            subject.OnNext("all");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
    }
}

