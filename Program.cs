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

            Console.WriteLine($"{Ronny.Name} is hacking the alarm system. Decreased security {Ronny.SkillLevel} points");
            Console.WriteLine($"{Guido.Name} is hacking the alarm system. Decreased security {Guido.SkillLevel} points");
            Console.WriteLine($"{Tom.Name} is hacking the alarm system. Decreased security {Tom.SkillLevel} points");

            

            

        }
    }
}
