using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class semis
    {
        public string nombreS;
        public int PGS;
        public int PPS;
        public int PES;
        public int etapaS;
        public double poderS;
        public int golesS;

        public semis()
        {
            nombreS = "";
            PGS = 0;
            PPS = 0;
            PES = 0;
            etapaS = 5;
            golesS = 0;
            poderS = 0;
        }
        public void llenarEquipoSemis(string nom, int pganados, int pperdidos, int pempatados)
        {
            nombreS = nom;
            PGS = pganados;
            PPS = pperdidos;
            PES = pempatados;
        }

        public void poderSemis()
        {
            poderS = ((PGS * 0.7) - (PPS * 0.2) + (PES * 0.4)) / etapaS;
        }

        public int anotargolesS()
        {
            for (int i = 0; i < 6; i++)
            {
                var seed = Environment.TickCount;
                var r = new Random(seed);
                double numeroRandom = r.NextDouble();
                if (numeroRandom < poderS)
                {
                    golesS++;
                }
            }
            return golesS;
        }
    }
}
