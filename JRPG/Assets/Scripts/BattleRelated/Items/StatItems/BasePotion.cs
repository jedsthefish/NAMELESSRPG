using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem
{

    public enum PotionTypes
    {
        HEALTH,
        STRENGTH,
        INTELLECT
    }
    
    public PotionTypes PotionType { get; set; }

    public int SpellEffectID { get; set; }



}