using UnityEngine;
using System.Collections;

public class CreateWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;

    public CreateWeapon() {
        //create weapon and all its properties
        //this randomly generates weapons 
        //possibility to include but mainly will be used as generic template to create specific weapons



        newWeapon = new BaseWeapon();

        newWeapon.ItemName = "LITTLE SWORD";

        

        newWeapon.ItemDescription = "New Weapon";

        newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;

        //makes sword with random stats
        newWeapon.Strength = 2;
        newWeapon.Intellect = 1;

        newWeapon.ExperienceCurrent = 0;
        newWeapon.ExperienceRequired = 100;
        

    }
}
