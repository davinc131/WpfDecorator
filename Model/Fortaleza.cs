using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fortaleza : DestinoPassagem
    {
        public Fortaleza(Passagem passagem):base(passagem){}

        public override double getValorPassagem()
        {
            return 345.65 + this.getPassagem().getValorPassagem();
        }

        public override string ToString()
        {
            return "Fortaleza";
        }
    }
}
