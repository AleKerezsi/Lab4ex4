using System;

namespace Lab4ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care va afisa in ordine elementele unui vector de intregi*/
           
            Console.WriteLine("Introduceti lungimea vectorului: ");
            int lungimeVector = int.Parse(Console.ReadLine());
            
            int[] vectoriIntregi = new int[lungimeVector];

            for (int i = 0; i < lungimeVector; i++) 
            {
                Console.WriteLine("Introduceti elementul de pe pozitia " + i);
                vectoriIntregi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elementele vectorului sunt: ");
            AfiseazaNumereIntregi(vectoriIntregi, 0, lungimeVector);

        }
        
        static void AfiseazaNumereIntregi(int[] vectorIntregi, int step, int finish)
        {
            Console.WriteLine(vectorIntregi[step]);
            step = step + 1;
            if(step==finish)
            {
                return;
            }
            AfiseazaNumereIntregi(vectorIntregi, step, finish);
        }

    }
   
}
