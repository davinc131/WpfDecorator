using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class DestinoPassagem:Passagem
    {
        private Passagem passagem;

        public DestinoPassagem(Passagem passagem)
        {
            this.passagem = passagem;
        }

        public Passagem getPassagem()
        {
            return passagem;
        }
    }
}
