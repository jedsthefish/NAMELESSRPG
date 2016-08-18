using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseHero : BaseCharacter
{
    
   //Basic Info
    public string CharacterName { get; set; }
    public int CharacterLevel { get; set; }


    //Stats
    public int BaseHP { get; set; }
    public int CurrentHP { get;set;}

    public int BaseMP { get;set;}
    public int CurrentMP { get; set; }
    
    public int Strength { get; set; }
    public int Intellect { get; set; }

    public int Skill { get; set; }
    public int Speed { get; set; }
    
    public float CurrentExperience { get; set; }
    public float RequiredExperience { get; set; }
    
    

}
