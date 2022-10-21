using System;

namespace PersonalRegister // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbetsMyror arb = new ArbetsMyror("oscar", "wikström", 165);
            Console.WriteLine(arb.getArbetare());

            Queue<ArbetareAbs> queueArbetare = new Queue<ArbetareAbs>();

            queueArbetare.Enqueue(new ArbetsMyror("Aisha", "Hassan", 99));
            queueArbetare.Enqueue(new OverigaArbetare("Laza", "Gabriout", 90));
            queueArbetare.Enqueue(new ArbetsMyror("Oscar", "Wikström", 90));
            queueArbetare.Enqueue(new OverigaArbetare("Alexander", "Nordström", 80));

            foreach (var i in queueArbetare)
            {
                Console.WriteLine(i.getArbetare());
            }

        }
    }
}