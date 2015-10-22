using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public sealed class Cadeira
    {
        private static readonly Cadeira _uniqueInstance = new Cadeira();

        public static Cadeira UniqueInstance
        {
            get 
            { 
                return Cadeira._uniqueInstance; 
            }
        }

        public int Quantidade { get; set; }

        private Cadeira()
        {

        }
    }
}