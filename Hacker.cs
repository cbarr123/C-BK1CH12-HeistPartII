using System;

namespace heist2
{
    public class Hacker : IRobber
    {
        //Name
        public string Name {get; set;}
        //SkillLevel
        public int SkillLevel {get; set;}
        //PercentageCut
        public int PercentageCut {get; set;}
        //PerformSkill Method

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking TEST the alarm system. Decreased security {SkillLevel} points");
        }

        public Hacker (string _Name, int _SkillLevel, int _PercentageCut)
        {
            Name = _Name;
            SkillLevel = _SkillLevel;
            PercentageCut = _PercentageCut;
        }
        

        

    }
}