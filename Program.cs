using System;

namespace determinar_par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Numero: ");
            int numer1=Convert.ToInt32(Console.ReadLine());
            
            if (numer1 %2 == 0)
            {
              Console.WriteLine("Su numero es Par");  
            }
        
            else
            {
                Console.WriteLine("Su numero es Impar");
            }







        }
    }
}
