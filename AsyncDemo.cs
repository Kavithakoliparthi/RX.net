using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RX.net
{
    class AsyncDemo
    {
        static void Main(string[] args)
        {
            ParallelExecutionTest();
            Console.Read();
        }
        public static async void ParallelExecutionTest()
        {
            var o = Observable.CombineLatest(
                Observable.Start(() => 
                {
                    Console.WriteLine("Executing 1st Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                    return "First";
                }),
                Observable.Start(() => 
                {
                    Console.WriteLine("Executing 2nd Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                    return "Second";
                }),
                Observable.Start(() => 
                {
                    Console.WriteLine("Executing 3rd Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                    return "Third";
                }),
                Observable.Start(() =>
                {
                    Console.WriteLine("Executing 4 th Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                    return "Fourth";
                })

            ).Finally(() => Console.WriteLine("completed"));

            foreach(string s in await o.FirstAsync())
            {
                Console.WriteLine(s);
            }
        }
    }
}
