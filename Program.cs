using System;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hacker Ronny = new Hacker("Ronny", 60, 33);
            Muscle Guido = new Muscle("Guido", 40, 33);
            LockSpecialist Tom = new LockSpecialist("Tom", 33,33);

            Console.WriteLine($"{Ronny.Name} Mr. Hacker is hacking the alarm system. Decreased security 50 points");
            Console.WriteLine($"{Guido.Name} Mr. Muscle is hacking the alarm system. Decreased security 50 points");
            Console.WriteLine($"{Tom.Name} Mr. LockSpecialist is hacking the alarm system. Decreased security 50 points");

            var Rolodex = 

        }
    }
}
