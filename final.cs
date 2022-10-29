using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class final
    {
        public string nombreF;
        public int PGF;
        public int PPF;
        public int PEF;
        public int etapaF;
        public double poderF;
        public int golesF;

        public final()
        {
            nombreF = "";
            PGF = 0;
            PPF = 0;
            PEF = 0;
            etapaF = 6;
            golesF = 0;
            poderF = 0;
        }

        public void llenarEquipoFinal(string nom, int pganados, int pperdidos, int pempatados)
        {
            nombreF = nom;
            PGF = pganados;
            PPF = pperdidos;
            PEF = pempatados;
        }

        public void poderFinal()
        {
            poderF = ((PGF * 0.7) - (PPF * 0.2) + (PEF * 0.4)) / etapaF;
        }

        public int anotargolesF()
        {
            for (int i = 0; i < 6; i++)
            {
                var seed = Environment.TickCount;
                var r = new Random(seed);
                double numeroRandom = r.NextDouble();
                if (numeroRandom < poderF)
                {
                    golesF++;
                }
            }
            return golesF;
        }
    }
}
