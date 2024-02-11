using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace exercises_csharp.Exceptions
{
    public class ExceptionClass
    {
        public void DemostrationMessage(){
            bool continuation;
            do {
                try {
                    continuation = false;
                    Console.Write("Insert value:");
                    string linea = Console.ReadLine();
                    var num = int.Parse(linea);
                    var square = num * num;
                    Console.WriteLine($"The square of {num} is {square}");
                }
                catch(FormatException e){
                    Console.WriteLine($"The Square value could be a number");
                    continuation = true;
                }
            } 
            while(continuation);
            Console.ReadKey();
        }

        public void DivideNumber(){
            bool continuation;
            do {
                try {
                    continuation = false;    
                    Console.WriteLine($"Insert the first Number");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Insert the second Number");
                    var num2 = int.Parse(Console.ReadLine());
                    var result = num1 / num2;
                    Console.WriteLine($"The division of {num1} and {num2} is {result}");
                }
                catch(FormatException e){
                    Console.WriteLine($"Only required numbers");
                    continuation = true;
                }
                catch(DivideByZeroException e){
                    Console.WriteLine($"Don't can be possible divide Zero");
                    continuation = true;
                }
            }
            while(continuation);
            Console.ReadKey();
        }

    }
}