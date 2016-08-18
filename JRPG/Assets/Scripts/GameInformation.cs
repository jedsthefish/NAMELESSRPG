using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    

    public static string PlayerName { get; set; }
    public static int PlayerLevel{ get; set; }
    public static BaseHero PlayerClass { get; set; }
    public static int Strength { get; set; }
    public static int Intellect { get; set; }
    public static float CurrentExperience { get; set; }
    public static float RequiredExperience { get; set; }

}
