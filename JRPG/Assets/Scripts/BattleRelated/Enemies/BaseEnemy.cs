using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEnemy : BaseCharacter {

    public string EnemyName { get; set; }

    public float BaseHp { get; set; }
    public float CurentHP { get; set; }

    public enum Atrribute {

        grass,
        fire,
        water,
        electric

    };

    public enum Rarity
    {
        common,
        uncommon,
        rare,
        ultrarare
    }

    public Atrribute EnemyAttribute { get; set; }





}
