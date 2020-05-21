using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adicional
{
    public class PesoExcedente : DestinoPassagem
    {
        public PesoExcedente(Passagem passagem) : base(passagem) { }
        public override double getValorPassagem()
        {
            return 150.00 + this.getPassagem().getValorPassagem();
        }
    }
}
