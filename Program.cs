using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hacker Hacker1 = new Hacker("Ronny", 60, 33);
            Hacker Hacker2 = new Hacker("Bonny", 40, 20);
            Muscle Muscle1 = new Muscle("Guido", 30, 23);
            Muscle Muscle2 = new Muscle("Lido", 45, 33);
            LockSpecialist LockSpecialist1 = new LockSpecialist("Tom", 33,13);
            LockSpecialist LockSpecialist2 = new LockSpecialist("Sam", 60,33);

            Console.WriteLine($"{Hacker1.Name} is hacking the alarm system. Decreased security {Hacker1.SkillLevel} points");
            Console.WriteLine($"{Muscle1.Name} is hacking the alarm system. Decreased security {Muscle1.SkillLevel} points");
            Console.WriteLine($"{LockSpecialist1.Name} is hacking the alarm system. Decreased security {LockSpecialist1.SkillLevel} points");

            
            List<IRobber> rolodex = new List<IRobber>(){
                Hacker1, Muscle1, LockSpecialist1, Hacker2, Muscle2, LockSpecialist2
            };

            //When the program starts, print out the number of current operatives in the Rolodex.
            Console.WriteLine("=========================");
            Console.WriteLine($"You have {rolodex.Count} operatives in the rolodex");
            Console.WriteLine("Please enter the name of a possible new operative:");
            string NewName = Console.ReadLine();
            
            while(NewName != "")
            {
                Console.WriteLine("Please select the operatives specialty:");
                Console.WriteLine("1 - Hacker (Disables alarms)");
                Console.WriteLine("2 - Muscle (Disarms guards)");
                Console.WriteLine("3 - Lock Specialist (cracks vault)");
                int NewSelection = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the operatives skill on a scale of 1 - 100");
                int NewSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the operatives cut of the action");
                int NewPercentageCut = int.Parse(Console.ReadLine());
                // Console.WriteLine($"You entered {NewName} with a skill of {NewSelection} and Level of {NewSkillLevel} and cut of {NewPercentageCut }.");
                Console.WriteLine("=========================");
            


                if(NewSelection == 1)
                {
                    Hacker NextHacker = new Hacker(NewName, NewSkillLevel, NewPercentageCut);
                    rolodex.Add(NextHacker);
                    
                } else if(NewSelection == 2)
                {
                    Muscle NextMuscle = new Muscle(NewName, NewSkillLevel, NewPercentageCut);
                    rolodex.Add(NextMuscle);
                } else if(NewSelection == 3)
                {
                    LockSpecialist NextLockSpecialist = new LockSpecialist(NewName, NewSkillLevel, NewPercentageCut);
                    rolodex.Add(NextLockSpecialist);
                }
                Console.WriteLine("Please enter the name of a possible new operative:");
                NewName = Console.ReadLine();
            }
            Random RandomNumber = new Random();
            Bank Newbank = new Bank()
            {
                CashOnHand = RandomNumber.Next(49_999, 1_000_000_000),
                AlarmScore = RandomNumber.Next(0, 101),
                VaultScore = RandomNumber.Next(0, 101),
                SecurityGuardScore = RandomNumber.Next(0, 101)
            };

            Console.WriteLine("=========Recon Report==========");
            Console.WriteLine();



            foreach(var robber in rolodex)
            {
                Console.WriteLine(robber);
            }

            
            

            
            
            

        }
    }
}
