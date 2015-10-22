using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// FábricaConcreta1
    /// </summary>
    public class FabricaHonda : FabricaMontadora
    {
        public override Moto CriaMoto()
        {
            return new Titan();
        }

        public override Carro CriaCarro()
        {
            return new Fit();
        }
    }
}
