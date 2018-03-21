using RX.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace RX.net
{
    class IObserverDemo<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Received value{0}:", value);
        }
        
        public void OnError(Exception error)
        {
            Console.WriteLine(error);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Task complted");
        }
    }
    class IObervableDemo : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(10);
            observer.OnNext(20);
            observer.OnNext(30);
            observer.OnCompleted();
            observer.OnNext(40);
            return Disposable.Empty;
        }
    }
    class Sample
    { 
        static void Main(string[] args)
        {
            IObserverDemo<int> obser = new IObserverDemo<int>();
            IObervableDemo obj = new IObervableDemo();
            obj.Subscribe(obser);
            Console.Read();
        }
    }
}


