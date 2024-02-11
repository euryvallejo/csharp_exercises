using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercises_csharp.ListClass
{
    public class ListExcercises
    {
         //1) Return a inverter number of two-digits number
        public void InverterNumber2Positions_1 () {
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine ("Enter two-digits number");
            linea = Console.ReadLine ();
            NUM = int.Parse (linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;

            Console.WriteLine ("Inverter number is: " + AUX);
            Console.WriteLine ("Press to end");
            Console.ReadLine ();
        }
        //2) Return a inverter number of three-digits number
        public void InverterNumber3Positions_2 () {
            int NUM, AUX, DEC, UNI, CEN;
            string linea;
            Console.WriteLine ("Enter three-digits number");
            linea = Console.ReadLine ();
            NUM = int.Parse (linea);
            CEN = NUM / 100;
            NUM = NUM % 100;
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine ($"NUM: {NUM}, CEN: {CEN}, DEC: {DEC}, UNI: {UNI}");
            Console.WriteLine ("Inverter number is: " + AUX);
            Console.WriteLine ("Press to end");
            Console.ReadLine ();
        }
    }
}