using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public interface IImposto
    {        
        double Calcula(Orcamento orcamento); // Imposto é algo que recebe um orçamento e retorna um valor calculado
    }
}