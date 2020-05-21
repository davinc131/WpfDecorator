using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RioDeJaneiro:DestinoPassagem
    {
        public RioDeJaneiro(Passagem passagem) : base(passagem) { }

        public override double getValorPassagem()
        {
            return 480.97 + this.getPassagem().getValorPassagem();
        }

        public override string ToString()
        {
            return "Rio de Janeiro";
        }
    }
}
