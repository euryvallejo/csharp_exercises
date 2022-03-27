using System;

namespace exercises_csharp {
    class Program {
        static void Main (string[] args) {
            //Create a Instance of General Class
            Program ExercisesToRun = new Program ();

            Console.WriteLine ("Menu: Select Exercice Number");
            var NumberExercise = Console.ReadLine ();

            switch (NumberExercise) {
                case "1":
                    ExercisesToRun.InverterNumber2Positions_1 ();
                    break;

            }

        }

        //Return a inverter number of two-digits number
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
    }
}