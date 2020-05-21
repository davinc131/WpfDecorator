using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adicional
{
    public class BagagemDeMao : DestinoPassagem
    {
        public BagagemDeMao(Passagem passagem) : base(passagem){}

        public override double getValorPassagem()
        {
            return 40.00 + this.getPassagem().getValorPassagem();
        }
    }
}
