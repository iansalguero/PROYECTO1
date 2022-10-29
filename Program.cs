using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        //INGRESO de EQUIPOS y ASIGNACIÓN de PARTIDOS, PODER y GOLES
        static void Main()
        {
            semis equipo1S = new semis();
            semis equipo2S = new semis();
            semis equipo3S = new semis();
            semis equipo4S = new semis();
            Console.WriteLine("Equipo 1");
            Console.WriteLine();
            equipo equipo1 = new equipo();
            equipo1.llenarEquipo();
            equipo1.anotargoles();
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine();
            Console.WriteLine("Equipo 2");
            equipo equipo2 = new equipo();
            equipo2.llenarEquipo();
            equipo2.anotargoles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Equipo 3");
            Console.WriteLine();
            equipo equipo3 = new equipo();
            equipo3.llenarEquipo();
            equipo3.anotargoles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Equipo 4");
            Console.WriteLine();
            equipo equipo4 = new equipo();
            equipo4.llenarEquipo();
            equipo4.anotargoles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Equipo 5");
            Console.WriteLine();
            equipo equipo5 = new equipo();
            equipo5.llenarEquipo();
            equipo5.anotargoles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Equipo 6");
            Console.WriteLine();
            equipo equipo6 = new equipo();
            equipo6.llenarEquipo();
            equipo6.anotargoles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Equipo 7");
            Console.WriteLine();
            equipo equipo7 = new equipo();
            equipo7.llenarEquipo();
            equipo7.anotargoles();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Equipo 8");
            Console.WriteLine();
            equipo equipo8 = new equipo();
            equipo8.llenarEquipo();
            equipo8.anotargoles();
            Console.ReadKey();
            Console.Clear();

            // ASÍGNACIÓN DE EQUIPOS, PODER Y GOLES PARA SEMIS

            
            bool equipo1res = false;
            bool equipo2res = false;

            
            bool equipo3res = false;
            bool equipo4res = false;


            
            bool equipo5res = false;
            bool equipo6res = false;


            
            bool equipo7res = false;
            bool equipo8res = false;


            // CUARTOS DE FINAL

            Console.WriteLine("Cuartos de Final");
            Console.WriteLine();
            Console.WriteLine("Partido 1");

           if (equipo1.goles == equipo2.goles)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo1.nombre + " " + equipo1.goles + "-" + equipo2.goles + " " + equipo2.nombre);
                equipo1.goles = equipo1.goles + equipo1.anotargoles();
                equipo2.goles = equipo2.goles + equipo2.anotargoles();
                if (equipo1.goles > equipo2.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo1.nombre + " " + equipo1.goles + "-" + equipo2.goles + " " + equipo2.nombre);
                    Console.WriteLine("El ganador es: " + equipo1.nombre);
                    equipo1res = true;
                }
                else if (equipo1.goles < equipo2.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo1.nombre + " " + equipo1.goles + "-" + equipo2.goles + " " + equipo2.nombre);
                    Console.WriteLine("El ganador es: " + equipo2.nombre);
                    equipo2res = true;
                }
                else if (equipo1.goles == equipo2.goles)
                {
                    if (equipo1.poder > equipo2.poder) {Console.WriteLine("EL ganador en tiempos extras es: " + equipo1.nombre);}
                    equipo1res = true;
                    if (equipo1.poder < equipo2.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo2.nombre);}
                    equipo2res = true;
                }
            }

           else if (equipo1.goles > equipo2.goles)
            {
                Console.WriteLine(equipo1.nombre + " " + equipo1.goles + "-" + equipo2.goles + " " + equipo2.nombre);
                Console.WriteLine("El ganador es: " + equipo1.nombre);
                equipo1res = true;
            }

            else
            {
                Console.WriteLine(equipo1.nombre + " " + equipo1.goles + "-" + equipo2.goles + " " + equipo2.nombre);
                Console.WriteLine("El ganador es: " + equipo2.nombre);
                equipo2res = true;
            }
            if (equipo1res == true)
            {
                equipo1S.llenarEquipoSemis(equipo1.nombre, equipo1.PG, equipo1.PP, equipo1.PE);
                
            }
            else if (equipo2res == true)
            {
                equipo1S.llenarEquipoSemis(equipo2.nombre, equipo2.PG, equipo2.PP, equipo2.PE);
                
            }

            equipo1S.poderSemis();
            equipo1S.anotargolesS();




            Console.WriteLine();
            Console.WriteLine("Partido 2");

            if (equipo3.goles == equipo4.goles)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo3.nombre + " " + equipo3.goles + "-" + equipo4.goles + " " + equipo4.nombre);
                equipo3.goles = equipo3.goles + equipo3.anotargoles();
                equipo4.goles = equipo4.goles + equipo4.anotargoles();
                if (equipo3.goles > equipo4.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo3.nombre + " " + equipo3.goles + "-" + equipo4.goles + " " + equipo4.nombre);
                    Console.WriteLine("El ganador es: " + equipo3.nombre);
                    equipo3res = true;
                }
                else if (equipo3.goles < equipo4.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo3.nombre + " " + equipo3.goles + "-" + equipo4.goles + " " + equipo4.nombre);
                    Console.WriteLine("El ganador es: " + equipo4.nombre);
                    equipo4res = true;
                }
                else if (equipo3.goles == equipo4.goles)
                {
                    if (equipo3.poder > equipo4.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo3.nombre); }
                    equipo3res = true;
                    if (equipo3.poder < equipo4.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo4.nombre); }
                    equipo4res = true;
                }
            }

            else if (equipo3.goles > equipo4.goles)
            {
                Console.WriteLine(equipo3.nombre + " " + equipo3.goles + "-" + equipo4.goles + " " + equipo4.nombre);
                Console.WriteLine("El ganador es: " + equipo3.nombre);
                equipo3res = true;
            }

            else
            {
                Console.WriteLine(equipo3.nombre + " " + equipo3.goles + "-" + equipo4.goles + " " + equipo4.nombre);
                Console.WriteLine("El ganador es: " + equipo4.nombre);
                equipo4res = true;

            }
            if (equipo3res == true)
            {
                equipo2S.llenarEquipoSemis(equipo3.nombre, equipo3.PG, equipo3.PP, equipo3.PE);
                
            }
            else if (equipo4res == true)
            {
                equipo1S.llenarEquipoSemis(equipo4.nombre, equipo4.PG, equipo4.PP, equipo4.PE);
                
            }

            equipo2S.poderSemis();
            equipo2S.anotargolesS();




            Console.WriteLine();
            Console.WriteLine("Partido 3");

            if (equipo5.goles == equipo6.goles)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo5.nombre + " " + equipo5.goles + "-" + equipo6.goles + " " + equipo6.nombre);
                equipo5.goles = equipo5.goles + equipo5.anotargoles();
                equipo6.goles = equipo6.goles + equipo6.anotargoles();
                if (equipo5.goles > equipo6.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo5.nombre + " " + equipo5.goles + "-" + equipo6.goles + " " + equipo6.nombre);
                    Console.WriteLine("El ganador es: " + equipo5.nombre);
                    equipo5res = true;
                }
                else if (equipo5.goles < equipo6.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo5.nombre + " " + equipo5.goles + "-" + equipo6.goles + " " + equipo6.nombre);
                    Console.WriteLine("El ganador es: " + equipo6.nombre);
                    equipo6res = true;
                }
                else if (equipo5.goles == equipo6.goles)
                {
                    if (equipo5.poder > equipo6.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo5.nombre); }
                    equipo5res = true;
                    if (equipo5.poder < equipo6.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo6.nombre); }
                    equipo6res = true;
                }
            }

            else if (equipo5.goles > equipo6.goles)
            {
                Console.WriteLine(equipo5.nombre + " " + equipo5.goles + "-" + equipo6.goles + " " + equipo6.nombre);
                Console.WriteLine("El ganador es" + equipo5.nombre);
                equipo5res = true;
            }

            else
            {
                Console.WriteLine(equipo5.nombre + " " + equipo5.goles + "-" + equipo6.goles + " " + equipo6.nombre);
                Console.WriteLine("El ganador es" + equipo6.nombre);
                equipo6res = true;
            }
            if (equipo5res == true)
            {
                equipo3S.llenarEquipoSemis(equipo5.nombre, equipo5.PG, equipo5.PP, equipo5.PE);
               
            }
            else if (equipo6res == true)
            {
                equipo3S.llenarEquipoSemis(equipo6.nombre, equipo6.PG, equipo6.PP, equipo6.PE);
                
            }

            equipo3S.poderSemis();
            equipo3S.anotargolesS();



            Console.WriteLine();
            Console.WriteLine("Partido 4");

            if (equipo7.goles == equipo8.goles)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo7.nombre + " " + equipo7.goles + "-" + equipo8.goles + " " + equipo8.nombre);
                equipo7.goles = equipo7.goles + equipo7.anotargoles();
                equipo8.goles = equipo8.goles + equipo8.anotargoles();
                if (equipo7.goles > equipo8.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo7.nombre + " " + equipo7.goles + "-" + equipo8.goles + " " + equipo8.nombre);
                    Console.WriteLine("El ganador es: " + equipo7.nombre);
                    equipo7res = true;
                }
                else if (equipo7.goles < equipo8.goles)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo7.nombre + " " + equipo7.goles + "-" + equipo8.goles + " " + equipo8.nombre);
                    Console.WriteLine("El ganador es: " + equipo8.nombre);
                    equipo8res = true;
                }
                else if (equipo7.goles == equipo8.goles)
                {
                    if (equipo7.poder > equipo8.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo7.nombre); }
                    equipo7res = true;
                    if (equipo7.poder < equipo8.poder) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo8.nombre); }
                    equipo8res = true;
                }
            }

            else if (equipo7.goles > equipo8.goles)
            {
                Console.WriteLine(equipo7.nombre + " " + equipo7.goles + "-" + equipo8.goles + " " + equipo8.nombre);
                Console.WriteLine("El ganador es: " + equipo7.nombre);
                equipo7res = true;
            }

            else
            {
                Console.WriteLine(equipo7.nombre + " " + equipo7.goles + "-" + equipo8.goles + " " + equipo8.nombre);
                Console.WriteLine("El ganador es: " + equipo8.nombre);
                equipo8res = true;
            }
            if (equipo7res == true)
            {
                equipo4S.llenarEquipoSemis(equipo7.nombre, equipo7.PG, equipo7.PP, equipo7.PE);
                
            }
            else if (equipo8res == true)
            {
                equipo4S.llenarEquipoSemis(equipo8.nombre, equipo8.PG, equipo8.PP, equipo8.PE);
                
            }

            equipo4S.poderSemis();
            equipo4S.anotargolesS();

            // Asignacion equipos para final

            final equipo1F = new final();
            bool equipo1ref = false;
            bool equipo2ref = false;

            final equipo2F = new final();
            bool equipo3ref = false;
            bool equipo4ref = false;

            //SEMI FINALES
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Semi Finales");
            Console.WriteLine();
            Console.WriteLine("Partido 1");

            if (equipo1S.golesS == equipo2S.golesS)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo1S.nombreS + " " + equipo1S.golesS + "-" + equipo2S.golesS + " " + equipo2S.nombreS);
                equipo1S.golesS = equipo1S.golesS + equipo1S.anotargolesS();
                equipo2S.golesS = equipo2S.golesS + equipo2S.anotargolesS();
                if (equipo1S.golesS > equipo2S.golesS)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo1S.nombreS + " " + equipo1S.golesS + "-" + equipo2S.golesS + " " + equipo2S.nombreS);
                    Console.WriteLine("El ganador es: " + equipo1S.nombreS);
                    equipo1ref = true;
                }
                else if (equipo1S.golesS < equipo2S.golesS)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo1S.nombreS + " " + equipo1S.golesS + "-" + equipo2S.golesS + " " + equipo2S.nombreS);
                    Console.WriteLine("El ganador es: " + equipo2S.nombreS);
                    equipo2ref = true;
                }
                else if (equipo1S.golesS == equipo2S.golesS)
                {
                    if (equipo1S.poderS > equipo2S.poderS) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo1S.nombreS); }
                    equipo1ref = true;
                    if (equipo1S.poderS < equipo2S.poderS) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo2S.nombreS); }
                    equipo2ref = true;
                }
            }

            else if (equipo1S.golesS > equipo2S.golesS)
            {
                Console.WriteLine(equipo1S.nombreS + " " + equipo1S.golesS + "-" + equipo2S.golesS + " " + equipo2S.nombreS);
                Console.WriteLine("El ganador es: " + equipo1S.nombreS);
                equipo1ref = true;
            }

            else
            {
                Console.WriteLine(equipo1S.nombreS + " " + equipo1S.golesS + "-" + equipo2S.golesS + " " + equipo2S.nombreS);
                Console.WriteLine("El ganador es: " + equipo2S.nombreS);
                equipo2ref = true;
            }
            if (equipo1ref == true)
            {
                equipo1F.llenarEquipoFinal(equipo1S.nombreS, equipo1S.PGS, equipo1S.PPS, equipo1S.PES);
            }
            else if (equipo2ref == true)
            {
                equipo1F.llenarEquipoFinal(equipo2S.nombreS, equipo2S.PGS, equipo2S.PPS, equipo2S.PES);
            }

            equipo1F.poderFinal();
            equipo1F.anotargolesF();


            Console.WriteLine();
            Console.WriteLine("Partido 2");

            if (equipo3S.golesS == equipo4S.golesS)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo3S.nombreS + " " + equipo3S.golesS + "-" + equipo4S.golesS + " " + equipo4S.nombreS);
                equipo3S.golesS = equipo3S.golesS + equipo3S.anotargolesS();
                equipo4S.golesS = equipo4S.golesS + equipo4S.anotargolesS();
                if (equipo3S.golesS > equipo4S.golesS)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo3S.nombreS + " " + equipo3S.golesS + "-" + equipo4S.golesS + " " + equipo4S.nombreS);
                    Console.WriteLine("El ganador es: " + equipo3S.nombreS);
                    equipo3ref = true;
                }
                else if (equipo3S.golesS < equipo4S.golesS)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo3S.nombreS + " " + equipo3S.golesS + "-" + equipo4S.golesS + " " + equipo4S.nombreS);
                    Console.WriteLine("El ganador es: " + equipo4S.nombreS);
                    equipo4ref = true;
                }
                else if (equipo3S.golesS == equipo4S.golesS)
                {
                    if (equipo3S.poderS > equipo4S.poderS) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo3S.nombreS); }
                    equipo3ref = true;
                    if (equipo3S.poderS < equipo4S.poderS) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo4S.nombreS); }
                    equipo4ref = true;
                }
            }

            else if (equipo3S.golesS > equipo4S.golesS)
            {
                Console.WriteLine(equipo3S.nombreS + " " + equipo3S.golesS + "-" + equipo4S.golesS + " " + equipo4S.nombreS);
                Console.WriteLine("El ganador es: " + equipo3S.nombreS);
                equipo3ref = true;
            }

            else
            {
                Console.WriteLine(equipo3S.nombreS + " " + equipo3S.golesS + "-" + equipo4S.golesS + " " + equipo4S.nombreS);
                Console.WriteLine("El ganador es: " + equipo4S.nombreS);
                equipo4ref = true;
            }
            if (equipo3ref == true)
            {
                equipo2F.llenarEquipoFinal(equipo3S.nombreS, equipo3S.PGS, equipo3S.PPS, equipo3S.PES);
            }
            else if (equipo4ref == true)
            {
                equipo2F.llenarEquipoFinal(equipo4S.nombreS, equipo4S.PGS, equipo4S.PPS, equipo4S.PES);
            }

            equipo2F.poderFinal();
            equipo2F.anotargolesF();

            //FINAL
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Final");
            Console.WriteLine();
            
            if (equipo1F.golesF == equipo2F.golesF)
            {
                Console.WriteLine("Se fueron a tiempos extras! El resultado por ahora es: " + equipo1F.nombreF + " " + equipo1F.golesF + "-" + equipo2F.golesF + " " + equipo2F.nombreF);
                equipo1F.golesF = equipo1F.golesF + equipo1F.anotargolesF();
                equipo2F.golesF = equipo2F.golesF + equipo2F.anotargolesF();
                if (equipo1F.golesF > equipo2F.golesF)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo1F.nombreF + " " + equipo1F.golesF + "-" + equipo2F.golesF + " " + equipo2F.nombreF);
                    Console.WriteLine("El ganador del torneo es: " + equipo1F.nombreF);
                }
                else if (equipo1F.golesF < equipo2F.golesF)
                {
                    Console.WriteLine("El resultado en tiempos extras es: " + equipo1F.nombreF + " " + equipo1F.golesF + "-" + equipo2F.golesF + " " + equipo2F.nombreF);
                    Console.WriteLine("El ganador es: " + equipo2F.nombreF);
                }
                else if (equipo1F.golesF == equipo2F.golesF)
                {
                    if (equipo1F.poderF > equipo2F.poderF) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo1F.nombreF); }
                    if (equipo1F.poderF < equipo2F.poderF) { Console.WriteLine("EL ganador en tiempos extras es: " + equipo2F.nombreF); }
                }
            }

            else if (equipo1F.golesF > equipo2F.golesF)
            {
                Console.WriteLine(equipo1F.nombreF + " " + equipo1F.golesF + "-" + equipo2F.golesF + " " + equipo2F.nombreF);
                Console.WriteLine("El ganador es: " + equipo1F.nombreF);
            }

            else
            {
                Console.WriteLine(equipo1F.nombreF + " " + equipo1F.golesF + "-" + equipo2F.golesF + " " + equipo2F.nombreF);
                Console.WriteLine("El ganador es: " + equipo2F.nombreF);
                Console.ReadKey();
            }
        }   
    }
}
