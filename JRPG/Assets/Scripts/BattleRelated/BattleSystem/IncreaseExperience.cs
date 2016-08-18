using UnityEngine;
using System.Collections;

public static class IncreaseExperience{


    private static float experienceToGive;

    private static LevelUpCharacter levelUpScript = new LevelUpCharacter();


    public static void AddExperience()
    {


        //SHOULD SET A MAX LEVEL AND PUT INTO THIS CHECK DOWN HERE 
        //IF MAX LEVEL SAY TO HELL WITH EXPERIENCE GAIN

        experienceToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentExperience += experienceToGive;


        if(GameInformation.CurrentExperience >= GameInformation.RequiredExperience)
        {
            levelUpScript.LevelUp();
        }

    }

    //Could potentially add experience for different things such as exploring and finding new items/areas
    //Also weapon exp will go here as well i guess


}
