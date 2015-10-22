using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            
            // Observer1 takes a subscription to the store
            IObserver observer1 = new Observer("Observer 1");
            subject.Subscribe(observer1);
            
            // Observer2 also subscribes to the store
            subject.Subscribe(new Observer("Observer 2"));
            
            subject.Inventory++;
            Console.WriteLine("*****");
            
            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            subject.Unsubscribe(observer1);
            subject.Subscribe(new Observer("Observer 3"));
            
            subject.Inventory++;
            Console.WriteLine("*****");


            Console.ReadLine();
        }
    }
}
