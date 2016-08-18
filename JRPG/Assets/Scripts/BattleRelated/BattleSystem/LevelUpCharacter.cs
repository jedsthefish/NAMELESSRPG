using UnityEngine;
using System.Collections;

public class LevelUpCharacter{

    public void LevelUp()
    {
        if(GameInformation.CurrentExperience >= GameInformation.RequiredExperience)
        {
            GameInformation.CurrentExperience -= GameInformation.RequiredExperience;

            ///
            ///HAVE CHECKS FOR WEAPON THAT CHARACTER HAS TO LEVEL UP CERTAIN STATS 
            ///
            ///DETERMINE WHAT YOUR NEW REQUIRED EXP IS FOR NEXT LEVEL
            ///
            ///ALSO SET PLAYER LEVEL HIGHER



        }



    }
}
