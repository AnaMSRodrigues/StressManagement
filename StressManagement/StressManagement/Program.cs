// Program.cs
//
// margaridarodrigues
// a26418@alunos.ipca.pt
// 27/10/2023
using System;
using StressData;


namespace StressManagement
{
    class Program
    {
        private static void Main(string[] args)
        {
            BioData b = new BioData();

           Console.WriteLine("{0}", b);
           Console.ReadKey();
           
        }
    }
}