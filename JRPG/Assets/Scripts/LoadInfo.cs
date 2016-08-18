using UnityEngine;
using System.Collections;

public class LoadInfo 
{

    public static void LoadAllInfo()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        

    }

}
