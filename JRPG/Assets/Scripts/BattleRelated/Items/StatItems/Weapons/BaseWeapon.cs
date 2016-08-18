using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem
{

    public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        POLEARM
    }
    
    public WeaponTypes WeaponType { get; set; }

    public int SpellEffectID { get; set; }
    public int Strength { get; set; }

    public int Intellect { get; set; }





}