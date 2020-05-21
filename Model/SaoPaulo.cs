using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SaoPaulo:DestinoPassagem
    {
        public SaoPaulo(Passagem passagem) : base(passagem) { }

        public override double getValorPassagem()
        {
            return 298.63 + this.getPassagem().getValorPassagem();
        }

        public override string ToString()
        {
            return "São Paulo";
        }
    }
}
