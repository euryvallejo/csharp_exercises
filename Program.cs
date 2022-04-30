using System;
using System.Collections.Generic;
using System.Linq;
namespace exercises_csharp {
    class Program {

        static void Main (string[] args) {

            IDictionary<int, string> Listado = new Dictionary<int, string> ();

            //Create a Instance of General Class
            Program ExercisesToRun = new Program ();

            Listado.Add (1, "Inverter Two position numbers");
            Listado.Add (2, "Inverter Three position numbers");

            Console.WriteLine ("Menu: List of Exercises");
            foreach (KeyValuePair<int, string> s in Listado) {
                Console.WriteLine ("ID Example: {0} Description: {1}", s.Key, s.Value);
            }
            Console.WriteLine ("Select number of exercises, please");
            var NumberExercise = Console.ReadLine ();

            switch (NumberExercise) {
                case "1":
                    ExercisesToRun.InverterNumber2Positions_1 ();
                    break;
                case "2":
                    ExercisesToRun.InverterNumber3Positions_2 ();
                    break;

            }

        }

        //1) Return a inverter number of two-digits number
        void InverterNumber2Positions_1 () {
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
        void InverterNumber3Positions_2 () {
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