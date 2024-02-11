using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using exercises_csharp.ListClass;
using exercises_csharp.Exceptions;

namespace exercises_csharp {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("List of Excercises");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1 - Excercise List");
            Console.WriteLine("2 - Excersise Exception");
            Console.WriteLine("--------------------------------");
            var Exercise = Console.ReadLine();
            
            Program Info = new Program();

            switch (Exercise) {
                case "1":
                    Info.ListExcercisesProcess();
                    break;
                case "2":
                     Info.ShowExercisesException();
                    break;
            }
        }
        public void ListExcercisesProcess(){

            IDictionary<int, string> Listado = new Dictionary<int, string> ();

                //Create a Instance of General Class
                ListExcercises ExercisesToRun = new ListExcercises ();

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
        public void ShowExercisesException(){
               IDictionary<int, string> Listado = new Dictionary<int, string> ();
               
            //Create a Instance of General Class
            ExceptionClass Ec = new ExceptionClass();

            Listado.Add (1, "FormatException");
            Listado.Add (2, "DivideByZero");

            Console.WriteLine ("Menu: List of Exercises");
            foreach (KeyValuePair<int, string> s in Listado) {
                Console.WriteLine ("ID Example: {0} Description: {1}", s.Key, s.Value);
            }
            Console.WriteLine ("Select number of Exception exercises, please");
                var NumberExercise = Console.ReadLine ();

                switch (NumberExercise) {
                    case "1":
                        Ec.DemostrationMessage();
                        break;
                    case "2":
                        Ec.DivideNumber();
                        break;
                }

            
            
        }
    }
}