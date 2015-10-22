using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                // Just to make sure that if there is an increase in inventory then only we are notifying the observers.
                if (value > _int)
                    Notify();

                _int = value;
            }
        }


        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ForEach(x => x.Update());
        }
    }  
}
