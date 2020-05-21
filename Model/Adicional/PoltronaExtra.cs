using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adicional
{
    public class PoltronaExtra : DestinoPassagem
    {
        public PoltronaExtra(Passagem passagem) : base(passagem){}
        public override double getValorPassagem()
        {
            return 200.00 + this.getPassagem().getValorPassagem();
        }
    }
}
