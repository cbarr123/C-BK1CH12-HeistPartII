namespace heist2
{
    public class Bank
    {
        int CashOnHand{get; set;}
        int AlarmScore{get; set;}
        int VaultScore{get; set;}
        int SecurityGuardScore{get; set;}
        /* A computed boolean property called IsSecure. If all the scores are 
        less than or equal to 0, this should be false. If any of the scores are above 0, this should be true */

        public bool IsSecure 
            {
                get
                {
                    if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <=0)
                    {
                        return false;
                    } else 
                    {
                        return true;
                    }

                }

            }
        
    }
}