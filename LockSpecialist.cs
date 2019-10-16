namespace heist2
{
    public class LockSpecialist : IRobber
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
            bank.VaultScore = bank.VaultScore - SkillLevel;
        }

        public LockSpecialist (string _Name, int _SkillLevel, int _PercentageCut)
        {
            Name = _Name;
            SkillLevel = _SkillLevel;
            PercentageCut = _PercentageCut;
        }

    }
}