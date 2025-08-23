using desafio.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.BLL
{
    public class Potencia : IPotencia
    {
        public void ValidarPotencia(int potencia)
        {
            if (potencia < 1 || potencia > 10)
            {
                throw new ArgumentOutOfRangeException("A potência deve estar entre 1 e 10.");
            }
        }
    }
}
