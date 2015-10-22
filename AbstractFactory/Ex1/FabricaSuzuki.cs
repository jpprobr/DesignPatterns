using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// FábricaConcreta2
    /// </summary>
    public class FabricaSuzuki : FabricaMontadora
    {

        public override Moto CriaMoto()
        {
            return new Katana();
        }

        public override Carro CriaCarro()
        {
            return new Vitara();
        }
    }
}