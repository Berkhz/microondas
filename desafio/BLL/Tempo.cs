using desafio.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.BLL
{
    public class Tempo : ITempo
    {
        public void ValidarTempo(int tempo)
        {
            if (tempo < 1 || tempo > 120)
            {
                throw new ArgumentOutOfRangeException("O tempo deve estar entre 1 e 120 segundos.");
            }
        }
    }
}
