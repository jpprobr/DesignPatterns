using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Observer : IObserver
    {
        public string ObserverName { get; private set; }


        public Observer(string name)
        {
            this.ObserverName = name;
        }

        public void Update()
        {
            Console.WriteLine("{0}: Um novo produto chegou na loja...", this.ObserverName);
        }

    }
}
