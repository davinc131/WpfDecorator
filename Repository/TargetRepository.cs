using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Adicional;

namespace Repository
{
    public class TargetRepository
    {
        private List<DestinoPassagem> destinos;

        public TargetRepository()
        {
            destinos = new List<DestinoPassagem>();
            Fortaleza fortaleza = new Fortaleza(new PassagemBase());
            RioDeJaneiro rioDeJaneiro = new RioDeJaneiro(new PassagemBase());
            SaoPaulo saoPaulo = new SaoPaulo(new PassagemBase());

            destinos.Add(fortaleza);
            destinos.Add(rioDeJaneiro);
            destinos.Add(saoPaulo);
        }

        public List<DestinoPassagem> getDestinos()
        {
            return destinos;
        }
    }
}
