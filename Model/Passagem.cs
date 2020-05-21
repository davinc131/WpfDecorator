using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Passagem
    {
        private string destino;

        public abstract double getValorPassagem();

        public string getDestino()
        {
            return destino;
        }

        public void setDestino(string destino)
        {
            this.destino = destino;
        }
    }
}
