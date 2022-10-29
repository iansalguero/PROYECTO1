using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class equipo
    {
        public string nombre;
        public int PG;
        public int PP;
        public int PE;
        public int etapa;
        public double poder;
        public int goles;
     
        public equipo ()
        {
            nombre = "";
            PG = 0;
            PP = 0;
            PE = 0;
            etapa = 4;
            goles = 0;
            poder = 0;
        }

        public void llenarEquipo()
        {
            while (PG+PP+PE != 4)
            {
                Console.WriteLine("Ingrese el nombre del equipo: ");
                nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("*La suma de los partidos que ingresará a continuación debe ser igual a 4*");
                Console.WriteLine();
                Console.WriteLine("Ingrese los partidos ganados: ");
                PG = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los partidos perdidos: ");
                PP = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los partidos empatados: ");
                PE = int.Parse(Console.ReadLine());
                poder = ((PG * 0.7) - (PP * 0.2) + (PE * 0.4)) / etapa;
                Console.WriteLine();
                Console.WriteLine("El poder del equipo es de: " + poder);
            }
        }
        public int anotargoles()
        {
            for (int i = 0; i < 6; i++)
            {
                var seed = Environment.TickCount;
                var r = new Random(seed);
                double numeroRandom = r.NextDouble();
                if (numeroRandom < poder)
                {
                    goles++;
                }
            }
            return goles;
        }
    }
}
