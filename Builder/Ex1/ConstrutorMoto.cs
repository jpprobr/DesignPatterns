using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class ConstrutorMoto : ConstrutorVeiculo
    {
         public override void ConstruirChassi()
         {
            veiculo = new Veiculo("Moto");
            veiculo["chassi"] = "Chassi da Moto";
         }

         public override void ConstruirMotor()
         {
             veiculo["motor"] = "500 cc";
         }

         public override void ConstruirRodas()
         {
             veiculo["rodas"] = "2";
         }

         public override void ConstruirPortas()
         {
             veiculo["portas"] = "0";
         }
    }
}
