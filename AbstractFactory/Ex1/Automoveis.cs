using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// Cliente
    /// </summary>
    class Automoveis
    {
        private Moto _moto;

        private Carro _carro;

        public Automoveis(FabricaMontadora fabrica)
        {
            this._moto = fabrica.CriaMoto();
            this._carro = fabrica.CriaCarro();
        }
    }
}
