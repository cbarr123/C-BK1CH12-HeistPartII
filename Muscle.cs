namespace heist2
{
    public class Muscle : IRobber
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
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
        }

        public Muscle (string _Name, int _SkillLevel, int _PercentageCut)
        {
            Name = _Name;
            SkillLevel = _SkillLevel;
            PercentageCut = _PercentageCut;
        }

    }
}