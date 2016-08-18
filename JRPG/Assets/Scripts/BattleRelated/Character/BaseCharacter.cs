using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseCharacter
{

    public string Name { get; set; }

    public float BaseHp { get; set; }
    public float CurentHP { get; set; }
    
    public float BaseMP { get; set; }
    public float CurrentMP { get; set; }
    public float Speed { get; set; }
    
}
