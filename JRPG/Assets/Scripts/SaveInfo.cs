using UnityEngine;
using System.Collections;

public class SaveInfo {

    /// <summary>
    /// RESEARCH SERALIZATION
    /// SAVE PLAYER PREFS IS FOR SMALL AMOUNT OF INFO
    /// 
    /// 
    /// </summary>
    

    public static void SaveAllInfo()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("INTELLECT)", GameInformation.Intellect);
        //PlayerPrefs.SetInt("PlayerCLASS", GameInformation.PlayerClass);
    }



}
