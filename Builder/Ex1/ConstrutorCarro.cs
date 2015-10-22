using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class ConstrutorCarro : ConstrutorVeiculo
    {
        public override void ConstruirChassi()
        { 
            veiculo = new Veiculo("Carro"); 
            veiculo["chassi"] = "Chassi do Carro"; 
        }
        
        public override void ConstruirMotor() 
        { 
            veiculo["motor"] = "2500 cc"; 
        }    

        public override void ConstruirRodas() 
        { 
            veiculo["rodas"] = "4"; 
        }    

        public override void ConstruirPortas() 
        { 
            veiculo["portas"] = "4"; 
        }
    }
}
